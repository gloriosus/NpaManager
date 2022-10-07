namespace NpaManager {
   partial class DeadlinesIII {
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
         this.planDateLawEdit = new DevExpress.XtraEditors.DateEdit();
         this.label3 = new System.Windows.Forms.Label();
         this.spinPlanDateLingv = new DevExpress.XtraEditors.SpinEdit();
         this.planDateLingvEdit = new DevExpress.XtraEditors.DateEdit();
         this.planDateGovEdit = new DevExpress.XtraEditors.DateEdit();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
         this.groupControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLaw.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLingv.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvEdit.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovEdit.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovEdit.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // groupControl1
         // 
         this.groupControl1.Controls.Add(this.spinPlanDateLaw);
         this.groupControl1.Controls.Add(this.planDateLawEdit);
         this.groupControl1.Controls.Add(this.label3);
         this.groupControl1.Controls.Add(this.spinPlanDateLingv);
         this.groupControl1.Controls.Add(this.planDateLingvEdit);
         this.groupControl1.Controls.Add(this.planDateGovEdit);
         this.groupControl1.Controls.Add(this.label2);
         this.groupControl1.Controls.Add(this.label1);
         this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupControl1.Location = new System.Drawing.Point(0, 0);
         this.groupControl1.Name = "groupControl1";
         this.groupControl1.Size = new System.Drawing.Size(538, 97);
         this.groupControl1.TabIndex = 0;
         this.groupControl1.Text = "III. Проекты НПА губернатора, распоряжений правительства";
         // 
         // spinPlanDateLaw
         // 
         this.spinPlanDateLaw.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
         this.spinPlanDateLaw.Location = new System.Drawing.Point(317, 25);
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
         this.spinPlanDateLaw.EditValueChanged += new System.EventHandler(this.spinPlanDateLaw_EditValueChanged);
         // 
         // planDateLawEdit
         // 
         this.planDateLawEdit.EditValue = null;
         this.planDateLawEdit.Enabled = false;
         this.planDateLawEdit.Location = new System.Drawing.Point(364, 25);
         this.planDateLawEdit.Name = "planDateLawEdit";
         this.planDateLawEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
         this.planDateLawEdit.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
         this.planDateLawEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
         this.planDateLawEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
         this.planDateLawEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLawEdit.Size = new System.Drawing.Size(88, 20);
         this.planDateLawEdit.TabIndex = 1;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(5, 28);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(238, 13);
         this.label3.TabIndex = 11;
         this.label3.Text = "Срок передачи на юридическую экспертизу:";
         // 
         // spinPlanDateLingv
         // 
         this.spinPlanDateLingv.EditValue = new decimal(new int[] {
            21,
            0,
            0,
            0});
         this.spinPlanDateLingv.Location = new System.Drawing.Point(318, 48);
         this.spinPlanDateLingv.Name = "spinPlanDateLingv";
         this.spinPlanDateLingv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spinPlanDateLingv.Properties.IsFloatValue = false;
         this.spinPlanDateLingv.Properties.Mask.EditMask = "N00";
         this.spinPlanDateLingv.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.spinPlanDateLingv.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.spinPlanDateLingv.Size = new System.Drawing.Size(41, 20);
         this.spinPlanDateLingv.TabIndex = 2;
         this.spinPlanDateLingv.EditValueChanged += new System.EventHandler(this.spinPlanDateLingv_EditValueChanged);
         // 
         // planDateLingvEdit
         // 
         this.planDateLingvEdit.EditValue = null;
         this.planDateLingvEdit.Enabled = false;
         this.planDateLingvEdit.Location = new System.Drawing.Point(365, 48);
         this.planDateLingvEdit.Name = "planDateLingvEdit";
         this.planDateLingvEdit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
         this.planDateLingvEdit.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
         this.planDateLingvEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
         this.planDateLingvEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
         this.planDateLingvEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLingvEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateLingvEdit.Size = new System.Drawing.Size(88, 20);
         this.planDateLingvEdit.TabIndex = 3;
         // 
         // planDateGovEdit
         // 
         this.planDateGovEdit.EditValue = null;
         this.planDateGovEdit.Location = new System.Drawing.Point(365, 71);
         this.planDateGovEdit.Name = "planDateGovEdit";
         this.planDateGovEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
         this.planDateGovEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateGovEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.planDateGovEdit.Size = new System.Drawing.Size(88, 20);
         this.planDateGovEdit.TabIndex = 4;
         this.planDateGovEdit.EditValueChanged += new System.EventHandler(this.planDateGovEdit_EditValueChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 74);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(128, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Дата регистрации НПА:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 51);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(250, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Срок передачи на лигвистическую экспертизу:";
         // 
         // DeadlinesIII
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.Controls.Add(this.groupControl1);
         this.Name = "DeadlinesIII";
         this.Size = new System.Drawing.Size(538, 97);
         this.Load += new System.EventHandler(this.DeadlinesIII_Load);
         ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
         this.groupControl1.ResumeLayout(false);
         this.groupControl1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLaw.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLawEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spinPlanDateLingv.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateLingvEdit.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovEdit.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.planDateGovEdit.Properties)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.GroupControl groupControl1;
      private DevExpress.XtraEditors.SpinEdit spinPlanDateLingv;
      private DevExpress.XtraEditors.DateEdit planDateLingvEdit;
      private DevExpress.XtraEditors.DateEdit planDateGovEdit;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private DevExpress.XtraEditors.SpinEdit spinPlanDateLaw;
      private DevExpress.XtraEditors.DateEdit planDateLawEdit;
      private System.Windows.Forms.Label label3;
   }
}
