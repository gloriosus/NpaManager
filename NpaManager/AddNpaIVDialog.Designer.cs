namespace NpaManager {
   partial class AddNpaIVDialog {
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         System.Windows.Forms.Label indexLabel;
         System.Windows.Forms.Label npaStateLabel;
         System.Windows.Forms.Label npaNameLabel;
         System.Windows.Forms.Label iogvLabel;
         System.Windows.Forms.Label planDateLawLabel;
         System.Windows.Forms.Label regDateLawLabel;
         System.Windows.Forms.Label label1;
         System.Windows.Forms.Label statusLabel;
         this.npaDataSet = new NpaManager.NpaDataSet();
         this.npaIBindingSource = new System.Windows.Forms.BindingSource();
         this.indexSpinEdit = new DevExpress.XtraEditors.SpinEdit();
         this.npaStateTextEdit = new DevExpress.XtraEditors.TextEdit();
         this.planDateLawDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.regDateLawDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.NpaNameMemoEdit = new DevExpress.XtraEditors.MemoEdit();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         this.btnOK = new DevExpress.XtraEditors.SimpleButton();
         this.IogvLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
         this.IogvBindingSource = new System.Windows.Forms.BindingSource();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
         this.NpaNoteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
         this.StatusBindingSource = new System.Windows.Forms.BindingSource();
         this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
         this.StatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
         indexLabel = new System.Windows.Forms.Label();
         npaStateLabel = new System.Windows.Forms.Label();
         npaNameLabel = new System.Windows.Forms.Label();
         iogvLabel = new System.Windows.Forms.Label();
         planDateLawLabel = new System.Windows.Forms.Label();
         regDateLawLabel = new System.Windows.Forms.Label();
         label1 = new System.Windows.Forms.Label();
         statusLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaIBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.indexSpinEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStateTextEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNameMemoEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvLookUpEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNoteMemoEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEdit.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // indexLabel
         // 
         indexLabel.Location = new System.Drawing.Point(3, 14);
         indexLabel.Name = "indexLabel";
         indexLabel.Size = new System.Drawing.Size(263, 13);
         indexLabel.TabIndex = 0;
         indexLabel.Text = "№ пп.:";
         // 
         // npaStateLabel
         // 
         npaStateLabel.Location = new System.Drawing.Point(3, 36);
         npaStateLabel.Name = "npaStateLabel";
         npaStateLabel.Size = new System.Drawing.Size(263, 13);
         npaStateLabel.TabIndex = 2;
         npaStateLabel.Text = "Состояние:";
         // 
         // npaNameLabel
         // 
         npaNameLabel.Location = new System.Drawing.Point(3, 66);
         npaNameLabel.Name = "npaNameLabel";
         npaNameLabel.Size = new System.Drawing.Size(263, 13);
         npaNameLabel.TabIndex = 4;
         npaNameLabel.Text = "Наименование проекта НПА:";
         // 
         // iogvLabel
         // 
         iogvLabel.Location = new System.Drawing.Point(3, 133);
         iogvLabel.Name = "iogvLabel";
         iogvLabel.Size = new System.Drawing.Size(263, 13);
         iogvLabel.TabIndex = 6;
         iogvLabel.Text = "Ответственный за подготовку проекта:";
         // 
         // planDateLawLabel
         // 
         planDateLawLabel.Location = new System.Drawing.Point(3, 159);
         planDateLawLabel.Name = "planDateLawLabel";
         planDateLawLabel.Size = new System.Drawing.Size(263, 13);
         planDateLawLabel.TabIndex = 8;
         planDateLawLabel.Text = "Срок передачи на юр. экспертизу:";
         // 
         // regDateLawLabel
         // 
         regDateLawLabel.Location = new System.Drawing.Point(3, 185);
         regDateLawLabel.Name = "regDateLawLabel";
         regDateLawLabel.Size = new System.Drawing.Size(263, 13);
         regDateLawLabel.TabIndex = 10;
         regDateLawLabel.Text = "Дата регистрации в юр. управлении:";
         // 
         // label1
         // 
         label1.Location = new System.Drawing.Point(2, 210);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(263, 13);
         label1.TabIndex = 12;
         label1.Text = "Примечание:";
         // 
         // statusLabel
         // 
         statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         statusLabel.Location = new System.Drawing.Point(3, 259);
         statusLabel.Name = "statusLabel";
         statusLabel.Size = new System.Drawing.Size(263, 13);
         statusLabel.TabIndex = 14;
         statusLabel.Text = "Статус НПА:";
         // 
         // npaDataSet
         // 
         this.npaDataSet.DataSetName = "NpaDataSet";
         this.npaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // npaIBindingSource
         // 
         this.npaIBindingSource.DataMember = "NpaI";
         this.npaIBindingSource.DataSource = this.npaDataSet;
         // 
         // indexSpinEdit
         // 
         this.indexSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.indexSpinEdit.Location = new System.Drawing.Point(287, 11);
         this.indexSpinEdit.Name = "indexSpinEdit";
         this.indexSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.indexSpinEdit.Size = new System.Drawing.Size(100, 20);
         this.indexSpinEdit.TabIndex = 1;
         // 
         // npaStateTextEdit
         // 
         this.npaStateTextEdit.Location = new System.Drawing.Point(287, 37);
         this.npaStateTextEdit.Name = "npaStateTextEdit";
         this.npaStateTextEdit.Size = new System.Drawing.Size(100, 20);
         this.npaStateTextEdit.TabIndex = 3;
         // 
         // planDateLawDateEdit
         // 
         this.planDateLawDateEdit.EditValue = null;
         this.planDateLawDateEdit.Location = new System.Drawing.Point(287, 156);
         this.planDateLawDateEdit.Name = "planDateLawDateEdit";
         this.planDateLawDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateLawDateEdit.TabIndex = 9;
         // 
         // regDateLawDateEdit
         // 
         this.regDateLawDateEdit.EditValue = null;
         this.regDateLawDateEdit.Location = new System.Drawing.Point(287, 182);
         this.regDateLawDateEdit.Name = "regDateLawDateEdit";
         this.regDateLawDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.regDateLawDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.regDateLawDateEdit.Size = new System.Drawing.Size(100, 20);
         this.regDateLawDateEdit.TabIndex = 11;
         // 
         // NpaNameMemoEdit
         // 
         this.NpaNameMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.NpaNameMemoEdit.Location = new System.Drawing.Point(287, 64);
         this.NpaNameMemoEdit.Name = "NpaNameMemoEdit";
         this.NpaNameMemoEdit.Size = new System.Drawing.Size(282, 59);
         this.NpaNameMemoEdit.TabIndex = 5;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Location = new System.Drawing.Point(6, 277);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(562, 7);
         this.groupBox1.TabIndex = 24;
         this.groupBox1.TabStop = false;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.Location = new System.Drawing.Point(402, 294);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(80, 27);
         this.btnCancel.TabIndex = 16;
         this.btnCancel.Text = "Отмена";
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.Location = new System.Drawing.Point(488, 294);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(80, 27);
         this.btnOK.TabIndex = 17;
         this.btnOK.Text = "Сохранить";
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // IogvLookUpEdit
         // 
         this.IogvLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.IogvLookUpEdit.Location = new System.Drawing.Point(287, 130);
         this.IogvLookUpEdit.Name = "IogvLookUpEdit";
         this.IogvLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.IogvLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iogv", "Подразделение")});
         this.IogvLookUpEdit.Properties.DataSource = this.IogvBindingSource;
         this.IogvLookUpEdit.Properties.DisplayMember = "Iogv";
         this.IogvLookUpEdit.Properties.ValueMember = "Iogv";
         this.IogvLookUpEdit.Size = new System.Drawing.Size(281, 20);
         this.IogvLookUpEdit.TabIndex = 7;
         // 
         // IogvBindingSource
         // 
         this.IogvBindingSource.DataMember = "IogvRef";
         this.IogvBindingSource.DataSource = this.npaDataSet;
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl1.Location = new System.Drawing.Point(273, 14);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(10, 19);
         this.labelControl1.TabIndex = 9;
         this.labelControl1.Text = "*";
         // 
         // labelControl2
         // 
         this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl2.Location = new System.Drawing.Point(271, 66);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(10, 19);
         this.labelControl2.TabIndex = 10;
         this.labelControl2.Text = "*";
         // 
         // labelControl3
         // 
         this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl3.Location = new System.Drawing.Point(272, 133);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(10, 19);
         this.labelControl3.TabIndex = 11;
         this.labelControl3.Text = "*";
         // 
         // labelControl4
         // 
         this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl4.Location = new System.Drawing.Point(273, 183);
         this.labelControl4.Name = "labelControl4";
         this.labelControl4.Size = new System.Drawing.Size(10, 19);
         this.labelControl4.TabIndex = 12;
         this.labelControl4.Text = "*";
         // 
         // NpaNoteMemoEdit
         // 
         this.NpaNoteMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.NpaNoteMemoEdit.Location = new System.Drawing.Point(286, 208);
         this.NpaNoteMemoEdit.Name = "NpaNoteMemoEdit";
         this.NpaNoteMemoEdit.Size = new System.Drawing.Size(282, 38);
         this.NpaNoteMemoEdit.TabIndex = 13;
         // 
         // StatusBindingSource
         // 
         this.StatusBindingSource.DataMember = "NpaStatusRef";
         this.StatusBindingSource.DataSource = this.npaDataSet;
         // 
         // labelControl6
         // 
         this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl6.Location = new System.Drawing.Point(272, 257);
         this.labelControl6.Name = "labelControl6";
         this.labelControl6.Size = new System.Drawing.Size(10, 19);
         this.labelControl6.TabIndex = 37;
         this.labelControl6.Text = "*";
         // 
         // StatusLookUpEdit
         // 
         this.StatusLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.StatusLookUpEdit.Location = new System.Drawing.Point(287, 252);
         this.StatusLookUpEdit.Name = "StatusLookUpEdit";
         this.StatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.StatusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Cтатус")});
         this.StatusLookUpEdit.Properties.DataSource = this.StatusBindingSource;
         this.StatusLookUpEdit.Properties.DisplayMember = "Status";
         this.StatusLookUpEdit.Properties.ValueMember = "Status";
         this.StatusLookUpEdit.Size = new System.Drawing.Size(281, 20);
         this.StatusLookUpEdit.TabIndex = 15;
         // 
         // AddNpaIVDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.ClientSize = new System.Drawing.Size(581, 352);
         this.ControlBox = false;
         this.Controls.Add(this.labelControl6);
         this.Controls.Add(this.StatusLookUpEdit);
         this.Controls.Add(statusLabel);
         this.Controls.Add(this.NpaNoteMemoEdit);
         this.Controls.Add(label1);
         this.Controls.Add(this.labelControl4);
         this.Controls.Add(this.labelControl3);
         this.Controls.Add(this.labelControl2);
         this.Controls.Add(this.labelControl1);
         this.Controls.Add(this.IogvLookUpEdit);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.NpaNameMemoEdit);
         this.Controls.Add(regDateLawLabel);
         this.Controls.Add(this.regDateLawDateEdit);
         this.Controls.Add(planDateLawLabel);
         this.Controls.Add(this.planDateLawDateEdit);
         this.Controls.Add(iogvLabel);
         this.Controls.Add(npaNameLabel);
         this.Controls.Add(npaStateLabel);
         this.Controls.Add(this.npaStateTextEdit);
         this.Controls.Add(indexLabel);
         this.Controls.Add(this.indexSpinEdit);
         this.MinimumSize = new System.Drawing.Size(550, 360);
         this.Name = "AddNpaIVDialog";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Добавить НПА (раздел IV)";
         this.Load += new System.EventHandler(this.AddNpaIDialog_Load);
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaIBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.indexSpinEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStateTextEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNameMemoEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvLookUpEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNoteMemoEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEdit.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private NpaDataSet npaDataSet;
      private System.Windows.Forms.BindingSource npaIBindingSource;
      private DevExpress.XtraEditors.SpinEdit indexSpinEdit;
      private DevExpress.XtraEditors.TextEdit npaStateTextEdit;
      private DevExpress.XtraEditors.DateEdit planDateLawDateEdit;
      private DevExpress.XtraEditors.DateEdit regDateLawDateEdit;
      private DevExpress.XtraEditors.MemoEdit NpaNameMemoEdit;
      private System.Windows.Forms.GroupBox groupBox1;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.LookUpEdit IogvLookUpEdit;
      private System.Windows.Forms.BindingSource IogvBindingSource;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private DevExpress.XtraEditors.MemoEdit NpaNoteMemoEdit;
      private System.Windows.Forms.BindingSource StatusBindingSource;
      private DevExpress.XtraEditors.LabelControl labelControl6;
      private DevExpress.XtraEditors.LookUpEdit StatusLookUpEdit;
   }
}