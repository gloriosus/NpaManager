using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NpaManager {
   static class Program {
      /// <summary>
      /// Главная точка входа для приложения.
      /// </summary>
      [STAThread]
      static void Main() {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         var context = new AppContext(new Form1());
         Application.Run(context);
      }
   }
}
