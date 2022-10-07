using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using Word = Microsoft.Office.Interop.Word;

namespace NpaManager {
   public partial class Form1 : Form {
      #region Fields
      private INpaDocParser parser;
      private NpaDataSet.PeriodsRow currentPeriod;
      private ExportToWord exp;
      #endregion

      #region Properties
      /// <summary>
      /// Открытый документ проектов НПА
      /// </summary>
      public string OpenedDoc {
         get { return Properties.Settings.Default.LastOpenedDoc; }
         set { Properties.Settings.Default.LastOpenedDoc = value; }
      }
      #endregion

      #region Constructors
      public Form1() {
         InitializeComponent();
         bindingNavigator1.BindingSource = npaIGridCtrl1.BindingSrc;
      }
      #endregion

      #region Methods
      /// <summary>
      /// Открыть проект НПА
      /// </summary>
      private void ChangeTitle(string filename) {
         string docname = Path.GetFileNameWithoutExtension(filename);
         this.Text = string.Format("Просмотр планов НПА ({0})", docname);
      }

      /// <summary>
      /// Отобразить сообщение в строке состояния
      /// </summary>
      public void SetStatus(string message) {
         if (this.InvokeRequired) {
            this.Invoke((MethodInvoker)delegate {
               toolStatusLabel.Text = message;
            });
         } else {
            toolStatusLabel.Text = message;
         }
      }

      /// <summary>
      /// Отобразить период в строке состояния
      /// </summary>
      public void SetPeriod(string period) {
         if (this.InvokeRequired) {
            this.Invoke((MethodInvoker)delegate {
               toolPeriodLabel.Text = period;
            });
         } else {
            toolPeriodLabel.Text = period;
         }
      }

      /// <summary>
      /// Отобразить в строке состояния, метку цветом в зависимости от состояния грида
      /// </summary>
      private void SetStatusTrafficLight(ToolStripStatusLabel lbl, NpaGridState state) {
         if (this.InvokeRequired) {
            switch (state) {
               case NpaGridState.Red:
                  lbl.BackColor = Color.Red;
                  break;
               case NpaGridState.Yellow:
                  lbl.BackColor = Color.Yellow;
                  break;
               case NpaGridState.Green:
                  lbl.BackColor = Color.Green;
                  break;
               default:
                  break;
            }
         } else {
            switch (state) {
               case NpaGridState.Red:
                  lbl.BackColor = Color.Red;
                  break;
               case NpaGridState.Yellow:
                  lbl.BackColor = Color.Yellow;
                  break;
               case NpaGridState.Green:
                  lbl.BackColor = Color.Green;
                  break;
               default:
                  break;
            }
         }
      }

      /// <summary>
      /// Асинхронно загрузить все таблицы
      /// </summary>
      private void AsyncLoadAllTables() {
         if (parser != null) {
            parser.ParseTableAsync(npaIGridCtrl1);
            parser.ParseTableAsync(npaIIGridCtrl1);
            parser.ParseTableAsync(npaIIIGridCtrl1);
            parser.ParseTableAsync(npaIVGridCtrl1);
         }
      }

