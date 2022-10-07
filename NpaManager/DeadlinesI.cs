using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class DeadlinesI : UserControl {
      #region Properties
      /// <summary>
      /// Дата представления проекта НПА на юридическую экспертизу
      /// </summary>
      public DateTime PlanDateLaw {
         get {
            if (planDateLawEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateLawEdit.EditValue;
         }
         set { planDateLawEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата передачи на финансово-экономическую экспертизу
      /// </summary>
      public DateTime PlanDateEcon {
         get {
            if (planDateEconEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateEconEdit.EditValue;
         }
         set { planDateEconEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата передачи на лингвистическую экспертизу
      /// </summary>
      public DateTime PlanDateLingv {
         get {
            if (planDateLingvEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateLingvEdit.EditValue;
         }
         set { planDateLingvEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата представления проекта НПА на рассмотрение заинтересованных комитетов Зак. собрания
      /// </summary>
      public DateTime PlanDateOrg {
         get {
            if (planDateOrgEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateOrgEdit.EditValue;
         }
         set { planDateOrgEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата рассмотрения на заседании правительства
      /// </summary>
      public DateTime PlanDateGov {
         get {
            if (planDateGovEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateGovEdit.EditValue;
         }
         set { planDateGovEdit.EditValue = value; }
      }

      /// <summary>
      /// Срок передачи на юридическую экспертизу
      /// </summary>
      public double SpinPlanDateLaw {
         get { return (double)spinPlanDateLaw.Value; }
         set { spinPlanDateLaw.Value = (decimal)value; }
      }

      /// <summary>
      /// Срок передачи на финансово-экономическую экспертизу
      /// </summary>
      public double SpinPlanDateEcon {
         get { return (double)spinPlanDateEcon.Value; }
         set { spinPlanDateEcon.Value = (decimal)value; }
      }

      /// <summary>
      /// Срок передачи на лингвистическую экспертизу
      /// </summary>
      public double SpinPlanDateLingv {
         get { return (double)spinPlanDateLingv.Value; }
         set { spinPlanDateLingv.Value = (decimal)value; }
      }

      /// <summary>
      /// Срок представления проекта НПА на рассмотрение заинтересованных комитетов Зак. собрания
      /// </summary>
      public double SpinPlanDateOrg {
         get { return (double)spinPlanDateOrg.Value; }
         set { spinPlanDateOrg.Value = (decimal)value; }
      }
      #endregion

      #region Constructors
      public DeadlinesI() {
         InitializeComponent();
      }
      #endregion

      #region Methods
      /// <summary>
      /// Пересчитать даты сроков
      /// </summary>
      private void RecalcDeadlines() {
         PlanDateOrg = PlanDateGov.AddDays(-SpinPlanDateOrg);
         PlanDateLingv = PlanDateOrg.AddDays(-SpinPlanDateLingv);
         PlanDateEcon = PlanDateLingv.AddDays(-SpinPlanDateEcon);
         PlanDateLaw = PlanDateEcon.AddDays(-SpinPlanDateLaw);
      }
      #endregion

      #region Events
      private void DeadlinesI_Load(object sender, EventArgs e) {
         PlanDateGov = DateTime.Today;
         RecalcDeadlines();
      }

      private void spinPlanDateLaw_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateEcon_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateLingv_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateOrg_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void planDateGovEdit_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }
      #endregion

   }
}
