using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class DeadlinesIII : UserControl {
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
      /// Дата представления проекта НПА на лингвистическую экспертизу
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
      /// Дата регистрации НПА
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
      /// Срок представления проекта НПА на юридическую экспертизу
      /// </summary>
      public double SpinPlanDateLaw {
         get { return (double)spinPlanDateLaw.Value; }
         set { spinPlanDateLaw.Value = (decimal)value; }
      }

      /// <summary>
      /// Срок представления проекта НПА на лингвистическую экспертизу
      /// </summary>
      public double SpinPlanDateLingv {
         get { return (double)spinPlanDateLingv.Value; }
         set { spinPlanDateLingv.Value = (decimal)value; }
      }
      #endregion

      #region Constructors
      public DeadlinesIII() {
         InitializeComponent();
      }
      #endregion

      #region Methods
      /// <summary>
      /// Пересчитать даты сроков
      /// </summary>
      private void RecalcDeadlines() {
         PlanDateLingv = PlanDateGov.AddDays(-SpinPlanDateLingv);
         PlanDateLaw = PlanDateLingv.AddDays(-SpinPlanDateLaw);
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрзука эл. управления
      /// </summary>
      private void DeadlinesIII_Load(object sender, EventArgs e) {
         PlanDateGov = DateTime.Today;
         RecalcDeadlines();
      }
      #endregion

      private void spinPlanDateLaw_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateLingv_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void planDateGovEdit_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }
   }
}