      /// <summary>
      /// Загрузить данные из Word
      /// </summary>
      private void LoadFromWord() {
         if (parser != null) {
            parser.CloseDoc();
            parser = null;
         }

         bool enableLoad = true;
         string periodDoc = GetPeriodDoc(OpenedDoc);
         if (periodDoc != currentPeriod.PeriodId) {
            string msg = string.Format("Загружаемый график НПА относится к другому кварталу.\r\r{0}\r\rЗагрузка файла может исказить имеющиеся данные.\rПродолжить загрузку?", periodDoc);
            DialogResult dr = MessageBox.Show(msg, "Внимание!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
               enableLoad = false;
         }

         if (enableLoad) {
            DateTime periodFirst = currentPeriod.DateFirst;
            DateTime periodLast = currentPeriod.DateEnd;
            int ver = Properties.Settings.Default.WordVersion;
            if(ver == 1)
               parser = new NpaDocParser();
            else if (ver == 2)
               parser =  new NpaDocParser2();
            parser.EndTableLoad += parser_EndTableLoad;
            parser.OpenDoc(OpenedDoc, periodFirst, periodLast);

            toolBtnDoWord.Enabled = true;
            MDoWord.Enabled = true;
            Application.DoEvents();

            if (Properties.Settings.Default.AutoLoadDT) {
               AsyncLoadAllTables();
            }
         }
      }

      /// <summary>
      /// Определить период из наименования файла Word
      /// </summary>
      private string GetPeriodDoc(string fileName) {
         string period = "";
         Match m = Regex.Match(fileName, "(?:I|II|III|IV|1|2|3|4) квартал \\d\\d\\d\\d\\sг?");
         if (m != null)
            period = m.Groups[0].Value;
         period = period.Trim();
         if(!period.EndsWith("г"))
            period += " г";
         if(period.StartsWith("1"))
            period = "I" + period.Substring(1);
         else if(period.StartsWith("2"))
            period = "II" + period.Substring(1);
         else if(period.StartsWith("3"))
            period = "III" + period.Substring(1);
         else if(period.StartsWith("4"))
            period = "IV" + period.Substring(1);
         return period;
      }
      
      /// <summary>
      /// Закрыть открытый документ Word
      /// </summary>
      private void CloseWord() {
         if (parser != null) {
            parser.CloseDoc();
            parser.EndTableLoad -= parser_EndTableLoad;
            parser = null;
         }
      }

      /// <summary>
      /// Выполнить обработку открытого документа Word
      /// </summary>
      private void DoWord() {
         if (parser != null) {
            INpaGrid npaGrid = tabControl1.SelectedTabPage.Controls[0] as INpaGrid;
            if (npaGrid != null) {
               parser.ParseTableAsync(npaGrid);
            }
         }
      }

      /// <summary>
      /// Открыть/Закрыть панель выбора периода
      /// </summary>
      private void TogglePeriod() {
         splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
      }

      /// <summary>
      /// Установить авто высоту строк в гридах в соответствии со значением настроек
      /// </summary>
      private void SetDefaultRowAutoHeight() {
         bool isRowAutoHeight = Properties.Settings.Default.RowAutoHeight;
         MRowAutoHeight.Checked = isRowAutoHeight;
         SetRowAutoHeight(isRowAutoHeight);
      }

      /// <summary>
      /// Установить авто высоту строк в гридах
      /// </summary>
      private void SetRowAutoHeight(bool isRowAutoHeight) {
         foreach (XtraTabPage page in tabControl1.TabPages) {
            INpaGrid npaGrid = page.Controls[0] as INpaGrid;
            if (npaGrid != null)
               npaGrid.RowAutoHeight = isRowAutoHeight;
         }
      }

      /// <summary>
      /// Проверить завершенность загрузки всех данных
      /// </summary>
      private bool isAllLoaded() {
         NpaGridState state = NpaGridState.Green;
         foreach (XtraTabPage page in tabControl1.TabPages) {
            INpaGrid npaGrid = page.Controls[0] as INpaGrid;
            state = npaGrid.State;
            if (state != NpaGridState.Green)
               break;
         }

         return (state == NpaGridState.Green) ? true : false;
      }

      /// <summary>
      /// Обновить выпадающий список структурных подразделений
      /// </summary>
      private void ReloadComboIogv() {
         string iogvCurrent = "";
         if (toolStripComboIogv.SelectedItem != null)
            iogvCurrent = toolStripComboIogv.SelectedItem.ToString();
         LoadComboIogv();
         if (toolStripComboIogv.SelectedItem != null && iogvCurrent != "") {
            int idx = toolStripComboIogv.FindString(iogvCurrent);
            if (idx >= 0)
               toolStripComboIogv.SelectedIndex = idx;
         }
      }

      /// <summary>
      /// Загрузить список органов гос власти
      /// </summary>
      private void LoadComboIogv() {
         toolStripComboIogv.Items.Clear();
         toolStripComboIogv.Items.Add("");
         List<string> result = DsHelper.GetCurrentIogv();
         toolStripComboIogv.Items.AddRange(result.ToArray());
         toolStripComboIogv.SelectedIndex = 0;
      }

      /// <summary>
      /// Выполнить сортировку данных по органу власти
      /// </summary>
      private void FilterByIogv(string iogv) {
         string filter = "";
         if ( !string.IsNullOrEmpty(iogv))
            filter = string.Format("Iogv = '{0}'", iogv);

         foreach (XtraTabPage page in tabControl1.TabPages) {
            INpaGrid npaGrid = page.Controls[0] as INpaGrid;
            if (npaGrid != null)
               npaGrid.BindingSrc.Filter = filter;
         }
      }

      /// <summary>
      /// Установить доступность элементов интерфейса для загрузки данных из Word
      /// </summary>
      private void EnableLoadWord(bool periodOk) {
         toolBtnOpenWord.Enabled = periodOk;
         //toolBtnDoWord.Enabled = periodOk;
         //toolBtnCloseWord.Enabled = periodOk;
         MOpenWord.Enabled = periodOk;
         MDoWord.Enabled = periodOk;
         MCloseWord.Enabled = periodOk;
      }
     
      /// <summary>
      /// Загрузить параметры формы из настроек
      /// </summary>
      private void SetupFormProperties() {
         this.Location = Properties.Settings.Default.Form1_Location;
         this.Size = Properties.Settings.Default.Form1_Size;
         this.WindowState = Properties.Settings.Default.Form1_WindowState;
      }

      /// <summary>
      /// Сохранить параметры формы в настройках
      /// </summary>
      private void SaveFormProperties() {
         Properties.Settings.Default.Form1_WindowState = this.WindowState;
         if (this.WindowState == FormWindowState.Normal) {
            Properties.Settings.Default.Form1_Location = this.Location;
            Properties.Settings.Default.Form1_Size = this.Size;
         }
      }

      /// <summary>
      /// Расчитать срок для текущей строки таблицы НПА
      /// </summary>
      private void RecalcDateCurrent() {
         INpaGrid npaGrid = tabControl1.SelectedTabPage.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            npaGrid.RecalcDateCurrent();
         }
      }

