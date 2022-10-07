using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using System.Diagnostics;

namespace NpaManager {
   public partial class NpaIIGridCtrl : NpaGridBase {
      #region Properties
      /// <summary>
      /// Автомат. подбор высоты строк
      /// </summary>
      public override bool RowAutoHeight {
         get {
            if (gridView1 != null)
               return gridView1.OptionsView.RowAutoHeight;
            else
               return base.RowAutoHeight;
         }
         set {
            if (gridView1 != null)
               gridView1.OptionsView.RowAutoHeight = value;
            else
               base.RowAutoHeight = value;
         }
      }

      /// <summary>
      /// Признак разрешения правки данных
      /// </summary>
      public override bool Editable {
         get { return !gridView1.OptionsBehavior.ReadOnly; }
         set { gridView1.OptionsBehavior.ReadOnly = !value; }
      }
      #endregion

      #region Constructors
      public NpaIIGridCtrl() {
         InitializeComponent();
         DS = DsHelper.DS;
         bindingSrc.DataSource = DS;

         iogvRefBindingSource.DataSource = DS;
         iogvRefBindingSource.DataMember = "IogvRef";

         npaStatusBindingSrc.DataSource = DS;
         npaStatusBindingSrc.DataMember = "NpaStatusRef";
      }
      #endregion

      #region Methods
      /// <summary>
      /// Добавить новую строку в таблицу
      /// </summary>
      public override void AddNewRow() {
         DataRowView drv = null;
         NpaDataSet.NpaIIRow row = null;
         decimal index = 0.0m;
         decimal delta = 1.0m;
         int pos = bindingSrc.Position;
         int newPos = pos + 1;
         if (pos >= 0) {
            drv = bindingSrc[pos] as DataRowView;
            NpaDataSet.NpaIIRow oldRow = drv.Row as NpaDataSet.NpaIIRow;
            index = oldRow.Index;

            if (pos < bindingSrc.Count - 1) {
               drv = bindingSrc[pos + 1] as DataRowView;
               NpaDataSet.NpaIIRow oldRow1 = drv.Row as NpaDataSet.NpaIIRow;
               decimal oldIndex1 = oldRow1.Index;
               while (oldIndex1 - index <= delta)
                  delta = delta / 10m;
            }
         }
         index += delta;

         row = DS.NpaII.NewNpaIIRow();
         row.Index = index;
         DialogResult dr = AddNewNpa(row);
         if (dr == DialogResult.OK) {
            newPos = FindNewPos(row.Index);
            DS.NpaII.Rows.InsertAt(row, newPos);
            UpdateHistory(row);
            bindingSrc.Position = newPos;
            SelectOnlyCurrentRow(gridView1);
         }
      }

      /// <summary>
      /// Очистить даты для выделенных строк
      /// </summary>
      public override void ClearSelectedDeadlines() {
         if (!Editable) {
            MessageBox.Show("Очистка выделенных строк не возможна.");
            return;
         }

         int[] selectedHandlers = gridView1.GetSelectedRows();
         foreach (int rowHandle in selectedHandlers) {
            DataRowView drv = gridView1.GetRow(rowHandle) as DataRowView;
            NpaDataSet.NpaIIRow row = drv.Row as NpaDataSet.NpaIIRow;
            row.ClearDeadlines();
         }
      }

      /// <summary>
      /// Установить ограничения для выбора дат
      /// </summary>
      private void SetDateTimeMaxValues(int RowHandle) {
         // PlanDateAssembly
         object val = gridView1.GetRowCellValue(RowHandle, colPlanDateGov);
         DateTime maxDateTime = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
         riDateEditAssembly.MaxValue = maxDateTime;
         // PlanDateOther
         val = gridView1.GetRowCellValue(RowHandle, colPlanDateAssembly);
         DateTime currtDateTime = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
         maxDateTime = Min(maxDateTime, currtDateTime);
         riDateEditOther.MaxValue = maxDateTime;
         // PlanDateLaw
         val = gridView1.GetRowCellValue(RowHandle, colPlanDateOther);
         currtDateTime = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
         maxDateTime = Min(maxDateTime, currtDateTime);
         riDateEditLaw.MaxValue = maxDateTime;
      }

      /// <summary>
      /// Добавить новый проект НПА
      /// </summary>
      private static DialogResult AddNewNpa(NpaDataSet.NpaIIRow row) {
         AddNpaIIDialog dialog = new AddNpaIIDialog(row);
         DialogResult dr = dialog.ShowDialog();
         return dr;
      }

