namespace NpaManager {
   partial class OptionsDialog {
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.checkAutoLoadDT = new System.Windows.Forms.CheckBox();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         this.btnOk = new DevExpress.XtraEditors.SimpleButton();
         this.deadlinesI = new NpaManager.DeadlinesI();
         this.deadlinesII = new NpaManager.DeadlinesII();
         this.deadlinesIII = new NpaManager.DeadlinesIII();
         this.deadlinesIV = new NpaManager.DeadlinesIV();
         this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.radioGroup1);
         this.groupBox1.Controls.Add(this.checkAutoLoadDT);
         this.groupBox1.Location = new System.Drawing.Point(10, 8);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(465, 76);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         // 
         // checkAutoLoadDT
         // 
         this.checkAutoLoadDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.checkAutoLoadDT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.checkAutoLoadDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkAutoLoadDT.Location = new System.Drawing.Point(8, 9);
         this.checkAutoLoadDT.Name = "checkAutoLoadDT";
         this.checkAutoLoadDT.Size = new System.Drawing.Size(446, 24);
         this.checkAutoLoadDT.TabIndex = 0;
         this.checkAutoLoadDT.Text = "Автоматическая загрузка таблиц при открытии документа Word";
         this.checkAutoLoadDT.UseVisualStyleBackColor = true;
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.Location = new System.Drawing.Point(316, 567);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 25);
         this.btnCancel.TabIndex = 0;
         this.btnCancel.Text = "Отмена";
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOk
         // 
         this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOk.Location = new System.Drawing.Point(397, 567);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 25);
         this.btnOk.TabIndex = 1;
         this.btnOk.Text = "Сохранить";
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // deadlinesI
         // 
         this.deadlinesI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.deadlinesI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.deadlinesI.Location = new System.Drawing.Point(10, 88);
         this.deadlinesI.Name = "deadlinesI";
         this.deadlinesI.PlanDateEcon = new System.DateTime(2018, 6, 2, 0, 0, 0, 0);
         this.deadlinesI.PlanDateGov = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
         this.deadlinesI.PlanDateLaw = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
         this.deadlinesI.PlanDateLingv = new System.DateTime(2018, 6, 9, 0, 0, 0, 0);
         this.deadlinesI.PlanDateOrg = new System.DateTime(2018, 6, 16, 0, 0, 0, 0);
         this.deadlinesI.Size = new System.Drawing.Size(462, 149);
         this.deadlinesI.SpinPlanDateEcon = 7D;
         this.deadlinesI.SpinPlanDateLaw = 18D;
         this.deadlinesI.SpinPlanDateLingv = 7D;
         this.deadlinesI.SpinPlanDateOrg = 9D;
         this.deadlinesI.TabIndex = 3;
         // 
         // deadlinesII
         // 
         this.deadlinesII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.deadlinesII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.deadlinesII.Location = new System.Drawing.Point(10, 242);
         this.deadlinesII.Name = "deadlinesII";
         this.deadlinesII.PlanDateAssembly = new System.DateTime(2018, 6, 16, 0, 0, 0, 0);
         this.deadlinesII.PlanDateGov = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
         this.deadlinesII.PlanDateLaw = new System.DateTime(2018, 5, 22, 0, 0, 0, 0);
         this.deadlinesII.PlanDateOther = new System.DateTime(2018, 6, 9, 0, 0, 0, 0);
         this.deadlinesII.Size = new System.Drawing.Size(462, 137);
         this.deadlinesII.SpinPlanDateAssembly = 9D;
         this.deadlinesII.SpinPlanDateLaw = 18D;
         this.deadlinesII.SpinPlanDateOther = 7D;
         this.deadlinesII.TabIndex = 4;
         // 
         // deadlinesIII
         // 
         this.deadlinesIII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.deadlinesIII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.deadlinesIII.Location = new System.Drawing.Point(10, 385);
         this.deadlinesIII.Name = "deadlinesIII";
         this.deadlinesIII.PlanDateGov = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
         this.deadlinesIII.PlanDateLaw = new System.DateTime(2018, 5, 20, 0, 0, 0, 0);
         this.deadlinesIII.PlanDateLingv = new System.DateTime(2018, 6, 4, 0, 0, 0, 0);
         this.deadlinesIII.Size = new System.Drawing.Size(462, 97);
         this.deadlinesIII.SpinPlanDateLaw = 15D;
         this.deadlinesIII.SpinPlanDateLingv = 21D;
         this.deadlinesIII.TabIndex = 5;
         // 
         // deadlinesIV
         // 
         this.deadlinesIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.deadlinesIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.deadlinesIV.Location = new System.Drawing.Point(10, 488);
         this.deadlinesIV.Name = "deadlinesIV";
         this.deadlinesIV.PlanDateLaw = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
         this.deadlinesIV.RegDateLaw = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
         this.deadlinesIV.Size = new System.Drawing.Size(463, 73);
         this.deadlinesIV.SpinPlanDateLaw = 15D;
         this.deadlinesIV.TabIndex = 6;
         // 
         // radioGroup1
         // 
         this.radioGroup1.EditValue = "1";
         this.radioGroup1.Location = new System.Drawing.Point(8, 39);
         this.radioGroup1.Name = "radioGroup1";
         this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
         this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
         this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "График НПА 2015 вер. 1.0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "График НПА 2018 вер. 2.0")});
         this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
         this.radioGroup1.Size = new System.Drawing.Size(451, 29);
         this.radioGroup1.TabIndex = 1;
         // 
         // OptionsDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.ClientSize = new System.Drawing.Size(487, 602);
         this.ControlBox = false;
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.deadlinesI);
         this.Controls.Add(this.deadlinesII);
         this.Controls.Add(this.deadlinesIII);
         this.Controls.Add(this.deadlinesIV);
         this.Controls.Add(this.groupBox1);
         this.MinimumSize = new System.Drawing.Size(495, 605);
         this.Name = "OptionsDialog";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Настройки";
         this.Load += new System.EventHandler(this.OptionsDialog_Load);
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.CheckBox checkAutoLoadDT;
      private DeadlinesIV deadlinesIV;
      private DeadlinesIII deadlinesIII;
      private DeadlinesII deadlinesII;
      private DeadlinesI deadlinesI;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOk;
      private DevExpress.XtraEditors.RadioGroup radioGroup1;
   }
}