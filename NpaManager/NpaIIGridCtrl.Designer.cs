namespace NpaManager {
   partial class NpaIIGridCtrl {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
         this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDateD1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPlanDateLaw1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPlanDateOther1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPlanDateAssembly1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPlanDateGov1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaNote = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIndex = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaState = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaKind = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoNpaName = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.colIogv = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoIogv = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.colPlanDateLaw = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditLaw = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.colPlanDateOther = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditOther = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.colPlanDateAssembly = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditAssembly = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.colPlanDateGov = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditGov = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.gridColNpaNote = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoNpaNote = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.colNpaStatus = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riLookUpNpaStatusRef = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.npaStatusBindingSrc = new System.Windows.Forms.BindingSource(this.components);
         this.riLookupIogv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.iogvRefBindingSource = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaName)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoIogv)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditOther)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditOther.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditAssembly)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditAssembly.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditGov)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditGov.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookUpNpaStatusRef)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStatusBindingSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookupIogv)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.iogvRefBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // bindingSrc
         // 
         this.bindingSrc.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSrc_ListChanged);
         // 
         // gridView2
         // 
         this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colDateD1,
            this.colPlanDateLaw1,
            this.colPlanDateOther1,
            this.colPlanDateAssembly1,
            this.colPlanDateGov1,
            this.colNpaNote});
         this.gridView2.GridControl = this.gridControl1;
         this.gridView2.Name = "gridView2";
         this.gridView2.OptionsBehavior.Editable = false;
         this.gridView2.OptionsCustomization.AllowGroup = false;
         this.gridView2.OptionsView.ColumnAutoWidth = false;
         this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
         this.gridView2.OptionsView.ShowGroupPanel = false;
         // 
         // colId1
         // 
         this.colId1.AppearanceHeader.Options.UseTextOptions = true;
         this.colId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colId1.Caption = "Id";
         this.colId1.FieldName = "Id";
         this.colId1.Name = "colId1";
         this.colId1.Width = 54;
         // 
         // colDateD1
         // 
         this.colDateD1.AppearanceHeader.Options.UseTextOptions = true;
         this.colDateD1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colDateD1.Caption = "Дата изменения";
         this.colDateD1.FieldName = "DateD";
         this.colDateD1.Name = "colDateD1";
         this.colDateD1.Visible = true;
         this.colDateD1.VisibleIndex = 0;
         this.colDateD1.Width = 100;
         // 
         // colPlanDateLaw1
         // 
         this.colPlanDateLaw1.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateLaw1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateLaw1.Caption = "Срок предеачи на юр. экспертизу";
         this.colPlanDateLaw1.FieldName = "PlanDateLaw";
         this.colPlanDateLaw1.Name = "colPlanDateLaw1";
         this.colPlanDateLaw1.Visible = true;
         this.colPlanDateLaw1.VisibleIndex = 1;
         this.colPlanDateLaw1.Width = 100;
         // 
         // colPlanDateOther1
         // 
         this.colPlanDateOther1.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateOther1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateOther1.Caption = "Срок согласования с заинтересованными подразделениями";
         this.colPlanDateOther1.FieldName = "PlanDateOther";
         this.colPlanDateOther1.Name = "colPlanDateOther1";
         this.colPlanDateOther1.Visible = true;
         this.colPlanDateOther1.VisibleIndex = 2;
         this.colPlanDateOther1.Width = 100;
         // 
         // colPlanDateAssembly1
         // 
         this.colPlanDateAssembly1.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateAssembly1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateAssembly1.Caption = "Срок представления на рассмотрение комитетов Зак. Собрания";
         this.colPlanDateAssembly1.FieldName = "PlanDateAssembly";
         this.colPlanDateAssembly1.Name = "colPlanDateAssembly1";
         this.colPlanDateAssembly1.Visible = true;
         this.colPlanDateAssembly1.VisibleIndex = 3;
         this.colPlanDateAssembly1.Width = 123;
         // 
         // colPlanDateGov1
         // 
         this.colPlanDateGov1.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateGov1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateGov1.Caption = "Дата внесения на рассмотрение Зак. Собрания";
         this.colPlanDateGov1.FieldName = "PlanDateGov";
         this.colPlanDateGov1.Name = "colPlanDateGov1";
         this.colPlanDateGov1.Visible = true;
         this.colPlanDateGov1.VisibleIndex = 4;
         this.colPlanDateGov1.Width = 100;
         // 
         // colNpaNote
         // 
         this.colNpaNote.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaNote.Caption = "Примечание";
         this.colNpaNote.FieldName = "NpaNote";
         this.colNpaNote.Name = "colNpaNote";
         this.colNpaNote.Visible = true;
         this.colNpaNote.VisibleIndex = 5;
         this.colNpaNote.Width = 350;
         // 
         // gridControl1
         // 
         this.gridControl1.DataSource = this.bindingSrc;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         gridLevelNode1.LevelTemplate = this.gridView2;
         gridLevelNode1.RelationName = "DetailView";
         this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
         this.gridControl1.Location = new System.Drawing.Point(0, 0);
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riMemoIogv,
            this.riMemoNpaName,
            this.riMemoNpaNote,
            this.riDateEditGov,
            this.riDateEditAssembly,
            this.riDateEditOther,
            this.riDateEditLaw,
            this.riLookupIogv,
            this.riLookUpNpaStatusRef});
         this.gridControl1.Size = new System.Drawing.Size(777, 466);
         this.gridControl1.TabIndex = 1;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIndex,
            this.colNpaState,
            this.colNpaKind,
            this.colNpaName,
            this.colIogv,
            this.colPlanDateLaw,
            this.colPlanDateOther,
            this.colPlanDateAssembly,
            this.colPlanDateGov,
            this.gridColNpaNote,
            this.colNpaStatus});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NpaII.Id", null, "(Всего:{0})")});
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsCustomization.AllowRowSizing = true;
         this.gridView1.OptionsSelection.MultiSelect = true;
         this.gridView1.OptionsView.ColumnAutoWidth = false;
         this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
         this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
         this.gridView1.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
         this.gridView1.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.gridView1_MasterRowGetLevelDefaultView);
         this.gridView1.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
         this.gridView1.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationDisplayCaption);
         this.gridView1.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
         this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
         this.gridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridView1_FocusedColumnChanged);
         this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
         this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
         this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
         this.gridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyUp);
         // 
         // colId
         // 
         this.colId.AppearanceHeader.Options.UseTextOptions = true;
         this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colId.Caption = "ID";
         this.colId.FieldName = "Id";
         this.colId.Name = "colId";
         this.colId.Width = 35;
         // 
         // colIndex
         // 
         this.colIndex.AppearanceHeader.Options.UseTextOptions = true;
         this.colIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colIndex.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colIndex.Caption = "№ пп.";
         this.colIndex.DisplayFormat.FormatString = "#.#";
         this.colIndex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
         this.colIndex.FieldName = "Index";
         this.colIndex.GroupFormat.FormatString = "#.#";
         this.colIndex.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
         this.colIndex.Name = "colIndex";
         this.colIndex.Visible = true;
         this.colIndex.VisibleIndex = 0;
         this.colIndex.Width = 40;
         // 
         // colNpaState
         // 
         this.colNpaState.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaState.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colNpaState.Caption = "Состояние";
         this.colNpaState.FieldName = "NpaState";
         this.colNpaState.Name = "colNpaState";
         this.colNpaState.Visible = true;
         this.colNpaState.VisibleIndex = 1;
         this.colNpaState.Width = 60;
         // 
         // colNpaKind
         // 
         this.colNpaKind.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaKind.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaKind.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colNpaKind.Caption = "Вид проекта НПА";
         this.colNpaKind.FieldName = "NpaKind";
         this.colNpaKind.Name = "colNpaKind";
         this.colNpaKind.Visible = true;
         this.colNpaKind.VisibleIndex = 2;
         this.colNpaKind.Width = 150;
         // 
         // colNpaName
         // 
         this.colNpaName.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colNpaName.Caption = "Наименование проекта НПА";
         this.colNpaName.ColumnEdit = this.riMemoNpaName;
         this.colNpaName.FieldName = "NpaName";
         this.colNpaName.Name = "colNpaName";
         this.colNpaName.Visible = true;
         this.colNpaName.VisibleIndex = 3;
         this.colNpaName.Width = 350;
         // 
         // riMemoNpaName
         // 
         this.riMemoNpaName.Name = "riMemoNpaName";
         // 
         // colIogv
         // 
         this.colIogv.AppearanceHeader.Options.UseTextOptions = true;
         this.colIogv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colIogv.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colIogv.Caption = "Ответственный за подготовку проекта";
         this.colIogv.ColumnEdit = this.riMemoIogv;
         this.colIogv.FieldName = "Iogv";
         this.colIogv.Name = "colIogv";
         this.colIogv.Visible = true;
         this.colIogv.VisibleIndex = 4;
         this.colIogv.Width = 250;
         // 
         // riMemoIogv
         // 
         this.riMemoIogv.Name = "riMemoIogv";
         // 
         // colPlanDateLaw
         // 
         this.colPlanDateLaw.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateLaw.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateLaw.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colPlanDateLaw.Caption = "Срок предеачи на юр. экспертизу";
         this.colPlanDateLaw.ColumnEdit = this.riDateEditLaw;
         this.colPlanDateLaw.FieldName = "PlanDateLaw";
         this.colPlanDateLaw.Name = "colPlanDateLaw";
         this.colPlanDateLaw.Visible = true;
         this.colPlanDateLaw.VisibleIndex = 5;
         this.colPlanDateLaw.Width = 85;
         // 
         // riDateEditLaw
         // 
         this.riDateEditLaw.AutoHeight = false;
         this.riDateEditLaw.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditLaw.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditLaw.Name = "riDateEditLaw";
         // 
         // colPlanDateOther
         // 
         this.colPlanDateOther.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateOther.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateOther.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colPlanDateOther.Caption = "Срок согласования с заинтересованными подразделениями";
         this.colPlanDateOther.ColumnEdit = this.riDateEditOther;
         this.colPlanDateOther.FieldName = "PlanDateOther";
         this.colPlanDateOther.Name = "colPlanDateOther";
         this.colPlanDateOther.Visible = true;
         this.colPlanDateOther.VisibleIndex = 6;
         this.colPlanDateOther.Width = 85;
         // 
         // riDateEditOther
         // 
         this.riDateEditOther.AutoHeight = false;
         this.riDateEditOther.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditOther.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditOther.Name = "riDateEditOther";
         // 
         // colPlanDateAssembly
         // 
         this.colPlanDateAssembly.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateAssembly.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateAssembly.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colPlanDateAssembly.Caption = "Срок представления на рассмотрение комитетов Зак. Собрания";
         this.colPlanDateAssembly.ColumnEdit = this.riDateEditAssembly;
         this.colPlanDateAssembly.FieldName = "PlanDateAssembly";
         this.colPlanDateAssembly.Name = "colPlanDateAssembly";
         this.colPlanDateAssembly.Visible = true;
         this.colPlanDateAssembly.VisibleIndex = 7;
         this.colPlanDateAssembly.Width = 100;
         // 
         // riDateEditAssembly
         // 
         this.riDateEditAssembly.AutoHeight = false;
         this.riDateEditAssembly.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditAssembly.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditAssembly.Name = "riDateEditAssembly";
         // 
         // colPlanDateGov
         // 
         this.colPlanDateGov.AppearanceHeader.Options.UseTextOptions = true;
         this.colPlanDateGov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colPlanDateGov.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colPlanDateGov.Caption = "Дата внесения на рассмотрение Зак. Собрания";
         this.colPlanDateGov.ColumnEdit = this.riDateEditGov;
         this.colPlanDateGov.FieldName = "PlanDateGov";
         this.colPlanDateGov.Name = "colPlanDateGov";
         this.colPlanDateGov.Visible = true;
         this.colPlanDateGov.VisibleIndex = 8;
         this.colPlanDateGov.Width = 85;
         // 
         // riDateEditGov
         // 
         this.riDateEditGov.AutoHeight = false;
         this.riDateEditGov.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditGov.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditGov.Name = "riDateEditGov";
         // 
         // gridColNpaNote
         // 
         this.gridColNpaNote.AppearanceHeader.Options.UseTextOptions = true;
         this.gridColNpaNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.gridColNpaNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.gridColNpaNote.Caption = "Примечание";
         this.gridColNpaNote.ColumnEdit = this.riMemoNpaNote;
         this.gridColNpaNote.FieldName = "NpaNote";
         this.gridColNpaNote.Name = "gridColNpaNote";
         this.gridColNpaNote.Visible = true;
         this.gridColNpaNote.VisibleIndex = 9;
         this.gridColNpaNote.Width = 250;
         // 
         // riMemoNpaNote
         // 
         this.riMemoNpaNote.Name = "riMemoNpaNote";
         // 
         // colNpaStatus
         // 
         this.colNpaStatus.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaStatus.Caption = "Статус НПА";
         this.colNpaStatus.ColumnEdit = this.riLookUpNpaStatusRef;
         this.colNpaStatus.FieldName = "Status";
         this.colNpaStatus.Name = "colNpaStatus";
         this.colNpaStatus.Visible = true;
         this.colNpaStatus.VisibleIndex = 10;
         this.colNpaStatus.Width = 90;
         // 
         // riLookUpNpaStatusRef
         // 
         this.riLookUpNpaStatusRef.AutoHeight = false;
         this.riLookUpNpaStatusRef.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riLookUpNpaStatusRef.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", 90, "Статус")});
         this.riLookUpNpaStatusRef.DataSource = this.npaStatusBindingSrc;
         this.riLookUpNpaStatusRef.DisplayMember = "Status";
         this.riLookUpNpaStatusRef.Name = "riLookUpNpaStatusRef";
         this.riLookUpNpaStatusRef.ValueMember = "Status";
         // 
         // riLookupIogv
         // 
         this.riLookupIogv.AutoHeight = false;
         this.riLookupIogv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riLookupIogv.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iogv", 450, "Подразделение")});
         this.riLookupIogv.DataSource = this.iogvRefBindingSource;
         this.riLookupIogv.DisplayMember = "Iogv";
         this.riLookupIogv.DropDownRows = 12;
         this.riLookupIogv.Name = "riLookupIogv";
         this.riLookupIogv.PopupWidth = 400;
         this.riLookupIogv.ValueMember = "Iogv";
         // 
         // NpaIIGridCtrl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gridControl1);
         this.Name = "NpaIIGridCtrl";
         this.Size = new System.Drawing.Size(777, 466);
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaName)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoIogv)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditOther.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditOther)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditAssembly.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditAssembly)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditGov.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditGov)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookUpNpaStatusRef)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStatusBindingSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookupIogv)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.iogvRefBindingSource)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colId;
      private DevExpress.XtraGrid.Columns.GridColumn colIndex;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaState;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaKind;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaName;
      private DevExpress.XtraGrid.Columns.GridColumn colIogv;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateLaw;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateOther;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateAssembly;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateGov;
      private DevExpress.XtraGrid.Columns.GridColumn gridColNpaNote;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoIogv;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoNpaName;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoNpaNote;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditLaw;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditOther;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditAssembly;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditGov;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
      private DevExpress.XtraGrid.Columns.GridColumn colId1;
      private DevExpress.XtraGrid.Columns.GridColumn colDateD1;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateLaw1;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateOther1;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateAssembly1;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateGov1;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaNote;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookupIogv;
      private System.Windows.Forms.BindingSource iogvRefBindingSource;
      private System.Windows.Forms.BindingSource npaStatusBindingSrc;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaStatus;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpNpaStatusRef;
   }
}