      /// <summary>
      /// Обновить историю
      /// </summary>
      private void UpdateHistory(NpaDataSet.NpaIIRow row) {
         DateTime today = DateTime.Today;
         row.UpdateHistory(today);
         State = NpaGridState.Yellow;
         OnPropertyChanged("State");
      }
      #endregion

      #region Events
      /// <summary>
      /// Изменился список данных для привязки
      /// </summary>
      private void bindingSrc_ListChanged(object sender, ListChangedEventArgs e) {
         //-- Скроем/покажем поле "Ответственный за подготовку проекта"
         string filter = bindingSrc.Filter;
         colIogv.Visible = (string.IsNullOrEmpty(filter)) ? true : false;
      }

      /// <summary>
      /// Изменили значение в яцейке грида
      /// </summary>
      private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e) {
         object val = e.Value;
         bool needSetDateTime = false;
         if (e.Column == colPlanDateGov) {
            riDateEditAssembly.MaxValue = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
            needSetDateTime = true;
         } else if (e.Column == colPlanDateAssembly) {
            riDateEditOther.MaxValue = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
            needSetDateTime = true;
         } else if (e.Column == colPlanDateOther) {
            riDateEditLaw.MaxValue = (val is DateTime) ? (DateTime)val : DateTime.MaxValue;
            needSetDateTime = true;
         }
         if (needSetDateTime)
            SetDateTimeMaxValues(e.RowHandle);
      }

      /// <summary>
      /// Переместились на другую колонку
      /// </summary>
      private void gridView1_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e) {
         if (e.FocusedColumn == colIogv) {
            colIogv.ColumnEdit = riLookupIogv;
         }
         if (e.PrevFocusedColumn == colIogv) {
            colIogv.ColumnEdit = riMemoIogv;
         }
      }

      /// <summary>
      /// Переместились на другую строку
      /// </summary>
      private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
         if (e.FocusedRowHandle >= 0)
            SetDateTimeMaxValues(e.FocusedRowHandle);
      }

      /// <summary>
      /// Изменились данные в строке таблицы
      /// </summary>
      private void gridView1_RowUpdated(object sender, RowObjectEventArgs e) {
         DataRowView drv = e.Row as DataRowView;
         NpaDataSet.NpaIIRow row = drv.Row as NpaDataSet.NpaIIRow;
         if (row.RowState == DataRowState.Added) {
            UpdateHistory(row);
         } else if (row.RowState == DataRowState.Modified) {
            string[] detailFieldNames = row.GetDetailFiledNames();
            foreach (string fieldName in detailFieldNames) {
               // если изменено одно из полей табл. истории, то нужно обновить табл. истории
               if (!row[fieldName, DataRowVersion.Current].Equals(row[fieldName, DataRowVersion.Original])) {
                  UpdateHistory(row);
                  break;
               }
            }
         }
      }

      /// <summary>
      /// Настроить отображение значений данных в колонках грида
      /// </summary>
      private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e) {
         if (e.Column == colIndex && e.Value is decimal) {
            decimal index = (decimal)e.Value;
            e.DisplayText = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.###}", index);
         }
      }

      /// <summary>
      /// Изменение стиля строки в зависимости от состояния данных
      /// </summary>
      private void gridView1_RowStyle(object sender, RowStyleEventArgs e) {
         DataRow dr = gridView1.GetDataRow(e.RowHandle);
         if (dr != null) {
            if (dr.RowState == DataRowState.Added)          // Новая строка
               e.Appearance.ForeColor = Color.DarkBlue;
            else if (dr.RowState == DataRowState.Modified)  // Изменили данные
               e.Appearance.ForeColor = Color.DarkGreen;
         }
      }

      /// <summary>
      /// Нажали кнопку Insert
      /// </summary>
      private void gridView1_KeyUp(object sender, KeyEventArgs e) {
         if (e.KeyCode == Keys.Insert && !e.Alt && !e.Control && !e.Shift) {
            AddNewRow();
         }
      }

      private void gridView1_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e) {
         e.RelationName = "История изменений";
      }

      private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {
         e.RelationName = "NpaIID_NpaII";
      }

      private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) {
         e.RelationCount = 1;
      }

      private void gridView1_MasterRowGetLevelDefaultView(object sender, MasterRowGetLevelDefaultViewEventArgs e) {
         e.DefaultView = gridView2;
      }

      private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e) {
         e.IsEmpty = false;
      }
      #endregion
   }
}
