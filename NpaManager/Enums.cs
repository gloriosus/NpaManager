using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NpaManager {
   /// <summary>
   /// Состояние элементов управленя для отображения данных в табличном виде
   /// </summary>
   public enum NpaGridState { 
      /// <summary>
      /// Стоп, не готов
      /// </summary>
      Red,
      /// <summary>
      /// Данные не сохранены, идет загрузка
      /// </summary>
      Yellow,
      /// <summary>
      /// Данные загружены и находятся в актуальном состоянии
      /// </summary>
      Green
   }
}
