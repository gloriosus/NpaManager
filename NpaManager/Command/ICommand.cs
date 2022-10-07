using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NpaManager.Command {
   public interface ICommand<T> {
      void Execute(T args);
   }

   public interface ICommand {
      void Execute();
   }
}
