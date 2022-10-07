namespace NpaManager {
   partial class DeadlinesIV {
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
         this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
         this.spinPlanDateLaw = new DevExpress.XtraEditors.SpinEdit();
         this.planLawDateEdit = new DevExpress.XtraEditors.DateEdit();
         this.regDateLawEdit = new DevExpress.XtraEditors.DateEdit();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
         this.groupControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLaw.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planLawDateEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planLawDateEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawEdit.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // groupControl1
         // 
         this.groupControl1.Controls.Add(this.spinPlanDateLaw);
         this.groupControl1.Controls.Add(this.planLawDateEdit);
         this.groupControl1.Controls.Add(this.regDateLawEdit);
         this.groupControl1.Controls.Add(this.label2);
         this.groupControl1.Controls.Add(this.label1);
         this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupControl1.Location = new System.Drawing.Point(0, 0);
         this.groupControl1.Name = "groupControl1";
         this.groupControl1.Size = new System.Drawing.Size(545, 73);
         this.groupControl1.TabIndex = 0;
         this.groupControl1.Text = "IV. Проекты приказов ОИВ";
         // 
         // spinPlanDateLaw
         // 
         this.spinPlanDateLaw.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
         this.spinPlanDateLaw.Location = new System.Drawing.Point(318, 26);
         this.spinPlanDateLaw.Name = "spinPlanDateLaw";
         this.spinPlanDateLaw.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spinPlanDateLaw.Properties.IsFloatValue = false;
         this.spinPlanDateLaw.Properties.Mask.EditMask = "N00";
         this.spinPlanDateLaw.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.spinPlanDateLaw.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.spinPlanDateLaw.Size = new System.Drawing.Size(41, 20);
         this.spinPlanDateLaw.TabIndex = 0;
         this.spinPlanDateLaw.EditValueChanged += new System.EventHandler(this.numericPlanDateLaw_EditValueChanged);
         // 
         // planLawDateEdit
         // 
         this.planLawDateEdit.EditValue = null;
         this.planLawDateEdit.Enabled = false;
         this.planLawDateEdit.Location = new System.Drawing.Point(365, 26);
         this.planLawDateEdit.Name = "planLawDateEdit";
         this.planLawDateEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
         this.planLawDateEdit.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
         this.planLawDateEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
         this.planLawDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
         this.planLawDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planLawDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planLawDateEdit.Size = new System.Drawing.Size(88, 20);
         this.planLawDateEdit.TabIndex = 1;
         // 
         // regDateLawEdit
         // 
         this.regDateLawEdit.EditValue = null;
         this.regDateLawEdit.Location = new System.Drawing.Point(365, 48);
         this.regDateLawEdit.Name = "regDateLawEdit";
         this.regDateLawEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
         this.regDateLawEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.regDateLawEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.regDateLawEdit.Size = new System.Drawing.Size(88, 20);
         this.regDateLawEdit.TabIndex = 2;
         this.regDateLawEdit.EditValueChanged += new System.EventHandler(this.regDateLawEdit_EditValueChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 51);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(198, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Дата регистрации в юр. управлении:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(312, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Срок представления проекта на юридическую экспертизу:";
         // 
         // DeadlinesIV
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.Controls.Add(this.groupControl1);
         this.Name = "DeadlinesIV";
         this.Size = new System.Drawing.Size(545, 73);
         this.Load += new System.EventHandler(this.DeadlinesIV_Load);
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
         this.groupControl1.ResumeLayout(false);
         this.groupControl1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLaw.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planLawDateEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planLawDateEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.regDateLawEdit.Properties)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.GroupControl groupControl1;
      private DevExpress.XtraEditors.SpinEdit spinPlanDateLaw;
      private DevExpress.XtraEditors.DateEdit planLawDateEdit;
      private DevExpress.XtraEditors.DateEdit regDateLawEdit;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}
