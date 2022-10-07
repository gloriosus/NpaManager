using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXUtils {
   /// <summary>
   /// Управление отображением хода выполнения длительной операции
   /// </summary>
   public class ProgressBarHelper {
      #region Fields
      private ProgressBarControl progress;
      private Control ctrl;
      #endregion

      #region Properties
      /// <summary>
      /// Прогресс бар
      /// </summary>
      public ProgressBarControl Progress {
         get { return progress; }
      }

      /// <summary>
      /// Ширина прогресс бара
      /// </summary>
      public int Width {
         get { return progress.Width; }
         set {
            if(progress.Width != value && value > 0)
               progress.Width = value;
         }
      }

      /// <summary>
      /// Высота прогресс бара
      /// </summary>
      public int Height {
         get { return progress.Height; }
         set {
            if(progress.Height != value && value > 0)
               progress.Height = value;
         }
      }

      public int Maximum {
         get { return progress.Properties.Maximum; }
         set { if(progress.Properties.Maximum != value && value > progress.Properties.Minimum)
               progress.Properties.Maximum = value;
             }
      }

      public int Minimum {
         get { return progress.Properties.Minimum; }
         set {
            if(progress.Properties.Minimum != value && value < progress.Properties.Maximum)
               progress.Properties.Minimum = value;
         }
      }

      public int Step {
         get { return progress.Properties.Step; }
         set { progress.Properties.Step = value; }
      }
      #endregion

      #region Ctors
      public ProgressBarHelper(Control ctrl) {
         if(ctrl == null)
            throw new ArgumentException("Не задан элемент упрвления отображающий прогресс бар");
         this.ctrl = ctrl;

         progress = new ProgressBarControl();
         progress.Width = 300;
         progress.Height = 24;
         progress.Properties.Step = 1;
         progress.Properties.Minimum = 0;
         progress.Properties.Maximum = 100;
         progress.Properties.PercentView = true;
         progress.Properties.ShowTitle = true;
         progress.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
         progress.Properties.LookAndFeel.SkinName = "VS2010";

      }
      #endregion

      #region Methods
      /// <summary>
      /// Отобразить прогресс бар
      /// </summary>
      public void ProgressBarOn() {
         int x = (ctrl.Width - Width) / 2;
         int y = (ctrl.Height - Height) / 2;
         progress.Location = new Point(x, y);
         ctrl.Controls.Add(progress);
         progress.BringToFront();
      }

      /// <summary>
      /// Скрыть прогресс бар
      /// </summary>
      public void ProgressBarOff() {
         int pos = ctrl.Controls.IndexOf(progress);
         if (pos >= 0)
            ctrl.Controls.Remove(progress);
      }

      /// <summary>
      /// Изменить значение прогесс бара
      /// </summary>
      public void PerformStep() {
         if(progress.InvokeRequired) {
            progress.Invoke((MethodInvoker)delegate {
               progress.PerformStep();
               progress.Update();
            });
         } else {
            progress.PerformStep();
            progress.Update();
         }
      }
      #endregion
   }
}
