using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace NpaManager {
   public partial class IogvRefDialog : Form {
      #region Constructors
      public IogvRefDialog() {
         InitializeComponent();
         DS = DsHelper.DS;
         bindingSrc.DataSource = DS;
         bindingSrc.DataMember = "IogvRef";
      }
      #endregion

      #region Methods
      /// <summary>
      /// изменить существующее справочное значения в подчиненных таблицах на новое. Для DataSet
      /// </summary>
      private int UpdateDetailRows(string existVal, string newVal) {
         int cnt = 0;
         NpaDataSet.IogvRefRow parentRow = DsHelper.DS.IogvRef.FindByIogv(existVal);
         if (parentRow != null) {
            // перепривязать дочерние строки в табл. данных к существующему (из дупликатов) эл. справочника
            foreach (DataRow childRow in parentRow.GetChildRows("IogvRef_NpaI")) {
               childRow["Iogv"] = newVal;
               childRow.AcceptChanges();
               cnt++;
            }
            foreach (DataRow childRow in parentRow.GetChildRows("IogvRef_NpaII")) {
               childRow["Iogv"] = newVal;
               childRow.AcceptChanges();
               cnt++;
            }
            foreach (DataRow childRow in parentRow.GetChildRows("IogvRef_NpaIII")) {
               childRow["Iogv"] = newVal;
               childRow.AcceptChanges();
               cnt++;
            }
            foreach (DataRow childRow in parentRow.GetChildRows("IogvRef_NpaIV")) {
               childRow["Iogv"] = newVal;
               childRow.AcceptChanges();
               cnt++;
            }
         }
         return cnt;
      }
      #endregion

      #region Events
      /// <summary>
      /// Проверить правильность введенного значения ячейки грида
      /// </summary>
      private void gridView1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
         string existVal = gridView1.GetFocusedDisplayText();   // существующее значение справочника
         string newVal = (string)e.Value;                       // новое значение справочника
         int ExistsCount = DsHelper.TotalNpaByIogv(existVal);     
         int NewCount = DsHelper.TotalNpaByIogv(newVal);
         if (ExistsCount > 0 && NewCount > 0) {                 // Есть ссылки на существущее и новое значения. Т.е. выполняется слияние
            // обновить данные выбранные в DataSet
            int cnt = UpdateDetailRows(existVal, newVal);
            // поменять в БД существующее значение на новое
            DsHelper.RenameNpaXIogv(existVal, newVal);
         }

         NpaDataSet.IogvRefRow row = DsHelper.DS.IogvRef.FindByIogv(newVal);  // ищем в справочнике по новому значению
         if (row != null) {   // значит мы переименовали существующий элемент справочника к другому существ. элементу спр.
            // удалить из спровчника т.к. произошло слияние элементов справочника
            NpaDataSet.IogvRefRow parentRow = DsHelper.DS.IogvRef.FindByIogv(existVal);
            if (parentRow != null)
               parentRow.Delete();
         }

         string msg = string.Format("В табл. проектов НПА была замена в {0} стр.", ExistsCount);
         MessageBox.Show(msg, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      /// <summary>
      /// OK
      /// </summary>
      private void btnOK_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.OK;
         this.Close();
      }
      #endregion

   }
}
