namespace NpaManager {
   partial class PeriodTreeCtrl {
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
         this.treeList1 = new DevExpress.XtraTreeList.TreeList();
         this.colYear = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colQuarter = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colPeriodId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colDateFirst = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colDateEnd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colEditable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.colBrowsable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.MAddQuarter = new System.Windows.Forms.ToolStripMenuItem();
         this.MDelQuarter = new System.Windows.Forms.ToolStripMenuItem();
         this.bindingSrc = new System.Windows.Forms.BindingSource(this.components);
         this.DS = new NpaManager.NpaDataSet();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.btnAddQuarter = new System.Windows.Forms.ToolStripButton();
         this.btnDelQuarter = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.btnEditable = new System.Windows.Forms.ToolStripButton();
         this.btnBrowsable = new System.Windows.Forms.ToolStripButton();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
         this.contextMenuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // treeList1
         // 
         this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colYear,
            this.colQuarter,
            this.colPeriodId,
            this.colDateFirst,
            this.colDateEnd,
            this.colEditable,
            this.colBrowsable});
         this.treeList1.ContextMenuStrip = this.contextMenuStrip1;
         this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeList1.KeyFieldName = "";
         this.treeList1.Location = new System.Drawing.Point(0, 25);
         this.treeList1.Name = "treeList1";
         this.treeList1.OptionsBehavior.Editable = false;
         this.treeList1.ParentFieldName = "";
         this.treeList1.Size = new System.Drawing.Size(342, 289);
         this.treeList1.TabIndex = 0;
         this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
         // 
         // colYear
         // 
         this.colYear.Caption = "Год";
         this.colYear.FieldName = "Year";
         this.colYear.MinWidth = 40;
         this.colYear.Name = "colYear";
         this.colYear.OptionsColumn.FixedWidth = true;
         this.colYear.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer;
         this.colYear.Visible = true;
         this.colYear.VisibleIndex = 0;
         this.colYear.Width = 40;
         // 
         // colQuarter
         // 
         this.colQuarter.Caption = "Квартал";
         this.colQuarter.FieldName = "Quarter";
         this.colQuarter.MinWidth = 36;
         this.colQuarter.Name = "colQuarter";
         this.colQuarter.OptionsColumn.FixedWidth = true;
         this.colQuarter.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Integer;
         this.colQuarter.Visible = true;
         this.colQuarter.VisibleIndex = 1;
         this.colQuarter.Width = 36;
         // 
         // colPeriodId
         // 
         this.colPeriodId.Caption = "Период";
         this.colPeriodId.FieldName = "PeriodId";
         this.colPeriodId.MinWidth = 120;
         this.colPeriodId.Name = "colPeriodId";
         this.colPeriodId.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
         this.colPeriodId.Visible = true;
         this.colPeriodId.VisibleIndex = 2;
         this.colPeriodId.Width = 150;
         // 
         // colDateFirst
         // 
         this.colDateFirst.Caption = "Начало";
         this.colDateFirst.FieldName = "DateFirst";
         this.colDateFirst.MinWidth = 70;
         this.colDateFirst.Name = "colDateFirst";
         this.colDateFirst.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime;
         this.colDateFirst.Visible = true;
         this.colDateFirst.VisibleIndex = 3;
         this.colDateFirst.Width = 70;
         // 
         // colDateEnd
         // 
         this.colDateEnd.Caption = "Конец";
         this.colDateEnd.FieldName = "DateEnd";
         this.colDateEnd.MinWidth = 70;
         this.colDateEnd.Name = "colDateEnd";
         this.colDateEnd.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime;
         this.colDateEnd.Visible = true;
         this.colDateEnd.VisibleIndex = 4;
         this.colDateEnd.Width = 70;
         // 
         // colEditable
         // 
         this.colEditable.Caption = "Правка";
         this.colEditable.FieldName = "Правка";
         this.colEditable.MinWidth = 50;
         this.colEditable.Name = "colEditable";
         this.colEditable.OptionsColumn.FixedWidth = true;
         this.colEditable.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
         this.colEditable.Visible = true;
         this.colEditable.VisibleIndex = 5;
         this.colEditable.Width = 50;
         // 
         // colBrowsable
         // 
         this.colBrowsable.Caption = "На сайт";
         this.colBrowsable.FieldName = "Browsable";
         this.colBrowsable.Name = "colBrowsable";
         this.colBrowsable.OptionsColumn.FixedWidth = true;
         this.colBrowsable.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
         this.colBrowsable.Visible = true;
         this.colBrowsable.VisibleIndex = 6;
         this.colBrowsable.Width = 50;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAddQuarter,
            this.MDelQuarter});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
         // 
         // MAddQuarter
         // 
         this.MAddQuarter.Image = global::NpaManager.Properties.Resources._112_Plus_Green_16x16_72;
         this.MAddQuarter.Name = "MAddQuarter";
         this.MAddQuarter.Size = new System.Drawing.Size(164, 22);
         this.MAddQuarter.Text = "Добавить период";
         this.MAddQuarter.Click += new System.EventHandler(this.MAddQuarter_Click);
         // 
         // MDelQuarter
         // 
         this.MDelQuarter.Image = global::NpaManager.Properties.Resources._112_Minus_Green_16x16_72;
         this.MDelQuarter.Name = "MDelQuarter";
         this.MDelQuarter.Size = new System.Drawing.Size(164, 22);
         this.MDelQuarter.Text = "Удалить период";
         this.MDelQuarter.Click += new System.EventHandler(this.MDelQuarter_Click);
         // 
         // bindingSrc
         // 
         this.bindingSrc.DataMember = "Periods";
         this.bindingSrc.DataSource = this.DS;
         // 
         // DS
         // 
         this.DS.DataSetName = "NpaDataSet";
         this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddQuarter,
            this.btnDelQuarter,
            this.toolStripSeparator1,
            this.btnEditable,
            this.btnBrowsable});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(342, 25);
         this.toolStrip1.TabIndex = 1;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // btnAddQuarter
         // 
         this.btnAddQuarter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnAddQuarter.Image = global::NpaManager.Properties.Resources.plus;
         this.btnAddQuarter.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnAddQuarter.Name = "btnAddQuarter";
         this.btnAddQuarter.Size = new System.Drawing.Size(23, 22);
         this.btnAddQuarter.Text = "Добавить период";
         this.btnAddQuarter.Click += new System.EventHandler(this.btnAddQuarter_Click);
         // 
         // btnDelQuarter
         // 
         this.btnDelQuarter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnDelQuarter.Image = global::NpaManager.Properties.Resources.minus;
         this.btnDelQuarter.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnDelQuarter.Name = "btnDelQuarter";
         this.btnDelQuarter.Size = new System.Drawing.Size(23, 22);
         this.btnDelQuarter.Text = "Удалить период";
         this.btnDelQuarter.Click += new System.EventHandler(this.btnDelQuarter_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // btnEditable
         // 
         this.btnEditable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnEditable.Image = global::NpaManager.Properties.Resources._lock;
         this.btnEditable.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnEditable.Name = "btnEditable";
         this.btnEditable.Size = new System.Drawing.Size(23, 22);
         this.btnEditable.Text = "Разрешить/Запретить правку";
         this.btnEditable.Click += new System.EventHandler(this.btnEditable_Click);
         // 
         // btnBrowsable
         // 
         this.btnBrowsable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.btnBrowsable.Image = global::NpaManager.Properties.Resources.Button_Turn_On;
         this.btnBrowsable.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.btnBrowsable.Name = "btnBrowsable";
         this.btnBrowsable.Size = new System.Drawing.Size(23, 22);
         this.btnBrowsable.Text = "Вкл/выкл отображеиие на сайте";
         this.btnBrowsable.Click += new System.EventHandler(this.btnBrowsable_Click);
         // 
         // timer1
         // 
         this.timer1.Interval = 500;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // PeriodTreeCtrl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.treeList1);
         this.Controls.Add(this.toolStrip1);
         this.Name = "PeriodTreeCtrl";
         this.Size = new System.Drawing.Size(342, 314);
         this.Load += new System.EventHandler(this.PeriodTreeCtrl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
         this.contextMenuStrip1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraTreeList.TreeList treeList1;
      private System.Windows.Forms.BindingSource bindingSrc;
      private NpaDataSet DS;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colQuarter;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colYear;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colDateFirst;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colDateEnd;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colPeriodId;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem MAddQuarter;
      private System.Windows.Forms.ToolStripMenuItem MDelQuarter;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton btnDelQuarter;
      private System.Windows.Forms.ToolStripButton btnAddQuarter;
      private System.Windows.Forms.Timer timer1;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colEditable;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton btnEditable;
      private System.Windows.Forms.ToolStripButton btnBrowsable;
      private DevExpress.XtraTreeList.Columns.TreeListColumn colBrowsable;

   }
}
