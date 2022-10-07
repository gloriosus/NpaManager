using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class OptionsDialog : Form {
      #region Properties
      /// <summary>
      /// Автоматическая загрузка таблиц при открытии документа Word
      /// </summary>
      public bool AutoLoadDT {
         get { return checkAutoLoadDT.Checked; }
         set { checkAutoLoadDT.Checked = value; }
      }

      public int DeadlineOrgI {
         get { return (int)deadlinesI.SpinPlanDateOrg; }
         set { deadlinesI.SpinPlanDateOrg = value; }
      }

      public int DeadlineLingvI {
         get { return (int)deadlinesI.SpinPlanDateLingv; }
         set { deadlinesI.SpinPlanDateLingv = value; }
      }

      public int DeadlineEconI {
         get { return (int)deadlinesI.SpinPlanDateEcon; }
         set { deadlinesI.SpinPlanDateEcon = value; }
      }

      public int DeadlineLawI {
         get { return (int)deadlinesI.SpinPlanDateLaw; }
         set { deadlinesI.SpinPlanDateLaw = value; }
      }

      public int DeadlineAssemblyII {
         get { return (int)deadlinesII.SpinPlanDateAssembly; }
         set { deadlinesII.SpinPlanDateAssembly = value; }
      }

      public int DeadlineOtherII {
         get { return (int)deadlinesII.SpinPlanDateOther; }
         set { deadlinesII.SpinPlanDateOther = value; }
      }

      public int DeadlineLawII {
         get { return (int)deadlinesII.SpinPlanDateLaw; }
         set { deadlinesII.SpinPlanDateLaw = value; }
      }

      public int DeadlineLingvIII {
         get { return (int)deadlinesIII.SpinPlanDateLingv; }
         set { deadlinesIII.SpinPlanDateLingv = value; }
      }

      public int DeadlineLawIII {
         get { return (int)deadlinesIII.SpinPlanDateLaw; }
         set { deadlinesIII.SpinPlanDateLaw = value; }
      }

      public int DeadlineLavIV {
         get { return (int)deadlinesIV.SpinPlanDateLaw; }
         set { deadlinesIV.SpinPlanDateLaw = value; }
      }

      public int WordVerson {
         get { return (int)radioGroup1.EditValue; }
         set { radioGroup1.EditValue = value; }
      }
      #endregion

      #region Constructors
      public OptionsDialog() {
         InitializeComponent();
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрузка формы
      /// </summary>
      private void OptionsDialog_Load(object sender, EventArgs e) {
      }

      /// <summary>
      /// Нажали кнопку "Отмета"
      /// </summary>
      private void btnCancel_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

      /// <summary>
      /// Нажали кнопку "Сохранить"
      /// </summary>
      private void btnOk_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.OK;
         this.Close();
      }
      #endregion
   }
}
