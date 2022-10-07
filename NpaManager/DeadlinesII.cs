using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class DeadlinesII : UserControl {
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
      /// Дата согласования проекта НПА с заинтересованными лицами
      /// </summary>
      public DateTime PlanDateOther {
         get {
            if (planDateOtherEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateOtherEdit.EditValue;
         }
         set { planDateOtherEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата представления проекта НПА на рассмотрение заинтересованных комитетов Зак. собрания
      /// </summary>
      public DateTime PlanDateAssembly {
         get {
            if (planDateAssemblyEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planDateAssemblyEdit.EditValue;
         }
         set { planDateAssemblyEdit.EditValue = value; }
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
      /// Срок согласования проекта НПА с заинтересованными лицами
      /// </summary>
      public double SpinPlanDateOther {
         get { return (double)spinPlanDateOther.Value; }
         set { spinPlanDateOther.Value = (decimal)value; }
      }

      /// <summary>
      /// Срок представления проекта НПА на рассмотрение заинтересованных комитетов Зак. собрания
      /// </summary>
      public double SpinPlanDateAssembly {
         get { return (double)spinPlanDateAssembly.Value; }
         set { spinPlanDateAssembly.Value = (decimal)value; }
      }
      #endregion

      #region Constructors
      public DeadlinesII() {
         InitializeComponent();
      }
      #endregion

      #region Methods
      /// <summary>
      /// Пересчитать даты сроков
      /// </summary>
      private void RecalcDeadlines() {
         PlanDateAssembly = PlanDateGov.AddDays(-SpinPlanDateAssembly);
         PlanDateOther = PlanDateAssembly.AddDays(-SpinPlanDateOther);
         PlanDateLaw = PlanDateOther.AddDays(-SpinPlanDateLaw);
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрзука эл. управления
      /// </summary>
      private void DeadlinesII_Load(object sender, EventArgs e) {
         PlanDateGov = DateTime.Today;
         RecalcDeadlines();
      }

      private void planDateGovEdit_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateAssembly_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateOther_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void spinPlanDateLaw_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }
      #endregion

   }
}
