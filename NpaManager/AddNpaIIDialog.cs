using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   /// <summary>
   /// Диалог для добавления нового проекта НПА в таблицу раздела II
   /// </summary>
   public partial class AddNpaIIDialog : Form {
      #region Fields
      private NpaDataSet.NpaIIRow row;     // Строка добавляемая в таблицу
      #endregion

      #region Properties
      public decimal Index {
         get { return (decimal)indexSpinEdit.EditValue; }
         set { indexSpinEdit.EditValue = value; }
      }

      public string NpaState {
         get { return npaStateTextEdit.Text; }
         set { npaStateTextEdit.Text = value; }
      }

      public string NpaKind {
         get { return (string)NpaKindLookUpEdit.EditValue; }
         set { NpaKindLookUpEdit.EditValue = value; }
      }

      public string NpaName {
         get { return NpaNameMemoEdit.Text; }
         set { NpaNameMemoEdit.Text = value; }
      }

      public string Iogv {
         get { return (string)IogvLookUpEdit.EditValue; }
         set { IogvLookUpEdit.EditValue = value; }
      }

      public DateTime? PlanDateLaw {
         get { return (DateTime?)planDateLawDateEdit.EditValue; }
         set { planDateLawDateEdit.EditValue = value; }
      }

      public DateTime? PlanDateOther {
         get { return (DateTime?)planDateOtherDateEdit.EditValue; }
         set { planDateOtherDateEdit.EditValue = value; }
      }

      public DateTime? PlanDateAssembly {
         get { return (DateTime?)planDateAssemblyDateEdit.EditValue; }
         set { planDateAssemblyDateEdit.EditValue = value; }
      }

      public DateTime? PlanDateGov {
         get { return (DateTime?)planDateGovDateEdit.EditValue; }
         set { planDateGovDateEdit.EditValue = value; }
      }

      public string NpaNote {
         get { return NpaNoteMemoEdit.Text; }
         set { NpaNoteMemoEdit.Text = value; }
      }

      public string Status {
         get { return (string)StatusLookUpEdit.EditValue; }
         set { StatusLookUpEdit.EditValue = value; }
      }      
      #endregion

      #region Consructors
      public AddNpaIIDialog() {
         InitializeComponent();
         npaDataSet = DsHelper.DS;
         IogvBindingSource.DataSource = npaDataSet;
         IogvBindingSource.DataMember = "IogvRef";

         NpaKindbindingSource.DataSource = npaDataSet;
         NpaKindbindingSource.DataMember = "NpaKindsRef";

         StatusBindingSource.DataSource = npaDataSet;
         StatusBindingSource.DataMember = "NpaStatusRef";
      }

      public AddNpaIIDialog(NpaDataSet.NpaIIRow newRow):this() {
         this.row = newRow;
         LoadFromRow();
         InitDatePeriod();
      }
      #endregion

      #region Methods
      /// <summary>
      /// Загрузить из строки
      /// </summary>
      private void LoadFromRow() {
         if (!Convert.IsDBNull(row["Index"]))
            Index = row.Index;
         if (!row.IsNpaStateNull())
            NpaState = row.NpaState;
         if (!Convert.IsDBNull(row["NpaKind"]))
            NpaKind = row.NpaKind;
         if (!Convert.IsDBNull(row["NpaName"]))
            NpaName = row.NpaName;
         if (!Convert.IsDBNull(row["Iogv"]))
            Iogv = row.Iogv;
         if (!row.IsPlanDateLawNull())
            PlanDateLaw = row.PlanDateLaw;
         if (!row.IsPlanDateOtherNull())
            PlanDateOther = row.PlanDateOther;
         if (!row.IsPlanDateAssemblyNull())
            PlanDateAssembly = row.PlanDateAssembly;
         if (!row.IsPlanDateGovNull())
            PlanDateGov = row.PlanDateGov;
         if (!row.IsNpaNoteNull())
            NpaNote = row.NpaNote;
         if (!Convert.IsDBNull(row["Status"]))
            Status = row.Status;
      }

      /// <summary>
      /// Выгрузить в строку
      /// </summary>
      private bool LoadToRow() {
         row.Index = Index;
         if (NpaState != null)
            row.NpaState = NpaState;
         if (NpaKind != null)
            row.NpaKind = NpaKind;
         else {
            NpaKindLookUpEdit.Select();
            string msg = "'Вид проекта НПА:'\rПоле не может быть пустым!";
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         if (!string.IsNullOrWhiteSpace(NpaName))
            row.NpaName = NpaName;
         else {
            NpaNameMemoEdit.Select();
            string msg = "'Наименование проекта НПА:'\rПоле не может быть пустым!";
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         if (Iogv != null)
            row.Iogv = Iogv;
         else {
            IogvLookUpEdit.Select();
            string msg = "'Ответственный за подготовку проекта:'\rПоле не может быть пустым!";
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         if (PlanDateLaw != null)
             row.PlanDateLaw = (DateTime)PlanDateLaw;
         if (PlanDateOther != null)
            row.PlanDateOther = (DateTime)PlanDateOther;
         if (PlanDateAssembly != null)
            row.PlanDateAssembly = (DateTime)PlanDateAssembly;
         if (PlanDateGov != null)
            row.PlanDateGov = (DateTime)PlanDateGov;
         else {
            planDateGovDateEdit.Select();
            string msg = "'Дата внесения на рассмотрение Зак. Собрания'\rПоле не может быть пустым!";
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         if (NpaNote != null)
            row.NpaNote = NpaNote;
         else
            row.SetNpaNoteNull();
         if (Status != null)
            row.Status = Status;
         else {
            StatusLookUpEdit.Select();
            string msg = "'Статус НПА:'\rПоле не может быть пустым!";
            MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         return true;
      }

      /// <summary>
      /// Инициализировать мин. и макс. значения в зависимости от выбранного периода
      /// </summary>
      private void InitDatePeriod() {
         NpaDataSet.PeriodsRow periodRow = npaDataSet.Periods.FindByPeriodId(row.PeriodId);
         if (periodRow != null) {
            planDateLawDateEdit.Properties.MinValue = periodRow.DateFirst.AddDays(-50);
            planDateLawDateEdit.Properties.MaxValue = periodRow.DateEnd;

            planDateOtherDateEdit.Properties.MinValue = periodRow.DateFirst.AddDays(-50);
            planDateOtherDateEdit.Properties.MaxValue = periodRow.DateEnd;

            planDateAssemblyDateEdit.Properties.MinValue = periodRow.DateFirst.AddDays(-50);
            planDateAssemblyDateEdit.Properties.MaxValue = periodRow.DateEnd;

            planDateGovDateEdit.Properties.MinValue = periodRow.DateFirst.AddDays(-50);
            planDateGovDateEdit.Properties.MaxValue = periodRow.DateEnd;
         }
      }
      #endregion

      #region Events
      /// <summary>
      /// Загрузка диалога
      /// </summary>
      private void AddNpaIIDialog_Load(object sender, EventArgs e) {
      }

      /// <summary>
      /// Нажали кнопку Отмена
      /// </summary>
      private void btnCancel_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

      /// <summary>
      /// Нажали кнопку Сохранить
      /// </summary>
      private void btnOK_Click(object sender, EventArgs e) {
         bool ok = LoadToRow();
         if (ok) {
            this.DialogResult = DialogResult.OK;
            this.Close();
         }
      }
      #endregion

   }
}
