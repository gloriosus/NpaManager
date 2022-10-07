using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public partial class NpaKindRefDialog : Form {
      #region Constructors
      public NpaKindRefDialog() {
         InitializeComponent();
         DS = DsHelper.DS;
         bindingSrc.DataSource = DS;
         bindingSrc.DataMember = "NpaKindsRef";
      }
      #endregion

      #region Events
      /// <summary>
      /// OK
      /// </summary>
      private void btnOK_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.OK;
         this.Close();
      }

      /// <summary>
      /// Отмена
      /// </summary>
      private void btnCancel_Click(object sender, EventArgs e) {
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }
      #endregion
   }
}
