namespace NpaManager {
   partial class Form1 {
      /// <summary>
      /// Требуется переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Обязательный метод для поддержки конструктора - не изменяйте
      /// содержимое данного метода при помощи редактора кода.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolPeriodLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStatusLabelI = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStatusLabelII = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStatusLabelIII = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStatusLabelIV = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.MFile = new System.Windows.Forms.ToolStripMenuItem();
         this.MNew = new System.Windows.Forms.ToolStripMenuItem();
         this.MSelectWord = new System.Windows.Forms.ToolStripMenuItem();
         this.MSave = new System.Windows.Forms.ToolStripMenuItem();
         this.MSaveAsWord = new System.Windows.Forms.ToolStripMenuItem();
         this.MSaveWordVer1 = new System.Windows.Forms.ToolStripMenuItem();
         this.MSaveWordVer2 = new System.Windows.Forms.ToolStripMenuItem();
         this.MRefs = new System.Windows.Forms.ToolStripMenuItem();
         this.MIogvRef = new System.Windows.Forms.ToolStripMenuItem();
         this.MKindNpaRef = new System.Windows.Forms.ToolStripMenuItem();
         this.MOptions = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.MExit = new System.Windows.Forms.ToolStripMenuItem();
         this.MReports = new System.Windows.Forms.ToolStripMenuItem();
         this.MRptIogvRef = new System.Windows.Forms.ToolStripMenuItem();
         this.MRptNpaByIogv = new System.Windows.Forms.ToolStripMenuItem();
         this.MRptNpaAllIogv = new System.Windows.Forms.ToolStripMenuItem();
         this.MTasks = new System.Windows.Forms.ToolStripMenuItem();
         this.MOpenWord = new System.Windows.Forms.ToolStripMenuItem();
         this.MCloseWord = new System.Windows.Forms.ToolStripMenuItem();
         this.MDoWord = new System.Windows.Forms.ToolStripMenuItem();
         this.MRecalcDates = new System.Windows.Forms.ToolStripMenuItem();
         this.MRecalcDateCurrent = new System.Windows.Forms.ToolStripMenuItem();
         this.MRecalcDatesAll = new System.Windows.Forms.ToolStripMenuItem();
         this.MClearSelected = new System.Windows.Forms.ToolStripMenuItem();
         this.МView = new System.Windows.Forms.ToolStripMenuItem();
         this.MTogglePeriod = new System.Windows.Forms.ToolStripMenuItem();
         this.MRowAutoHeight = new System.Windows.Forms.ToolStripMenuItem();
         this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolBtnOpenWord = new System.Windows.Forms.ToolStripButton();
         this.toolBtnCloseWord = new System.Windows.Forms.ToolStripButton();
         this.toolBtnDoWord = new System.Windows.Forms.ToolStripButton();
         this.toolBtnTogglePeriod = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.SplitBtnRecalcDates = new System.Windows.Forms.ToolStripSplitButton();
         this.ToolStripMRecalcDateCurrent = new System.Windows.Forms.ToolStripMenuItem();
         this.ToolStripMRecalcDatesAll = new System.Windows.Forms.ToolStripMenuItem();
         this.ToolStripMClearSelected = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripComboIogv = new System.Windows.Forms.ToolStripComboBox();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.periodTreeCtrl1 = new NpaManager.PeriodTreeCtrl();
         this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
         this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
         this.npaIGridCtrl1 = new NpaManager.NpaIGridCtrl();
         this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
         this.npaIIGridCtrl1 = new NpaManager.NpaIIGridCtrl();
         this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
         this.npaIIIGridCtrl1 = new NpaManager.NpaIIIGridCtrl();
         this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
         this.npaIVGridCtrl1 = new NpaManager.NpaIVGridCtrl();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
         this.bindingNavigator1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.xtraTabPage1.SuspendLayout();
         this.xtraTabPage2.SuspendLayout();
         this.xtraTabPage3.SuspendLayout();
         this.xtraTabPage4.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusLabel,
            this.toolStripStatusLabel1,
            this.toolPeriodLabel,
            this.toolStripStatusLabel2,
            this.toolStatusLabelI,
            this.toolStripStatusLabel3,
            this.toolStatusLabelII,
            this.toolStripStatusLabel5,
            this.toolStatusLabelIII,
            this.toolStripStatusLabel7,
            this.toolStatusLabelIV});
         this.statusStrip1.Location = new System.Drawing.Point(0, 712);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(1295, 22);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStatusLabel
         // 
         this.toolStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
         this.toolStatusLabel.Name = "toolStatusLabel";
         this.toolStatusLabel.Size = new System.Drawing.Size(973, 20);
         this.toolStatusLabel.Spring = true;
         this.toolStatusLabel.Text = "...";
         this.toolStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
         this.toolStripStatusLabel1.Text = "Период:";
         // 
         // toolPeriodLabel
         // 
         this.toolPeriodLabel.AutoSize = false;
         this.toolPeriodLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolPeriodLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
         this.toolPeriodLabel.Name = "toolPeriodLabel";
         this.toolPeriodLabel.Size = new System.Drawing.Size(100, 20);
         this.toolPeriodLabel.Text = "Не задан";
         // 
         // toolStripStatusLabel2
         // 
         this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
         this.toolStripStatusLabel2.Size = new System.Drawing.Size(15, 17);
         this.toolStripStatusLabel2.Text = "I:";
         // 
         // toolStatusLabelI
         // 
         this.toolStatusLabelI.BackColor = System.Drawing.Color.Red;
         this.toolStatusLabelI.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolStatusLabelI.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
         this.toolStatusLabelI.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
         this.toolStatusLabelI.Name = "toolStatusLabelI";
         this.toolStatusLabelI.Size = new System.Drawing.Size(20, 19);
         this.toolStatusLabelI.Text = "   ";
         // 
         // toolStripStatusLabel3
         // 
         this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
         this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 17);
         this.toolStripStatusLabel3.Text = "II:";
         // 
         // toolStatusLabelII
         // 
         this.toolStatusLabelII.BackColor = System.Drawing.Color.Red;
         this.toolStatusLabelII.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolStatusLabelII.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
         this.toolStatusLabelII.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
         this.toolStatusLabelII.Name = "toolStatusLabelII";
         this.toolStatusLabelII.Size = new System.Drawing.Size(20, 19);
         this.toolStatusLabelII.Text = "   ";
         // 
         // toolStripStatusLabel5
         // 
         this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
         this.toolStripStatusLabel5.Size = new System.Drawing.Size(23, 17);
         this.toolStripStatusLabel5.Text = "III:";
         // 
         // toolStatusLabelIII
         // 
         this.toolStatusLabelIII.BackColor = System.Drawing.Color.Red;
         this.toolStatusLabelIII.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolStatusLabelIII.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
         this.toolStatusLabelIII.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
         this.toolStatusLabelIII.Name = "toolStatusLabelIII";
         this.toolStatusLabelIII.Size = new System.Drawing.Size(20, 19);
         this.toolStatusLabelIII.Text = "   ";
         // 
         // toolStripStatusLabel7
         // 
         this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
         this.toolStripStatusLabel7.Size = new System.Drawing.Size(21, 17);
         this.toolStripStatusLabel7.Text = "IV:";
         // 
         // toolStatusLabelIV
         // 
         this.toolStatusLabelIV.BackColor = System.Drawing.Color.Red;
         this.toolStatusLabelIV.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.toolStatusLabelIV.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
         this.toolStatusLabelIV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
         this.toolStatusLabelIV.Name = "toolStatusLabelIV";
         this.toolStatusLabelIV.Size = new System.Drawing.Size(20, 19);
         this.toolStatusLabelIV.Text = "   ";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFile,
            this.MReports,
            this.MTasks,
            this.МView});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1295, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // MFile
         // 
         this.MFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNew,
            this.MSelectWord,
            this.MSave,
            this.MSaveAsWord,
            this.MRefs,
            this.MOptions,
            this.toolStripMenuItem1,
            this.MExit});
         this.MFile.Name = "MFile";
         this.MFile.Size = new System.Drawing.Size(45, 20);
         this.MFile.Text = "Файл";
         // 
         // MNew
         // 
         this.MNew.Image = global::NpaManager.Properties.Resources.NewDocumentHS;
         this.MNew.Name = "MNew";
         this.MNew.Size = new System.Drawing.Size(179, 22);
         this.MNew.Text = "Новый";
         this.MNew.Click += new System.EventHandler(this.MNew_Click);
         // 
         // MSelectWord
         // 
         this.MSelectWord.Image = global::NpaManager.Properties.Resources.DocumentHS;
         this.MSelectWord.Name = "MSelectWord";
         this.MSelectWord.Size = new System.Drawing.Size(179, 22);
         this.MSelectWord.Text = "Выбрать";
         this.MSelectWord.Click += new System.EventHandler(this.MSelectWord_Click);
         // 
         // MSave
         // 
         this.MSave.Image = global::NpaManager.Properties.Resources.saveHS;
         this.MSave.Name = "MSave";
         this.MSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.MSave.Size = new System.Drawing.Size(179, 22);
         this.MSave.Text = "Сохранить";
         this.MSave.Click += new System.EventHandler(this.MSave_Click);
         // 
         // MSaveAsWord
         // 
         this.MSaveAsWord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSaveWordVer1,
            this.MSaveWordVer2});
         this.MSaveAsWord.Name = "MSaveAsWord";
         this.MSaveAsWord.Size = new System.Drawing.Size(179, 22);
         this.MSaveAsWord.Text = "Сохранить как Word";
         // 
         // MSaveWordVer1
         // 
         this.MSaveWordVer1.Enabled = false;
         this.MSaveWordVer1.Name = "MSaveWordVer1";
         this.MSaveWordVer1.Size = new System.Drawing.Size(156, 22);
         this.MSaveWordVer1.Text = "шаблон вер. 1.0";
         this.MSaveWordVer1.Click += new System.EventHandler(this.MSaveWordVer1_Click);
         // 
         // MSaveWordVer2
         // 
         this.MSaveWordVer2.Name = "MSaveWordVer2";
         this.MSaveWordVer2.Size = new System.Drawing.Size(156, 22);
         this.MSaveWordVer2.Text = "шаблон вер. 2.0";
         this.MSaveWordVer2.Click += new System.EventHandler(this.MSaveWordVer2_Click);
         // 
         // MRefs
         // 
         this.MRefs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIogvRef,
            this.MKindNpaRef});
         this.MRefs.Name = "MRefs";
         this.MRefs.Size = new System.Drawing.Size(179, 22);
         this.MRefs.Text = "Справочники";
         // 
         // MIogvRef
         // 
         this.MIogvRef.Name = "MIogvRef";
         this.MIogvRef.Size = new System.Drawing.Size(154, 22);
         this.MIogvRef.Text = "Подразделения";
         this.MIogvRef.Click += new System.EventHandler(this.MIogvRef_Click);
         // 
         // MKindNpaRef
         // 
         this.MKindNpaRef.Name = "MKindNpaRef";
         this.MKindNpaRef.Size = new System.Drawing.Size(154, 22);
         this.MKindNpaRef.Text = "Виды НПА";
         this.MKindNpaRef.Click += new System.EventHandler(this.MKindNpaRef_Click);
         // 
         // MOptions
         // 
         this.MOptions.Image = global::NpaManager.Properties.Resources.OptionsHS;
         this.MOptions.Name = "MOptions";
         this.MOptions.Size = new System.Drawing.Size(179, 22);
         this.MOptions.Text = "Настройки";
         this.MOptions.Click += new System.EventHandler(this.MOptions_Click);
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
         // 
         // MExit
         // 
         this.MExit.Name = "MExit";
         this.MExit.Size = new System.Drawing.Size(179, 22);
         this.MExit.Text = "Выход";
         this.MExit.Click += new System.EventHandler(this.MExit_Click);
         // 
         // MReports
         // 
         this.MReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MRptIogvRef,
            this.MRptNpaByIogv,
            this.MRptNpaAllIogv});
         this.MReports.Name = "MReports";
         this.MReports.Size = new System.Drawing.Size(59, 20);
         this.MReports.Text = "Отчеты";
         // 
         // MRptIogvRef
         // 
         this.MRptIogvRef.Name = "MRptIogvRef";
         this.MRptIogvRef.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
         this.MRptIogvRef.Size = new System.Drawing.Size(283, 22);
         this.MRptIogvRef.Text = "Справочник подразделений";
         this.MRptIogvRef.Click += new System.EventHandler(this.MRptIogvRef_Click);
         // 
         // MRptNpaByIogv
         // 
         this.MRptNpaByIogv.Name = "MRptNpaByIogv";
         this.MRptNpaByIogv.Size = new System.Drawing.Size(283, 22);
         this.MRptNpaByIogv.Text = "График НПА по подразделению";
         this.MRptNpaByIogv.Click += new System.EventHandler(this.MRptNpaByIogv_Click);
         // 
         // MRptNpaAllIogv
         // 
         this.MRptNpaAllIogv.Name = "MRptNpaAllIogv";
         this.MRptNpaAllIogv.Size = new System.Drawing.Size(283, 22);
         this.MRptNpaAllIogv.Text = "График НПА по всем подразделениям";
         this.MRptNpaAllIogv.Click += new System.EventHandler(this.MRptNpaAllIogv_Click);
         // 
         // MTasks
         // 
         this.MTasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MOpenWord,
            this.MCloseWord,
            this.MDoWord,
            this.MRecalcDates});
         this.MTasks.Name = "MTasks";
         this.MTasks.Size = new System.Drawing.Size(56, 20);
         this.MTasks.Text = "Задачи";
         // 
         // MOpenWord
         // 
         this.MOpenWord.Image = global::NpaManager.Properties.Resources.FillDownHS;
         this.MOpenWord.Name = "MOpenWord";
         this.MOpenWord.Size = new System.Drawing.Size(211, 22);
         this.MOpenWord.Text = "Загрузить данные из Word";
         this.MOpenWord.Click += new System.EventHandler(this.MOpenWord_Click);
         // 
         // MCloseWord
         // 
         this.MCloseWord.Enabled = false;
         this.MCloseWord.Image = global::NpaManager.Properties.Resources.StopHS;
         this.MCloseWord.Name = "MCloseWord";
         this.MCloseWord.Size = new System.Drawing.Size(211, 22);
         this.MCloseWord.Text = "Закрыть Word";
         this.MCloseWord.Click += new System.EventHandler(this.MCloseWord_Click);
         // 
         // MDoWord
         // 
         this.MDoWord.Enabled = false;
         this.MDoWord.Image = global::NpaManager.Properties.Resources.PlayHS;
         this.MDoWord.Name = "MDoWord";
         this.MDoWord.Size = new System.Drawing.Size(211, 22);
         this.MDoWord.Text = "Выполнить обработку";
         this.MDoWord.Click += new System.EventHandler(this.MDoWord_Click);
         // 
         // MRecalcDates
         // 
         this.MRecalcDates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MRecalcDateCurrent,
            this.MRecalcDatesAll,
            this.MClearSelected});
         this.MRecalcDates.Image = global::NpaManager.Properties.Resources.calendar_day;
         this.MRecalcDates.Name = "MRecalcDates";
         this.MRecalcDates.Size = new System.Drawing.Size(211, 22);
         this.MRecalcDates.Text = "Расчитать срок";
         // 
         // MRecalcDateCurrent
         // 
         this.MRecalcDateCurrent.Image = global::NpaManager.Properties.Resources.calendar_select_week;
         this.MRecalcDateCurrent.Name = "MRecalcDateCurrent";
         this.MRecalcDateCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
         this.MRecalcDateCurrent.Size = new System.Drawing.Size(245, 22);
         this.MRecalcDateCurrent.Text = "Для текущей строки";
         this.MRecalcDateCurrent.Click += new System.EventHandler(this.MRecalcDateCurrent_Click);
         // 
         // MRecalcDatesAll
         // 
         this.MRecalcDatesAll.Image = global::NpaManager.Properties.Resources.calendar_select_month;
         this.MRecalcDatesAll.Name = "MRecalcDatesAll";
         this.MRecalcDatesAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
         this.MRecalcDatesAll.Size = new System.Drawing.Size(245, 22);
         this.MRecalcDatesAll.Text = "Для всего раздела";
         this.MRecalcDatesAll.Click += new System.EventHandler(this.MRecalcDatesAll_Click);
         // 
         // MClearSelected
         // 
         this.MClearSelected.Image = global::NpaManager.Properties.Resources.calendar__minus;
         this.MClearSelected.Name = "MClearSelected";
         this.MClearSelected.Size = new System.Drawing.Size(245, 22);
         this.MClearSelected.Text = "Очистить для выделенных строк";
         this.MClearSelected.Click += new System.EventHandler(this.MClearSelected_Click);
         // 
         // МView
         // 
         this.МView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTogglePeriod,
            this.MRowAutoHeight});
         this.МView.Name = "МView";
         this.МView.Size = new System.Drawing.Size(38, 20);
         this.МView.Text = "Вид";
         // 
         // MTogglePeriod
         // 
         this.MTogglePeriod.Image = global::NpaManager.Properties.Resources.FillLeftHS;
         this.MTogglePeriod.Name = "MTogglePeriod";
         this.MTogglePeriod.Size = new System.Drawing.Size(304, 22);
         this.MTogglePeriod.Text = "Скрыть/Отобразить парель выбора периода";
         this.MTogglePeriod.Click += new System.EventHandler(this.MTogglePeriod_Click);
         // 
         // MRowAutoHeight
         // 
         this.MRowAutoHeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.MRowAutoHeight.Name = "MRowAutoHeight";
         this.MRowAutoHeight.Size = new System.Drawing.Size(304, 22);
         this.MRowAutoHeight.Text = "Автоподбор высоты строк";
         this.MRowAutoHeight.Click += new System.EventHandler(this.MRowAutoHeight_Click);
         // 
         // bindingNavigator1
         // 
         this.bindingNavigator1.AddNewItem = null;
         this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
         this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
         this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolBtnOpenWord,
            this.toolBtnCloseWord,
            this.toolBtnDoWord,
            this.toolBtnTogglePeriod,
            this.toolStripSeparator2,
            this.SplitBtnRecalcDates,
            this.toolStripComboIogv});
         this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
         this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.bindingNavigator1.Name = "bindingNavigator1";
         this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
         this.bindingNavigator1.Size = new System.Drawing.Size(1295, 25);
         this.bindingNavigator1.TabIndex = 2;
         this.bindingNavigator1.Text = "bindingNavigator1";
         // 
         // bindingNavigatorCountItem
         // 
         this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
         this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
         this.bindingNavigatorCountItem.Text = "of {0}";
         this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
         // 
         // bindingNavigatorDeleteItem
         // 
         this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Удалить";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
         this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
         this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
         // 
         // bindingNavigatorSeparator
         // 
         this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
         this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorPositionItem
         // 
         this.bindingNavigatorPositionItem.AccessibleName = "Положение";
         this.bindingNavigatorPositionItem.AutoSize = false;
         this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
         this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
         this.bindingNavigatorPositionItem.Text = "0";
         this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
         // 
         // bindingNavigatorSeparator1
         // 
         this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
         this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorMoveNextItem
         // 
         this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
         this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
         this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
         // 
         // bindingNavigatorSeparator2
         // 
         this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
         this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
         this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
         this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorAddNewItem.Text = "Добавить";
         this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // toolBtnOpenWord
         // 
         this.toolBtnOpenWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolBtnOpenWord.Image = global::NpaManager.Properties.Resources.FillDownHS;
         this.toolBtnOpenWord.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolBtnOpenWord.Name = "toolBtnOpenWord";
         this.toolBtnOpenWord.Size = new System.Drawing.Size(23, 22);
         this.toolBtnOpenWord.Text = "Загрузить данные из Word";
         this.toolBtnOpenWord.Click += new System.EventHandler(this.toolBtnOpenWord_Click);
         // 
         // toolBtnCloseWord
         // 
         this.toolBtnCloseWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolBtnCloseWord.Enabled = false;
         this.toolBtnCloseWord.Image = global::NpaManager.Properties.Resources.StopHS;
         this.toolBtnCloseWord.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolBtnCloseWord.Name = "toolBtnCloseWord";
         this.toolBtnCloseWord.Size = new System.Drawing.Size(23, 22);
         this.toolBtnCloseWord.Text = "Закрыть Word";
         this.toolBtnCloseWord.Click += new System.EventHandler(this.toolBtnCloseWord_Click);
         // 
         // toolBtnDoWord
         // 
         this.toolBtnDoWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolBtnDoWord.Enabled = false;
         this.toolBtnDoWord.Image = global::NpaManager.Properties.Resources.PlayHS;
         this.toolBtnDoWord.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolBtnDoWord.Name = "toolBtnDoWord";
         this.toolBtnDoWord.Size = new System.Drawing.Size(23, 22);
         this.toolBtnDoWord.Text = "Выполнить обработку";
         this.toolBtnDoWord.Click += new System.EventHandler(this.toolBtnDoWord_Click);
         // 
         // toolBtnTogglePeriod
         // 
         this.toolBtnTogglePeriod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolBtnTogglePeriod.Image = global::NpaManager.Properties.Resources.FillLeftHS;
         this.toolBtnTogglePeriod.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolBtnTogglePeriod.Name = "toolBtnTogglePeriod";
         this.toolBtnTogglePeriod.Size = new System.Drawing.Size(23, 22);
         this.toolBtnTogglePeriod.Text = "Скрыть/отобразить панель выбора периода";
         this.toolBtnTogglePeriod.Click += new System.EventHandler(this.toolBtnTogglePeriod_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // SplitBtnRecalcDates
         // 
         this.SplitBtnRecalcDates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.SplitBtnRecalcDates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMRecalcDateCurrent,
            this.ToolStripMRecalcDatesAll,
            this.ToolStripMClearSelected});
         this.SplitBtnRecalcDates.Image = global::NpaManager.Properties.Resources.calendar_day;
         this.SplitBtnRecalcDates.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.SplitBtnRecalcDates.Name = "SplitBtnRecalcDates";
         this.SplitBtnRecalcDates.Size = new System.Drawing.Size(32, 22);
         this.SplitBtnRecalcDates.Text = "Расчитать срок";
         // 
         // ToolStripMRecalcDateCurrent
         // 
         this.ToolStripMRecalcDateCurrent.Image = global::NpaManager.Properties.Resources.calendar_select_week;
         this.ToolStripMRecalcDateCurrent.Name = "ToolStripMRecalcDateCurrent";
         this.ToolStripMRecalcDateCurrent.Size = new System.Drawing.Size(245, 22);
         this.ToolStripMRecalcDateCurrent.Text = "Для текущей строки";
         this.ToolStripMRecalcDateCurrent.Click += new System.EventHandler(this.ToolStripMRecalcDateCurrent_Click);
         // 
         // ToolStripMRecalcDatesAll
         // 
         this.ToolStripMRecalcDatesAll.Image = global::NpaManager.Properties.Resources.calendar_select_month;
         this.ToolStripMRecalcDatesAll.Name = "ToolStripMRecalcDatesAll";
         this.ToolStripMRecalcDatesAll.Size = new System.Drawing.Size(245, 22);
         this.ToolStripMRecalcDatesAll.Text = "Для всего раздела";
         this.ToolStripMRecalcDatesAll.Click += new System.EventHandler(this.ToolStripMRecalcDatesAll_Click);
         // 
         // ToolStripMClearSelected
         // 
         this.ToolStripMClearSelected.Image = global::NpaManager.Properties.Resources.calendar__minus;
         this.ToolStripMClearSelected.Name = "ToolStripMClearSelected";
         this.ToolStripMClearSelected.Size = new System.Drawing.Size(245, 22);
         this.ToolStripMClearSelected.Text = "Очистить для выделенных строк";
         this.ToolStripMClearSelected.Click += new System.EventHandler(this.ToolStripMClearSelected_Click);
         // 
         // toolStripComboIogv
         // 
         this.toolStripComboIogv.Margin = new System.Windows.Forms.Padding(6, 1, 1, 1);
         this.toolStripComboIogv.Name = "toolStripComboIogv";
         this.toolStripComboIogv.Size = new System.Drawing.Size(650, 23);
         this.toolStripComboIogv.SelectedIndexChanged += new System.EventHandler(this.toolStripComboIogv_SelectedIndexChanged);
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 49);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.periodTreeCtrl1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
         this.splitContainer1.Size = new System.Drawing.Size(1295, 663);
         this.splitContainer1.SplitterDistance = 217;
         this.splitContainer1.SplitterWidth = 6;
         this.splitContainer1.TabIndex = 5;
         // 
         // periodTreeCtrl1
         // 
         this.periodTreeCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.periodTreeCtrl1.Location = new System.Drawing.Point(0, 0);
         this.periodTreeCtrl1.Name = "periodTreeCtrl1";
         this.periodTreeCtrl1.Size = new System.Drawing.Size(217, 663);
         this.periodTreeCtrl1.TabIndex = 0;
         this.periodTreeCtrl1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.periodTreeCtrl1_PropertyChanged);
         // 
         // tabControl1
         // 
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedTabPage = this.xtraTabPage1;
         this.tabControl1.Size = new System.Drawing.Size(1072, 663);
         this.tabControl1.TabIndex = 5;
         this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
         this.tabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
         // 
         // xtraTabPage1
         // 
         this.xtraTabPage1.Controls.Add(this.npaIGridCtrl1);
         this.xtraTabPage1.Name = "xtraTabPage1";
         this.xtraTabPage1.Size = new System.Drawing.Size(1066, 635);
         this.xtraTabPage1.Text = "I. Проекты постановлений правительства";
         // 
         // npaIGridCtrl1
         // 
         this.npaIGridCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.npaIGridCtrl1.Editable = false;
         this.npaIGridCtrl1.Location = new System.Drawing.Point(0, 0);
         this.npaIGridCtrl1.Name = "npaIGridCtrl1";
         this.npaIGridCtrl1.RowAutoHeight = false;
         this.npaIGridCtrl1.Size = new System.Drawing.Size(1066, 635);
         this.npaIGridCtrl1.State = NpaManager.NpaGridState.Red;
         this.npaIGridCtrl1.TabIndex = 1;
         this.npaIGridCtrl1.TableName = null;
         this.npaIGridCtrl1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.npaGridCtrl1_PropertyChanged);
         // 
         // xtraTabPage2
         // 
         this.xtraTabPage2.Controls.Add(this.npaIIGridCtrl1);
         this.xtraTabPage2.Name = "xtraTabPage2";
         this.xtraTabPage2.Size = new System.Drawing.Size(921, 495);
         this.xtraTabPage2.Text = "II. Проекты законов, постановлений зак.собрания";
         // 
         // npaIIGridCtrl1
         // 
         this.npaIIGridCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.npaIIGridCtrl1.Editable = false;
         this.npaIIGridCtrl1.Location = new System.Drawing.Point(0, 0);
         this.npaIIGridCtrl1.Name = "npaIIGridCtrl1";
         this.npaIIGridCtrl1.RowAutoHeight = false;
         this.npaIIGridCtrl1.Size = new System.Drawing.Size(921, 495);
         this.npaIIGridCtrl1.State = NpaManager.NpaGridState.Red;
         this.npaIIGridCtrl1.TabIndex = 1;
         this.npaIIGridCtrl1.TableName = null;
         this.npaIIGridCtrl1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.npaIIGridCtrl1_PropertyChanged);
         // 
         // xtraTabPage3
         // 
         this.xtraTabPage3.Controls.Add(this.npaIIIGridCtrl1);
         this.xtraTabPage3.Name = "xtraTabPage3";
         this.xtraTabPage3.Size = new System.Drawing.Size(921, 495);
         this.xtraTabPage3.Text = "III. Проекты НПА губернатора, распоряжений правительства";
         // 
         // npaIIIGridCtrl1
         // 
         this.npaIIIGridCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.npaIIIGridCtrl1.Editable = false;
         this.npaIIIGridCtrl1.Location = new System.Drawing.Point(0, 0);
         this.npaIIIGridCtrl1.Name = "npaIIIGridCtrl1";
         this.npaIIIGridCtrl1.RowAutoHeight = false;
         this.npaIIIGridCtrl1.Size = new System.Drawing.Size(921, 495);
         this.npaIIIGridCtrl1.State = NpaManager.NpaGridState.Red;
         this.npaIIIGridCtrl1.TabIndex = 1;
         this.npaIIIGridCtrl1.TableName = null;
         this.npaIIIGridCtrl1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.npaIIIGridCtrl1_PropertyChanged);
         // 
         // xtraTabPage4
         // 
         this.xtraTabPage4.Controls.Add(this.npaIVGridCtrl1);
         this.xtraTabPage4.Name = "xtraTabPage4";
         this.xtraTabPage4.Size = new System.Drawing.Size(921, 495);
         this.xtraTabPage4.Text = "IV. Проекты приказов ОИВ";
         // 
         // npaIVGridCtrl1
         // 
         this.npaIVGridCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.npaIVGridCtrl1.Editable = false;
         this.npaIVGridCtrl1.Location = new System.Drawing.Point(0, 0);
         this.npaIVGridCtrl1.Name = "npaIVGridCtrl1";
         this.npaIVGridCtrl1.RowAutoHeight = false;
         this.npaIVGridCtrl1.Size = new System.Drawing.Size(921, 495);
         this.npaIVGridCtrl1.State = NpaManager.NpaGridState.Red;
         this.npaIVGridCtrl1.TabIndex = 1;
         this.npaIVGridCtrl1.TableName = null;
         this.npaIVGridCtrl1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.npaIVGridCtrl1_PropertyChanged);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.ClientSize = new System.Drawing.Size(1295, 734);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.bindingNavigator1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.Text = "Просмотр планов НПА";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
         this.bindingNavigator1.ResumeLayout(false);
         this.bindingNavigator1.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.xtraTabPage1.ResumeLayout(false);
         this.xtraTabPage2.ResumeLayout(false);
         this.xtraTabPage3.ResumeLayout(false);
         this.xtraTabPage4.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem MFile;
      private System.Windows.Forms.ToolStripMenuItem MNew;
      private System.Windows.Forms.ToolStripMenuItem MSelectWord;
      private System.Windows.Forms.ToolStripMenuItem MSave;
      private System.Windows.Forms.ToolStripMenuItem MSaveAsWord;
      private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem MExit;
      private System.Windows.Forms.ToolStripStatusLabel toolStatusLabel;
      private System.Windows.Forms.BindingNavigator bindingNavigator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
      private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
      private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
      private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
      private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton toolBtnOpenWord;
      private System.Windows.Forms.ToolStripButton toolBtnCloseWord;
      private System.Windows.Forms.ToolStripButton toolBtnDoWord;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private PeriodTreeCtrl periodTreeCtrl1;
      private System.Windows.Forms.ToolStripMenuItem MOptions;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripButton toolBtnTogglePeriod;
      private System.Windows.Forms.ToolStripMenuItem MTasks;
      private System.Windows.Forms.ToolStripMenuItem MOpenWord;
      private System.Windows.Forms.ToolStripMenuItem MCloseWord;
      private System.Windows.Forms.ToolStripMenuItem MDoWord;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripStatusLabel toolStatusLabelI;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
      private System.Windows.Forms.ToolStripStatusLabel toolStatusLabelII;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
      private System.Windows.Forms.ToolStripStatusLabel toolStatusLabelIII;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
      private System.Windows.Forms.ToolStripStatusLabel toolStatusLabelIV;
      private DevExpress.XtraTab.XtraTabControl tabControl1;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
      private NpaIGridCtrl npaIGridCtrl1;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
      private NpaIIIGridCtrl npaIIIGridCtrl1;
      private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
      private NpaIVGridCtrl npaIVGridCtrl1;
      private System.Windows.Forms.ToolStripMenuItem MRefs;
      private System.Windows.Forms.ToolStripMenuItem MIogvRef;
      private System.Windows.Forms.ToolStripMenuItem MKindNpaRef;
      private System.Windows.Forms.ToolStripMenuItem МView;
      private System.Windows.Forms.ToolStripMenuItem MRowAutoHeight;
      private System.Windows.Forms.ToolStripMenuItem MTogglePeriod;
      private System.Windows.Forms.ToolStripComboBox toolStripComboIogv;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripStatusLabel toolPeriodLabel;
      private System.Windows.Forms.ToolStripMenuItem MReports;
      private System.Windows.Forms.ToolStripMenuItem MRptIogvRef;
      private NpaIIGridCtrl npaIIGridCtrl1;
      private System.Windows.Forms.ToolStripMenuItem MRptNpaByIogv;
      private System.Windows.Forms.ToolStripMenuItem MRecalcDates;
      private System.Windows.Forms.ToolStripMenuItem MRecalcDateCurrent;
      private System.Windows.Forms.ToolStripMenuItem MRecalcDatesAll;
      private System.Windows.Forms.ToolStripSplitButton SplitBtnRecalcDates;
      private System.Windows.Forms.ToolStripMenuItem ToolStripMRecalcDateCurrent;
      private System.Windows.Forms.ToolStripMenuItem ToolStripMRecalcDatesAll;
      private System.Windows.Forms.ToolStripMenuItem ToolStripMClearSelected;
      private System.Windows.Forms.ToolStripMenuItem MClearSelected;
      private System.Windows.Forms.ToolStripMenuItem MRptNpaAllIogv;
      private System.Windows.Forms.ToolStripMenuItem MSaveWordVer1;
      private System.Windows.Forms.ToolStripMenuItem MSaveWordVer2;
      private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
   }
}

