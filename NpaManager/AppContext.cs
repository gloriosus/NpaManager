using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NpaManager {
   public class AppContext : ApplicationContext {
      public static AppContext CurrentContext;

      public AppContext(Form mainForm) : base(mainForm) {
         CurrentContext = this;
      }
   }
}
