namespace NpaManager {
   partial class NpaIVGridCtrl {
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
         this.colRegDateLaw1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIndex = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaState = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNpaName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoNpaName = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.colIogv = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoIogv = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.colPlanDateLaw = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditLaw = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.colRegDateLaw = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riDateEditRegLaw = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
         this.colNpaNote = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riMemoNpaNote = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
         this.riLookupIogv = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.iogvRefBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.npaStatusBindingSrc = new System.Windows.Forms.BindingSource(this.components);
         this.ColNpaStatus = new DevExpress.XtraGrid.Columns.GridColumn();
         this.riLookUpNpaStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaName)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoIogv)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditRegLaw)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditRegLaw.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookupIogv)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.iogvRefBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStatusBindingSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookUpNpaStatus)).BeginInit();
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
            this.colRegDateLaw1,
            this.colNpaNote1});
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
         this.colId1.Width = 35;
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
         this.colPlanDateLaw1.Caption = "Срок представления на юр. экспертизу";
         this.colPlanDateLaw1.FieldName = "PlanDateLaw";
         this.colPlanDateLaw1.Name = "colPlanDateLaw1";
         this.colPlanDateLaw1.Visible = true;
         this.colPlanDateLaw1.VisibleIndex = 1;
         this.colPlanDateLaw1.Width = 100;
         // 
         // colRegDateLaw1
         // 
         this.colRegDateLaw1.AppearanceHeader.Options.UseTextOptions = true;
         this.colRegDateLaw1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colRegDateLaw1.Caption = "Дата регистрации в юр. управлении";
         this.colRegDateLaw1.FieldName = "RegDateLaw";
         this.colRegDateLaw1.Name = "colRegDateLaw1";
         this.colRegDateLaw1.Visible = true;
         this.colRegDateLaw1.VisibleIndex = 2;
         this.colRegDateLaw1.Width = 100;
         // 
         // colNpaNote1
         // 
         this.colNpaNote1.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaNote1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaNote1.Caption = "Примечание";
         this.colNpaNote1.FieldName = "NpaNote";
         this.colNpaNote1.Name = "colNpaNote1";
         this.colNpaNote1.Visible = true;
         this.colNpaNote1.VisibleIndex = 3;
         this.colNpaNote1.Width = 350;
         // 
         // gridControl1
         // 
         this.gridControl1.DataMember = null;
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
            this.riDateEditLaw,
            this.riDateEditRegLaw,
            this.riLookupIogv,
            this.riLookUpNpaStatus});
         this.gridControl1.Size = new System.Drawing.Size(934, 466);
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
            this.colNpaName,
            this.colIogv,
            this.colPlanDateLaw,
            this.colRegDateLaw,
            this.colNpaNote,
            this.ColNpaStatus});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NpaIV.Id", null, "(Всего:{0})")});
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
         this.colId.Caption = "ID";
         this.colId.FieldName = "Id";
         this.colId.Name = "colId";
         this.colId.Width = 35;
         // 
         // colIndex
         // 
         this.colIndex.AppearanceCell.Options.UseTextOptions = true;
         this.colIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
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
         // colNpaName
         // 
         this.colNpaName.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colNpaName.Caption = "Наименование проекта приказа";
         this.colNpaName.ColumnEdit = this.riMemoNpaName;
         this.colNpaName.FieldName = "NpaName";
         this.colNpaName.Name = "colNpaName";
         this.colNpaName.Visible = true;
         this.colNpaName.VisibleIndex = 2;
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
         this.colIogv.Caption = "Ответственный за подготовку проекта приказа";
         this.colIogv.ColumnEdit = this.riMemoIogv;
         this.colIogv.FieldName = "Iogv";
         this.colIogv.Name = "colIogv";
         this.colIogv.Visible = true;
         this.colIogv.VisibleIndex = 3;
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
         this.colPlanDateLaw.Caption = "Срок представления на юр. экспертизу";
         this.colPlanDateLaw.ColumnEdit = this.riDateEditLaw;
         this.colPlanDateLaw.FieldName = "PlanDateLaw";
         this.colPlanDateLaw.Name = "colPlanDateLaw";
         this.colPlanDateLaw.Visible = true;
         this.colPlanDateLaw.VisibleIndex = 4;
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
         // colRegDateLaw
         // 
         this.colRegDateLaw.AppearanceHeader.Options.UseTextOptions = true;
         this.colRegDateLaw.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colRegDateLaw.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colRegDateLaw.Caption = "Дата регистрации в юр. управлении";
         this.colRegDateLaw.ColumnEdit = this.riDateEditRegLaw;
         this.colRegDateLaw.FieldName = "RegDateLaw";
         this.colRegDateLaw.Name = "colRegDateLaw";
         this.colRegDateLaw.Visible = true;
         this.colRegDateLaw.VisibleIndex = 5;
         this.colRegDateLaw.Width = 85;
         // 
         // riDateEditRegLaw
         // 
         this.riDateEditRegLaw.AutoHeight = false;
         this.riDateEditRegLaw.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditRegLaw.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riDateEditRegLaw.Name = "riDateEditRegLaw";
         // 
         // colNpaNote
         // 
         this.colNpaNote.AppearanceHeader.Options.UseTextOptions = true;
         this.colNpaNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.colNpaNote.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
         this.colNpaNote.Caption = "Примечание";
         this.colNpaNote.ColumnEdit = this.riMemoNpaNote;
         this.colNpaNote.FieldName = "NpaNote";
         this.colNpaNote.Name = "colNpaNote";
         this.colNpaNote.Visible = true;
         this.colNpaNote.VisibleIndex = 6;
         this.colNpaNote.Width = 250;
         // 
         // riMemoNpaNote
         // 
         this.riMemoNpaNote.Name = "riMemoNpaNote";
         // 
         // riLookupIogv
         // 
         this.riLookupIogv.AutoHeight = false;
         this.riLookupIogv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riLookupIogv.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iogv", 250, "Подразделение")});
         this.riLookupIogv.DataSource = this.iogvRefBindingSource;
         this.riLookupIogv.DisplayMember = "Iogv";
         this.riLookupIogv.DropDownRows = 12;
         this.riLookupIogv.Name = "riLookupIogv";
         this.riLookupIogv.PopupWidth = 400;
         this.riLookupIogv.ValueMember = "Iogv";
         // 
         // ColNpaStatus
         // 
         this.ColNpaStatus.AppearanceHeader.Options.UseTextOptions = true;
         this.ColNpaStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.ColNpaStatus.Caption = "Статус НпА";
         this.ColNpaStatus.ColumnEdit = this.riLookUpNpaStatus;
         this.ColNpaStatus.FieldName = "Status";
         this.ColNpaStatus.Name = "ColNpaStatus";
         this.ColNpaStatus.Visible = true;
         this.ColNpaStatus.VisibleIndex = 7;
         this.ColNpaStatus.Width = 90;
         // 
         // riLookUpNpaStatus
         // 
         this.riLookUpNpaStatus.AutoHeight = false;
         this.riLookUpNpaStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.riLookUpNpaStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Статус", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
         this.riLookUpNpaStatus.DataSource = this.npaStatusBindingSrc;
         this.riLookUpNpaStatus.DisplayMember = "Status";
         this.riLookUpNpaStatus.Name = "riLookUpNpaStatus";
         this.riLookUpNpaStatus.ValueMember = "Status";
         // 
         // NpaIVGridCtrl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gridControl1);
         this.Name = "NpaIVGridCtrl";
         this.Size = new System.Drawing.Size(934, 466);
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaName)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoIogv)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditLaw)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditRegLaw.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riDateEditRegLaw)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riMemoNpaNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookupIogv)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.iogvRefBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStatusBindingSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.riLookUpNpaStatus)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colId;
      private DevExpress.XtraGrid.Columns.GridColumn colIndex;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaState;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaName;
      private DevExpress.XtraGrid.Columns.GridColumn colIogv;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateLaw;
      private DevExpress.XtraGrid.Columns.GridColumn colRegDateLaw;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaNote;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoIogv;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoNpaName;
      private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit riMemoNpaNote;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditLaw;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditRegLaw;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
      private DevExpress.XtraGrid.Columns.GridColumn colId1;
      private DevExpress.XtraGrid.Columns.GridColumn colDateD1;
      private DevExpress.XtraGrid.Columns.GridColumn colPlanDateLaw1;
      private DevExpress.XtraGrid.Columns.GridColumn colRegDateLaw1;
      private DevExpress.XtraGrid.Columns.GridColumn colNpaNote1;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookupIogv;
      private System.Windows.Forms.BindingSource iogvRefBindingSource;
      private System.Windows.Forms.BindingSource npaStatusBindingSrc;
      private DevExpress.XtraGrid.Columns.GridColumn ColNpaStatus;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpNpaStatus;
   }
}