      /// <summary>
      /// Расчитать срок для всего выбранного раздела НПА
      /// </summary>
      private void RecalcDatesAll() {
         INpaGrid npaGrid = tabControl1.SelectedTabPage.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            npaGrid.RecalcDatesAll();
         }
      }

      /// <summary>
      /// Очистить сроки этапов для выделенных строк
      /// </summary>
      private void ClearSelectedDeadlines() {
         INpaGrid npaGrid = tabControl1.SelectedTabPage.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            npaGrid.ClearSelectedDeadlines();
         }
      }

      /// <summary>
      /// Выполнить экпорт в Word
      /// </summary>
      /// <param name="version"></param>
      private void ExportToWord(int version) {
         this.Cursor = Cursors.WaitCursor;
         SetStatus("Производится экспорт в Word. Это может занять некоторое время.");
         string templateName = Path.Combine(Application.StartupPath, "График проектов НПА.dotx");
         string fileName = Path.Combine(Application.StartupPath, "График проектов НПА.docx");
         if (version == 2) {
            templateName = Path.Combine(Application.StartupPath, "График проектов НПА v2.dotx");
            fileName = Path.Combine(Application.StartupPath, "График проектов НПА v2.docx");
         }
         exp = new ExportToWord(templateName, fileName, currentPeriod);
         exp.DoIt();
         exp.CloseDoc();
         SetStatus("Экспорт завершен.");
         this.Cursor = Cursors.Default;
         MessageBox.Show("Экспорт завершен");
      }

      #endregion

      #region Events
      /// <summary>
      /// Загружается форма ()
      /// </summary>
      private void Form1_Load(object sender, EventArgs e) {
         this.Text = string.Format("{0} (вер. {1})", this.Text, Application.ProductVersion);
         //-- Загрузить из настроек приложения
         SetupFormProperties();
         //-- Загрузить справочные данные из БД
         DsHelper.FillRefData();
         periodTreeCtrl1.LoadData();

         string msg = "Приложение загружено и готово к работе";
         if (OpenedDoc != "") {
            if(File.Exists(OpenedDoc)) {
               ChangeTitle(OpenedDoc);
               msg = string.Format("{0}. Выбран файл Word '{1}'", msg, OpenedDoc);
            } else
               OpenedDoc = " ";
         }
         npaIGridCtrl1.TableName = "NpaI";
         npaIIGridCtrl1.TableName = "NpaII";
         npaIIIGridCtrl1.TableName = "NpaIII";
         npaIVGridCtrl1.TableName = "NpaIV";
         splitContainer1.Panel1Collapsed = Properties.Settings.Default.Panel1Collapsed;
         SetDefaultRowAutoHeight();
         ReloadComboIogv();
         SetStatus(msg);
      }

      /// <summary>
      /// Обработка при закрытии формы
      /// </summary>
      private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
         // проверить наличие не сохраненных данных и предложить выполнить сохранение
         int count = DsHelper.GetModifiedCount();
         if (count > 0) {
            string msg = string.Format("Имеется {0} не сохраненных в БД записей.\rСохранить изменения?", count);
            DialogResult dr = MessageBox.Show(msg, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.DoEvents();
            if (dr == DialogResult.Yes) {
               this.Cursor = Cursors.WaitCursor;
               SetStatus("Производится сохранение данных.");
               Application.DoEvents();
               DsHelper.UpdateAll();
               this.Cursor = Cursors.Default;
            }
         }

         if (periodTreeCtrl1.CurrentPeriod != null)
            Properties.Settings.Default.PeriodId = periodTreeCtrl1.CurrentPeriod.PeriodId;
         else
            Properties.Settings.Default.PeriodId = "";

         SaveFormProperties();
         Properties.Settings.Default.RowAutoHeight = MRowAutoHeight.Checked;
         Properties.Settings.Default.Panel1Collapsed = splitContainer1.Panel1Collapsed;
         Properties.Settings.Default.Save();
         
         if (parser != null) {
            parser.CloseDoc();
         }
      }

      /// <summary>
      /// Файл | Новый
      /// </summary>
      private void MNew_Click(object sender, EventArgs e) {
         if (exp != null) {
            exp.CloseDoc();
            exp = null;
         }
      }

      /// <summary>
      /// Файл | Выбрать
      /// </summary>
      private void MSelectWord_Click(object sender, EventArgs e) {
         OpenFileDialog ofd = new OpenFileDialog();
         ofd.Filter = "Документ Word (*.docx)|*.docx|Документ Word 97-2003 (*.doc)|*.doc|Все файлы (*.*)|*.*";
         DialogResult dr = ofd.ShowDialog(this);
         if(dr == DialogResult.OK) {
            OpenedDoc = ofd.FileName;
            ChangeTitle(OpenedDoc);
            string msg = string.Format("Приложение загружено и готово к работе. Выбран файл Word '{0}'", OpenedDoc);
            SetStatus(msg);
         }
      }

      /// <summary>
      /// Файл | Сохранить
      /// </summary>
      private void MSave_Click(object sender, EventArgs e) {
         this.Cursor = Cursors.WaitCursor;
         int count = DsHelper.UpdateAll();

         npaIGridCtrl1.State = NpaGridState.Green;
         SetStatusTrafficLight(toolStatusLabelI, npaIGridCtrl1.State);

         npaIIGridCtrl1.State = NpaGridState.Green;
         SetStatusTrafficLight(toolStatusLabelII, npaIIGridCtrl1.State);

         npaIIIGridCtrl1.State = NpaGridState.Green;
         SetStatusTrafficLight(toolStatusLabelIII, npaIIIGridCtrl1.State);

         npaIVGridCtrl1.State = NpaGridState.Green;
         SetStatusTrafficLight(toolStatusLabelIV, npaIVGridCtrl1.State);
         
         string msg = string.Format("Сохранение выполнено. ({0} шт.)", count);
         SetStatus(msg);
         this.Cursor = Cursors.Default;
      }

      /// <summary>
      /// Файл | Сохранить как Word | шаблон вер. 1.0
      /// </summary>
      private void MSaveWordVer1_Click(object sender, EventArgs e) {
         ExportToWord(1);
      }

      /// <summary>
      /// Файл | Сохранить как Word | шаблон вер. 2.0
      /// </summary>
      private void MSaveWordVer2_Click(object sender, EventArgs e) {
         ExportToWord(2);
      }

      /// <summary>
      /// Файлы | Справочники | Органы власти
      /// </summary>
      private void MIogvRef_Click(object sender, EventArgs e) {
         IogvRefDialog refDialog = new IogvRefDialog();
         DialogResult dr = refDialog.ShowDialog();
         if (dr == DialogResult.OK) {
            int cnt = DsHelper.UpdateIogvRef();
            ReloadComboIogv();
         }
         
      }

      /// <summary>
      /// Файлы | Справочники | Виды НПА
      /// </summary>
      private void MKindNpaRef_Click(object sender, EventArgs e) {
         NpaKindRefDialog refDialog = new NpaKindRefDialog();
         DialogResult dr = refDialog.ShowDialog();
         if (dr == DialogResult.OK) {
         }
      }

      /// <summary>
      /// Файл | Настройки
      /// </summary>
      private void MOptions_Click(object sender, EventArgs e) {
         this.Cursor = Cursors.WaitCursor;
         OptionsDialog od = new OptionsDialog();

         if (currentPeriod != null) {
            DsHelper.FillDeadlinesByPeriodid(currentPeriod.PeriodId);
         } else {
            DsHelper.FillDeadlinesByPeriodid("");
         }
         NpaDataSet.DeadlinesRow r = DsHelper.DS.Deadlines[0];
         od.DeadlineOrgI = r.DeadlineOrgI;
         od.DeadlineLingvI = r.DeadlineLingvI;
         od.DeadlineEconI = r.DeadlineEconI;
         od.DeadlineLawI = r.DeadlineLawI;
         od.DeadlineAssemblyII = r.DeadlineAssemblyII;
         od.DeadlineOtherII = r.DeadlineOtherII;
         od.DeadlineLawII = r.DeadlineLawII;
         od.DeadlineLingvIII = r.DeadlineLingvIII;
         od.DeadlineLawIII = r.DeadlineLawIII;
         od.DeadlineLavIV = r.DeadlineLawIV;

         od.AutoLoadDT = Properties.Settings.Default.AutoLoadDT;
         od.WordVerson = Properties.Settings.Default.WordVersion;

         DialogResult dr = od.ShowDialog(this);
         this.Cursor = Cursors.Default;
         if (dr == DialogResult.OK) {
            Properties.Settings.Default.AutoLoadDT = od.AutoLoadDT;
            Properties.Settings.Default.WordVersion = od.WordVerson;

            r.DeadlineOrgI = od.DeadlineOrgI;
            r.DeadlineLingvI = od.DeadlineLingvI;
            r.DeadlineEconI = od.DeadlineEconI;
            r.DeadlineLawI = od.DeadlineLawI;
            r.DeadlineAssemblyII = od.DeadlineAssemblyII;
            r.DeadlineOtherII = od.DeadlineOtherII;
            r.DeadlineLawII = od.DeadlineLawII;
            r.DeadlineLingvIII = od.DeadlineLingvIII;
            r.DeadlineLawIII = od.DeadlineLawIII;
            r.DeadlineLawIV = od.DeadlineLavIV;
            DsHelper.UpdateDeadlines();
         }
      }

      /// <summary>
      /// Файл | Выход
      /// </summary>
      private void MExit_Click(object sender, EventArgs e) {
         this.Close();
      }

      /// <summary>
      /// Отчеты | Справочник подразделений
      /// </summary>
      private void MRptIogvRef_Click(object sender, EventArgs e) {
         this.Cursor = Cursors.WaitCursor;
         IogvReport rpt = new IogvReport();
         Application.DoEvents();
         ReportPrintTool prnTools = new ReportPrintTool(rpt);
         prnTools.ShowPreviewDialog();
         // Edit Report
         //ReportDesignTool designTool = new ReportDesignTool(rpt);
         //designTool.ShowDesignerDialog();
         this.Cursor = Cursors.Default;
      }

      /// <summary>
      /// Отчеты | Справочник НПА по подразделению
      /// </summary>
      private void MRptNpaByIogv_Click(object sender, EventArgs e) {
         this.Cursor = Cursors.WaitCursor;
         NpaByIogvRpt rpt = new NpaByIogvRpt();
         Application.DoEvents();
         ReportPrintTool prnTools = new ReportPrintTool(rpt);
         prnTools.ShowPreviewDialog();
         this.Cursor = Cursors.Default;
      }

      /// <summary>
      /// Отчеты | Справочник НПА по всем подразделениям
      /// </summary>
      private void MRptNpaAllIogv_Click(object sender, EventArgs e) {
         this.Cursor = Cursors.WaitCursor;
         NpaAllIogvRpt rpt = new NpaAllIogvRpt();
         Application.DoEvents();
         ReportPrintTool prnTools = new ReportPrintTool(rpt);
         prnTools.ShowPreviewDialog();
         this.Cursor = Cursors.Default;
      }

      /// <summary>
      /// Задачи|Открыть Word
      /// </summary>
      private void MOpenWord_Click(object sender, EventArgs e) {
         LoadFromWord();
      }

      /// <summary>
      /// Задачи|Закрыть Woed
      /// </summary>
      private void MCloseWord_Click(object sender, EventArgs e) {
         CloseWord();
      }

      /// <summary>
      /// Задачи|Выполнить обработку
      /// </summary>
      private void MDoWord_Click(object sender, EventArgs e) {
         DoWord();
      }

      /// <summary>
      /// Задачи|Расчитать срок|Для текущей строки
      /// </summary>
      private void MRecalcDateCurrent_Click(object sender, EventArgs e) {
         RecalcDateCurrent();
      }

      /// <summary>
      /// Задачи|Расчитать срок|Для всего раздела
      /// </summary>
      private void MRecalcDatesAll_Click(object sender, EventArgs e) {
         RecalcDatesAll();
      }

      /// <summary>
      /// Задачи|Расчитать срок|Очистить для выделенных строк
      /// </summary>
      private void MClearSelected_Click(object sender, EventArgs e) {
         ClearSelectedDeadlines();
      }

      /// <summary>
      /// Вид | Скрыть/Отобразить парель выбора периода
      /// </summary>
      private void MTogglePeriod_Click(object sender, EventArgs e) {
         TogglePeriod();
      }

      /// <summary>
      ///  Вид | Автоподбор ширины строк
      /// </summary>
      private void MRowAutoHeight_Click(object sender, EventArgs e) {
         ToolStripMenuItem item = sender as ToolStripMenuItem;
         item.Checked = !item.Checked;
         bool isRowAutoHeight = item.Checked;
         SetRowAutoHeight(isRowAutoHeight);
      }

      /// <summary>
      /// Нажали кнопку добавления новой записи в табл. в навигаторе БД
      /// </summary>
      private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
         INpaGrid npaGrid = tabControl1.SelectedTabPage.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            npaGrid.AddNewRow();
         }
      }

      /// <summary>
      /// Нажали кнопку "Открыть приложение Word"
      /// </summary>
      private void toolBtnOpenWord_Click(object sender, EventArgs e) {
         LoadFromWord();
      }

      /// <summary>
      /// Нажали кнопку "Закрыть приложение Word"
      /// </summary>
      private void toolBtnCloseWord_Click(object sender, EventArgs e) {
         CloseWord();
      }

      /// <summary>
      /// Нажали кнопку "Выполнить обработку Word"
      /// </summary>
      private void toolBtnDoWord_Click(object sender, EventArgs e) {
         DoWord();
      }

      /// <summary>
      /// Нажали кнопку на панели инструментов
      /// </summary>
      private void toolBtnTogglePeriod_Click(object sender, EventArgs e) {
         TogglePeriod();
      }

      /// <summary>
      /// Нажали кнопку "Расчитать срок для текущей строки" на панели инструментов
      /// </summary>
      private void ToolStripMRecalcDateCurrent_Click(object sender, EventArgs e) {
         RecalcDateCurrent();
      }

      /// <summary>
      /// Нажали кнопку "Расчитать срок для всего раздела" на панели инструментов
      /// </summary>
      private void ToolStripMRecalcDatesAll_Click(object sender, EventArgs e) {
         RecalcDatesAll();
      }

      /// <summary>
      /// Нажали кнопку "Очистить для выделенных строк" на панели инструментов
      /// </summary>
      private void ToolStripMClearSelected_Click(object sender, EventArgs e) {
         ClearSelectedDeadlines();
      }

      /// <summary>
      /// Выбрали орган власти из выпадаюшего списка
      /// </summary>
      private void toolStripComboIogv_SelectedIndexChanged(object sender, EventArgs e) {
         string iogv = toolStripComboIogv.SelectedItem.ToString();
         FilterByIogv(iogv);
         string msg = string.Format("Выбрано: {0}", iogv);
         SetStatus(msg);
      }

      /// <summary>
      /// Изменилось состояние элемента управления для выбора периода
      /// </summary>
      private void periodTreeCtrl1_PropertyChanged(object sender, PropertyChangedEventArgs e) {
         bool editable = periodTreeCtrl1.Editable;
         if (e.PropertyName == "CurrentPeriod") {
            currentPeriod = null;
            string msg = "не задан";
            if (periodTreeCtrl1.CurrentPeriod != null) {
               currentPeriod = periodTreeCtrl1.CurrentPeriod;
               msg = currentPeriod.PeriodId;
            }
            SetPeriod(msg);
            //SetStatus("Установлен новый период   " + msg);
            DsHelper.FillNpaData(currentPeriod);   // Загрузить данные НПА из БД
            LoadComboIogv();                       // Перечитать список органов власти
         }
         if (e.PropertyName == "CurrentPeriod" || e.PropertyName == "Editable") {
            EnableLoadWord(editable);
            bindingNavigatorAddNewItem.Enabled = editable;
            bindingNavigatorDeleteItem.Enabled = editable;
            npaIGridCtrl1.Editable = editable;
            npaIIGridCtrl1.Editable = editable;
            npaIIIGridCtrl1.Editable = editable;
            npaIVGridCtrl1.Editable = editable;
         }
      }

      /// <summary>
      /// Переход на другую вкладку
      /// </summary>
      private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
         XtraTabPage page = tabControl1.SelectedTabPage;
         INpaGrid npaGrid = page.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            bindingNavigator1.BindingSource = npaGrid.BindingSrc;
         } else {
            bindingNavigator1.BindingSource = null;
         }
      }

      /// <summary>
      /// Переход на другую вкладку
      /// </summary>
      private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e) {
         XtraTabPage page = e.Page;
         if (page == null) return;
         INpaGrid npaGrid = page.Controls[0] as INpaGrid;
         if (npaGrid != null) {
            bindingNavigator1.BindingSource = npaGrid.BindingSrc;
         } else {
            bindingNavigator1.BindingSource = null;
         }
      }

      /// <summary>
      /// Изменилось состояние
      /// </summary>
      private void npaGridCtrl1_PropertyChanged(object sender, PropertyChangedEventArgs e) {
         if (e.PropertyName == "State") {
            INpaGrid npaGrid = sender as INpaGrid;
            SetStatusTrafficLight(toolStatusLabelI, npaGrid.State);
         }
      }

      /// <summary>
      /// Изменилось состояние
      /// </summary>
      private void npaIIGridCtrl1_PropertyChanged(object sender, PropertyChangedEventArgs e) {
         if (e.PropertyName == "State") {
            INpaGrid npaGrid = sender as INpaGrid;
            SetStatusTrafficLight(toolStatusLabelII, npaGrid.State);
         }
      }

      /// <summary>
      /// Изменилось состояние
      /// </summary>
      private void npaIIIGridCtrl1_PropertyChanged(object sender, PropertyChangedEventArgs e) {
         if (e.PropertyName == "State") {
            INpaGrid npaGrid = sender as INpaGrid;
            SetStatusTrafficLight(toolStatusLabelIII, npaGrid.State);
         }
      }

      /// <summary>
      /// Изменилось состояние
      /// </summary>
      private void npaIVGridCtrl1_PropertyChanged(object sender, PropertyChangedEventArgs e) {
         if (e.PropertyName == "State") {
            INpaGrid npaGrid = sender as INpaGrid;
            SetStatusTrafficLight(toolStatusLabelIV, npaGrid.State);
         }
      }
      
      /// <summary>
      /// Загрузка табл. Word завершена
      /// </summary>
      void parser_EndTableLoad(object sender, EndTableLoadEventAgs e) {
         string msg = string.Format("Завершена загрузка табл. {0}", e.NpaGrid.TableName);
         SetStatus(msg);
         e.NpaGrid.BindingSrc.ResetBindings(false);
         ReloadComboIogv();
         if (isAllLoaded()) {
            SetStatus("Загрузка всех данных завершена.");
         }
      }
      #endregion
   }
}
