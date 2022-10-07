using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace NpaManager {
   public partial class PeriodTreeCtrl : UserControl, INotifyPropertyChanged {
      #region Fields
      private NpaDataSet.PeriodsRow newPeriodRow;
      #endregion

      #region Properties
      /// <summary>
      /// Выбранный период
      /// </summary>
      public NpaDataSet.PeriodsRow CurrentPeriod { get; private set; }

      /// <summary>
      /// признак разрешения на правку данных текущего периода
      /// </summary>
      public bool Editable {
         get {
            if (CurrentPeriod != null)
               return CurrentPeriod.Editable;
            return false;
         }
      }
      #endregion

      #region Constructors
      public PeriodTreeCtrl() {
         InitializeComponent();
         newPeriodRow = null;
         DS = DsHelper.DS;
         bindingSrc.DataSource = DS;
      }
      #endregion

      #region Methods
      /// <summary>
      /// Загрузить данные
      /// </summary>
      public void LoadData() {
         CreateNodes(treeList1);
         string periodId = Properties.Settings.Default.PeriodId;
         if (!string.IsNullOrEmpty(periodId)) {
            CurrentPeriod = DsHelper.DS.Periods.FindByPeriodId(periodId);
            DsHelper.SetDefaultPeriod(CurrentPeriod);
            OnPropertyChanged("CurrentPeriod");
            var node = treeList1.FindNodeByFieldValue("PeriodId", periodId);
            if (node != null)
               node.Selected = true;
         }
      }

      /// <summary>
      /// Создать узлы дерева
      /// </summary>
      private void CreateNodes(TreeList tl) {
         tl.BeginUnboundLoad();
         // получить список годов
         List<int> years = (from dataRow in DS.Periods.AsEnumerable<NpaDataSet.PeriodsRow>()
                            orderby dataRow.Year
                            select dataRow.Year).Distinct<int>().ToList<int>();
         // Create a root nodes
         foreach (int year in years) {
            TreeListNode parentForRootNodes = null;
            TreeListNode rootNode = tl.AppendNode(new object[] { year }, parentForRootNodes);
            // выбрать поквартально для года
            List<NpaDataSet.PeriodsRow> rows = (from dataRow in DS.Periods.AsEnumerable<NpaDataSet.PeriodsRow>()
                                                   where dataRow.Year == year
                                                   orderby dataRow.Quarter
                                                   select dataRow
                                                   ).ToList();
            foreach (var r in rows) {     //-- добавим дочерние элементы
               TreeListNode node = tl.AppendNode(new object[] { null, r.Quarter, r.PeriodId, r.DateFirst, r.DateEnd, r.Editable, r.Browsable }, rootNode);
               node.Tag = r;
            }
         }

         tl.EndUnboundLoad();
      }

      /// <summary>
      /// Добавить новый квартал
      /// </summary>
      private void AddQuarter() {
         bindingSrc.MoveLast();
         if (bindingSrc.Current != null) {
            DataRowView drv = bindingSrc.Current as DataRowView;
            NpaDataSet.PeriodsRow row = drv.Row as NpaDataSet.PeriodsRow;
            TreeListNode node = treeList1.FindNodeByFieldValue("PeriodId", row.PeriodId);
            if (node != null) {
               int quarter = (row.Quarter + 1) <= 4 ? row.Quarter + 1 : 1;
               int year = (quarter == 1) ? row.Year + 1 : row.Year;
               string periodId = CreatePeriodId(year, quarter);
               DateTime dateFirst = GetDateFirst(year, quarter);
               DateTime dateEnd = GetDateEnd(year, quarter);
               var r = DsHelper.DS.Periods.AddPeriodsRow(periodId, year, quarter, dateFirst, dateEnd, true, true);

               TreeListNode parentNode = node.ParentNode;
               if (quarter == 1) {
                  TreeListNode parentForRootNodes = null;
                  parentNode = treeList1.AppendNode(new object[] { year }, parentForRootNodes);
               }
               node = treeList1.AppendNode(new object[] { null, r.Quarter, r.PeriodId, r.DateFirst, r.DateEnd, r.Editable }, parentNode);
               node.Tag = r;
               parentNode.Expanded = true;
               UpdateData();
            }
         }
      }

      /// <summary>
      /// Удалить последний квартал
      /// </summary>
      private void DelQuarter() {
         bindingSrc.MoveLast();
         if (bindingSrc.Current != null) {
            DataRowView drv = bindingSrc.Current as DataRowView;
            NpaDataSet.PeriodsRow row = drv.Row as NpaDataSet.PeriodsRow;
            TreeListNode node = treeList1.FindNodeByFieldValue("PeriodId", row.PeriodId);
            if (node != null) {
               if (node.Selected) {
                  SelectPrevNode(node);
               }
               TreeListNode parentNode = node.ParentNode;
               bindingSrc.RemoveCurrent();
               treeList1.Nodes.Remove(node);
               if (parentNode.Nodes.Count < 1) {
                  treeList1.Nodes.Remove(parentNode);
               }
            }
            UpdateData();
         }
      }

      /// <summary>
      /// Вернуть строку бд для последнего периода
      /// </summary>
      private NpaDataSet.PeriodsRow GetLastPeriod() {
         NpaDataSet.PeriodsRow lastPeriod = null;
         int lastIdx = bindingSrc.Count - 1;
         if (lastIdx >= 0) {
            DataRowView drv = bindingSrc[lastIdx] as DataRowView;
            lastPeriod = drv.Row as NpaDataSet.PeriodsRow;
         }
         return lastPeriod;
      }

      /// <summary>
      /// Выбрать предыдущий узел
      /// </summary>
      private void SelectPrevNode(TreeListNode node) {
         if (node.PrevNode == null) {
            var parentNode = node.ParentNode;
            if (parentNode != null && parentNode.PrevNode != null && parentNode.PrevNode.Nodes.LastNode != null) {
               parentNode.PrevNode.Nodes.LastNode.Selected = true;
            }
         } else
            node.PrevNode.Selected = true;
      }

      /// <summary>
      /// Выполнить обновление табл. периодов в БД
      /// </summary>
      private void UpdateData() {
         DsHelper.UpdatePeriods();
      }

      /// <summary>
      /// Создать id периода
      /// </summary>
      private string CreatePeriodId(int year, int quarter) {
         string periodID = "";
         if (quarter == 1)
            periodID = "I";
         else if (quarter == 2)
            periodID = "II";
         else if (quarter == 3)
            periodID = "III";
         else if (quarter == 4)
            periodID = "IV";
         periodID = string.Format("{0} квартал {1} г", periodID, year);
         return periodID;
      }

      /// <summary>
      /// Начало квартала
      /// </summary>
      private DateTime GetDateFirst(int year, int quarter) {
         DateTime date = DateTime.Today;
         if (quarter == 1) {
            date = new DateTime(year, 1, 1);
         } else if (quarter == 2) {
            date = new DateTime(year, 4, 1);
         } else if (quarter == 3) {
            date = new DateTime(year, 7, 1);
         } else if (quarter == 4) {
            date = new DateTime(year, 10, 1);
         }
         return date;
      }

      /// <summary>
      /// Окончание квартала
      /// </summary>
      private DateTime GetDateEnd(int year, int quarter) {
         DateTime date = DateTime.Today;
         if (quarter == 1) {
            date = new DateTime(year, 3, 31, 23, 59, 59);
         } else if (quarter == 2) {
            date = new DateTime(year, 6, 30, 23, 59, 59);
         } else if (quarter == 3) {
            date = new DateTime(year, 9, 30, 23, 59, 59);
         } else if (quarter == 4) {
            date = new DateTime(year, 12, 31, 23, 59, 59);
         }
         return date;
      }

      /// <summary>
      /// Проверить разрешение на удаление квартала
      /// </summary>
      private bool IsEanbleDeleteQuerter(NpaDataSet.PeriodsRow lastPeriod) {
         if (lastPeriod != null) {
            int childsCount = DsHelper.GetCountChildNpa(lastPeriod.PeriodId);
            return (childsCount < 1) ? true : false;
         }
         return true;
      }

      /// <summary>
      /// Отобразить сообщение в строке состояния
      /// </summary>
      private void SetStatus(string msg) {
         Form f = this.FindForm();
         Form1 f1 = f as Form1;
         if (f1 != null)
            f1.SetStatus(msg);
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрузка элемента управления
      /// </summary>
      private void PeriodTreeCtrl_Load(object sender, EventArgs e) {
         bindingSrc.Sort = "Year, Quarter asc";
         //LoadData();
      }

      /// <summary>
      /// нажали кнопку "Добвить период"
      /// </summary>
      private void btnAddQuarter_Click(object sender, EventArgs e) {
         AddQuarter();
      }

      /// <summary>
      /// нажали кнопку "Удалить период"
      /// </summary>
      private void btnDelQuarter_Click(object sender, EventArgs e) {
         NpaDataSet.PeriodsRow lastPeriod = GetLastPeriod();
         string msg = string.Format("Удален '{0}'", lastPeriod.PeriodId);
         bool enableDel = IsEanbleDeleteQuerter(lastPeriod);
         if (enableDel) 
            DelQuarter();
         else
            msg = string.Format("Не возможно удалить '{0}'. Имеются данные за данный период.", lastPeriod.PeriodId);
         SetStatus(msg);
      }

      /// <summary>
      /// Переместились по дереву
      /// </summary>
      private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
         timer1.Stop();
         newPeriodRow = null;
         bool editable = false;
         bool browsable = false;
         if (e.Node != null && e.Node.Tag != null) {
            btnEditable.Enabled = true;
            editable = (bool)e.Node[colEditable];
            browsable = (bool)e.Node[colBrowsable];
            newPeriodRow = e.Node.Tag as NpaDataSet.PeriodsRow;
         } 
         btnEditable.Image = (editable) ? NpaManager.Properties.Resources.lock_open : NpaManager.Properties.Resources._lock;
         btnBrowsable.Image = (browsable) ? NpaManager.Properties.Resources.Button_Turn_On : NpaManager.Properties.Resources.Button_Turn_Off;
         timer1.Start();
      }

      /// <summary>
      /// Сработал таймер
      /// </summary>
      private void timer1_Tick(object sender, EventArgs e) {
         timer1.Stop();
         int count = DsHelper.GetModifiedCount();
         if (count > 0) {
            string msg = string.Format("Имеется {0} не сохраненных в БД записей.\rСохранить изменения?", count);
            DialogResult dr = MessageBox.Show(msg, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.DoEvents();
            if (dr == DialogResult.Yes) {
               Form f = this.FindForm();
               f.Cursor = Cursors.WaitCursor;
               DsHelper.UpdateAll();
               f.Cursor = Cursors.Default;
            }
         }
         CurrentPeriod = newPeriodRow;
         DsHelper.SetDefaultPeriod(CurrentPeriod);
         OnPropertyChanged("CurrentPeriod");
      }

      /// <summary>
      /// Добавить период
      /// </summary>
      private void MAddQuarter_Click(object sender, EventArgs e) {
         AddQuarter();
      }

      /// <summary>
      /// Удалить период
      /// </summary>
      private void MDelQuarter_Click(object sender, EventArgs e) {
         NpaDataSet.PeriodsRow lastPeriod = GetLastPeriod();
         string msg = string.Format("Удален '{0}'", lastPeriod.PeriodId);
         bool enableDel = IsEanbleDeleteQuerter(lastPeriod);
         if (enableDel)
            DelQuarter();
         else
            msg = string.Format("Не возможно удалить '{0}'. Имеются данные за данный период.", lastPeriod.PeriodId);
         SetStatus(msg);
      }

      /// <summary>
      /// Разрешить/Запретить правку
      /// </summary>
      private void btnEditable_Click(object sender, EventArgs e) {
         if (CurrentPeriod != null) {
            CurrentPeriod.Editable = !CurrentPeriod.Editable;
            treeList1.FocusedNode[colEditable] = CurrentPeriod.Editable;
            btnEditable.Image = (CurrentPeriod.Editable) ? NpaManager.Properties.Resources.lock_open : NpaManager.Properties.Resources._lock;
            OnPropertyChanged("Editable");
         }
      }

      /// <summary>
      /// Вкл/выкл отображение на сайте
      /// </summary>
      private void btnBrowsable_Click(object sender, EventArgs e) {
         if (CurrentPeriod != null) {
            CurrentPeriod.Browsable = !CurrentPeriod.Browsable;
            treeList1.FocusedNode[colBrowsable] = CurrentPeriod.Browsable;
            btnBrowsable.Image = (CurrentPeriod.Browsable) ? NpaManager.Properties.Resources.Button_Turn_On : NpaManager.Properties.Resources.Button_Turn_Off;
            OnPropertyChanged("Browsable");
         }
      }
      #endregion

      #region NotifyPropertyChanged
      public event PropertyChangedEventHandler PropertyChanged;

      /// <summary>
      /// Оповестить об изменении значения свойства
      /// </summary>
      /// <param name="propertyName">изменившееся свойство</param>
      protected virtual void OnPropertyChanged(string propertyName) {
         PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
         PropertyChangedEventHandler temp = PropertyChanged;
         if (temp != null)
            temp(this, e);
      }
      #endregion

   }
}
