namespace NpaManager {
   partial class AddNpaIDialog {
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
         System.Windows.Forms.Label planDateEconLabel;
         System.Windows.Forms.Label planDateLingvLabel;
         System.Windows.Forms.Label planDateOrgLabel;
         System.Windows.Forms.Label planDateGovLabel;
         System.Windows.Forms.Label label1;
         System.Windows.Forms.Label statusLabel;
         this.npaDataSet = new NpaManager.NpaDataSet();
         this.npaIBindingSource = new System.Windows.Forms.BindingSource();
         this.indexSpinEdit = new DevExpress.XtraEditors.SpinEdit();
         this.npaStateTextEdit = new DevExpress.XtraEditors.TextEdit();
         this.planDateLawDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.planDateEconDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.planDateLingvDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.planDateOrgDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.planDateGovDateEdit = new DevExpress.XtraEditors.DateEdit();
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
         this.StatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
         this.StatusBindingSource = new System.Windows.Forms.BindingSource();
         this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
         indexLabel = new System.Windows.Forms.Label();
         npaStateLabel = new System.Windows.Forms.Label();
         npaNameLabel = new System.Windows.Forms.Label();
         iogvLabel = new System.Windows.Forms.Label();
         planDateLawLabel = new System.Windows.Forms.Label();
         planDateEconLabel = new System.Windows.Forms.Label();
         planDateLingvLabel = new System.Windows.Forms.Label();
         planDateOrgLabel = new System.Windows.Forms.Label();
         planDateGovLabel = new System.Windows.Forms.Label();
         label1 = new System.Windows.Forms.Label();
         statusLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaIBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.indexSpinEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStateTextEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateEconDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateEconDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateOrgDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateOrgDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNameMemoEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvLookUpEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNoteMemoEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).BeginInit();
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
         iogvLabel.Location = new System.Drawing.Point(3, 126);
         iogvLabel.Name = "iogvLabel";
         iogvLabel.Size = new System.Drawing.Size(263, 13);
         iogvLabel.TabIndex = 6;
         iogvLabel.Text = "Ответственный за подготовку проекта:";
         // 
         // planDateLawLabel
         // 
         planDateLawLabel.Location = new System.Drawing.Point(3, 152);
         planDateLawLabel.Name = "planDateLawLabel";
         planDateLawLabel.Size = new System.Drawing.Size(263, 13);
         planDateLawLabel.TabIndex = 8;
         planDateLawLabel.Text = "Срок передачи на юр. экспертизу:";
         // 
         // planDateEconLabel
         // 
         planDateEconLabel.Location = new System.Drawing.Point(3, 174);
         planDateEconLabel.Name = "planDateEconLabel";
         planDateEconLabel.Size = new System.Drawing.Size(263, 28);
         planDateEconLabel.TabIndex = 10;
         planDateEconLabel.Text = "Срок передачи на финансово-экономическую экспертизу:";
         // 
         // planDateLingvLabel
         // 
         planDateLingvLabel.Location = new System.Drawing.Point(3, 211);
         planDateLingvLabel.Name = "planDateLingvLabel";
         planDateLingvLabel.Size = new System.Drawing.Size(263, 29);
         planDateLingvLabel.TabIndex = 12;
         planDateLingvLabel.Text = "Срок передачи на лингвистическую экспертизу:";
         // 
         // planDateOrgLabel
         // 
         planDateOrgLabel.Location = new System.Drawing.Point(3, 240);
         planDateOrgLabel.Name = "planDateOrgLabel";
         planDateOrgLabel.Size = new System.Drawing.Size(263, 13);
         planDateOrgLabel.TabIndex = 14;
         planDateOrgLabel.Text = "Срок передачи в организационное управление:";
         // 
         // planDateGovLabel
         // 
         planDateGovLabel.Location = new System.Drawing.Point(3, 266);
         planDateGovLabel.Name = "planDateGovLabel";
         planDateGovLabel.Size = new System.Drawing.Size(263, 13);
         planDateGovLabel.TabIndex = 16;
         planDateGovLabel.Text = "Дата рассмотрения на заседании правительства:";
         // 
         // label1
         // 
         label1.Location = new System.Drawing.Point(3, 293);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(263, 13);
         label1.TabIndex = 18;
         label1.Text = "Примечание:";
         // 
         // statusLabel
         // 
         statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         statusLabel.Location = new System.Drawing.Point(3, 351);
         statusLabel.Name = "statusLabel";
         statusLabel.Size = new System.Drawing.Size(263, 13);
         statusLabel.TabIndex = 20;
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
         this.planDateLawDateEdit.Location = new System.Drawing.Point(287, 147);
         this.planDateLawDateEdit.Name = "planDateLawDateEdit";
         this.planDateLawDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateLawDateEdit.TabIndex = 9;
         // 
         // planDateEconDateEdit
         // 
         this.planDateEconDateEdit.EditValue = null;
         this.planDateEconDateEdit.Location = new System.Drawing.Point(287, 180);
         this.planDateEconDateEdit.Name = "planDateEconDateEdit";
         this.planDateEconDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateEconDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateEconDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateEconDateEdit.TabIndex = 11;
         // 
         // planDateLingvDateEdit
         // 
         this.planDateLingvDateEdit.EditValue = null;
         this.planDateLingvDateEdit.Location = new System.Drawing.Point(287, 206);
         this.planDateLingvDateEdit.Name = "planDateLingvDateEdit";
         this.planDateLingvDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLingvDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLingvDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateLingvDateEdit.TabIndex = 13;
         // 
         // planDateOrgDateEdit
         // 
         this.planDateOrgDateEdit.EditValue = null;
         this.planDateOrgDateEdit.Location = new System.Drawing.Point(287, 235);
         this.planDateOrgDateEdit.Name = "planDateOrgDateEdit";
         this.planDateOrgDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateOrgDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateOrgDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateOrgDateEdit.TabIndex = 15;
         // 
         // planDateGovDateEdit
         // 
         this.planDateGovDateEdit.EditValue = null;
         this.planDateGovDateEdit.Location = new System.Drawing.Point(287, 261);
         this.planDateGovDateEdit.Name = "planDateGovDateEdit";
         this.planDateGovDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateGovDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateGovDateEdit.Size = new System.Drawing.Size(100, 20);
         this.planDateGovDateEdit.TabIndex = 17;
         // 
         // NpaNameMemoEdit
         // 
         this.NpaNameMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.NpaNameMemoEdit.Location = new System.Drawing.Point(287, 64);
         this.NpaNameMemoEdit.Name = "NpaNameMemoEdit";
         this.NpaNameMemoEdit.Size = new System.Drawing.Size(248, 49);
         this.NpaNameMemoEdit.TabIndex = 5;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Location = new System.Drawing.Point(6, 371);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(528, 7);
         this.groupBox1.TabIndex = 24;
         this.groupBox1.TabStop = false;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.Location = new System.Drawing.Point(371, 394);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(80, 27);
         this.btnCancel.TabIndex = 22;
         this.btnCancel.Text = "Отмена";
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.Location = new System.Drawing.Point(457, 394);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(80, 27);
         this.btnOK.TabIndex = 23;
         this.btnOK.Text = "Сохранить";
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // IogvLookUpEdit
         // 
         this.IogvLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.IogvLookUpEdit.Location = new System.Drawing.Point(287, 121);
         this.IogvLookUpEdit.Name = "IogvLookUpEdit";
         this.IogvLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.IogvLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iogv", "Подразделение")});
         this.IogvLookUpEdit.Properties.DataSource = this.IogvBindingSource;
         this.IogvLookUpEdit.Properties.DisplayMember = "Iogv";
         this.IogvLookUpEdit.Properties.ValueMember = "Iogv";
         this.IogvLookUpEdit.Size = new System.Drawing.Size(247, 20);
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
         this.labelControl3.Location = new System.Drawing.Point(272, 126);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(10, 19);
         this.labelControl3.TabIndex = 11;
         this.labelControl3.Text = "*";
         // 
         // labelControl4
         // 
         this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl4.Location = new System.Drawing.Point(273, 264);
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
         this.NpaNoteMemoEdit.Location = new System.Drawing.Point(287, 290);
         this.NpaNoteMemoEdit.Name = "NpaNoteMemoEdit";
         this.NpaNoteMemoEdit.Size = new System.Drawing.Size(248, 48);
         this.NpaNoteMemoEdit.TabIndex = 19;
         // 
         // StatusLookUpEdit
         // 
         this.StatusLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.StatusLookUpEdit.Location = new System.Drawing.Point(287, 344);
         this.StatusLookUpEdit.Name = "StatusLookUpEdit";
         this.StatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.StatusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Cтатус")});
         this.StatusLookUpEdit.Properties.DataSource = this.StatusBindingSource;
         this.StatusLookUpEdit.Properties.DisplayMember = "Status";
         this.StatusLookUpEdit.Properties.ValueMember = "Status";
         this.StatusLookUpEdit.Size = new System.Drawing.Size(247, 20);
         this.StatusLookUpEdit.TabIndex = 21;
         // 
         // StatusBindingSource
         // 
         this.StatusBindingSource.DataMember = "NpaStatusRef";
         this.StatusBindingSource.DataSource = this.npaDataSet;
         // 
         // labelControl5
         // 
         this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.labelControl5.Location = new System.Drawing.Point(272, 349);
         this.labelControl5.Name = "labelControl5";
         this.labelControl5.Size = new System.Drawing.Size(10, 19);
         this.labelControl5.TabIndex = 28;
         this.labelControl5.Text = "*";
         // 
         // AddNpaIDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.ClientSize = new System.Drawing.Size(547, 433);
         this.ControlBox = false;
         this.Controls.Add(this.labelControl5);
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
         this.Controls.Add(planDateGovLabel);
         this.Controls.Add(this.planDateGovDateEdit);
         this.Controls.Add(planDateOrgLabel);
         this.Controls.Add(this.planDateOrgDateEdit);
         this.Controls.Add(planDateLingvLabel);
         this.Controls.Add(this.planDateLingvDateEdit);
         this.Controls.Add(planDateEconLabel);
         this.Controls.Add(this.planDateEconDateEdit);
         this.Controls.Add(planDateLawLabel);
         this.Controls.Add(this.planDateLawDateEdit);
         this.Controls.Add(iogvLabel);
         this.Controls.Add(npaNameLabel);
         this.Controls.Add(npaStateLabel);
         this.Controls.Add(this.npaStateTextEdit);
         this.Controls.Add(indexLabel);
         this.Controls.Add(this.indexSpinEdit);
         this.MinimumSize = new System.Drawing.Size(550, 460);
         this.Name = "AddNpaIDialog";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Добавить НПА (раздел I)";
         this.Load += new System.EventHandler(this.AddNpaIDialog_Load);
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaIBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.indexSpinEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaStateTextEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateEconDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateEconDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateOrgDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateOrgDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNameMemoEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvLookUpEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.IogvBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.NpaNoteMemoEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusLookUpEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private NpaDataSet npaDataSet;
      private System.Windows.Forms.BindingSource npaIBindingSource;
      private DevExpress.XtraEditors.SpinEdit indexSpinEdit;
      private DevExpress.XtraEditors.TextEdit npaStateTextEdit;
      private DevExpress.XtraEditors.DateEdit planDateLawDateEdit;
      private DevExpress.XtraEditors.DateEdit planDateEconDateEdit;
      private DevExpress.XtraEditors.DateEdit planDateLingvDateEdit;
      private DevExpress.XtraEditors.DateEdit planDateOrgDateEdit;
      private DevExpress.XtraEditors.DateEdit planDateGovDateEdit;
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
      private DevExpress.XtraEditors.LookUpEdit StatusLookUpEdit;
      private System.Windows.Forms.BindingSource StatusBindingSource;
      private DevExpress.XtraEditors.LabelControl labelControl5;
   }
}