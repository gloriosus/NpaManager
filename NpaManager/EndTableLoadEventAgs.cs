using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NpaManager {
   public class EndTableLoadEventAgs : EventArgs {
      private INpaGrid npaGrid;

      public INpaGrid NpaGrid {
         get { return npaGrid; }
      }

      public EndTableLoadEventAgs(INpaGrid npaGrid) {
         this.npaGrid = npaGrid;
      }
   }
}
