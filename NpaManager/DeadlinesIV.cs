using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class DeadlinesIV : UserControl {
      #region Properties
      /// <summary>
      /// Дата представления проекта на юр. экспертизу
      /// </summary>
      public DateTime PlanDateLaw {
         get {
            if (planLawDateEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)planLawDateEdit.EditValue; }
         set { planLawDateEdit.EditValue = value; }
      }

      /// <summary>
      /// Дата регистрации в юр. управлении
      /// </summary>
      public DateTime RegDateLaw {
         get {
            if (regDateLawEdit.EditValue == null)
               return DateTime.Today;
            return (DateTime)regDateLawEdit.EditValue; }
         set { regDateLawEdit.EditValue = value; }
      }

      /// <summary>
      /// Срок представления проекта на юр. экспертизу
      /// </summary>
      public double SpinPlanDateLaw {
         get { return (double)spinPlanDateLaw.Value; }
         set { spinPlanDateLaw.Value = (decimal)value; }
      }
      #endregion

      #region Constructors
      public DeadlinesIV() {
         InitializeComponent();
         RecalcDeadlines();
      }
      #endregion

      #region Methods
      /// <summary>
      /// Пересчитать даты сроков
      /// </summary>
      private void RecalcDeadlines() {
         PlanDateLaw = RegDateLaw.AddDays(-SpinPlanDateLaw);
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрзука эл. управления
      /// </summary>
      private void DeadlinesIV_Load(object sender, EventArgs e) {
         RegDateLaw = DateTime.Today;
         RecalcDeadlines();
      }

      private void regDateLawEdit_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }

      private void numericPlanDateLaw_EditValueChanged(object sender, EventArgs e) {
         RecalcDeadlines();
      }
      #endregion
   }
}
