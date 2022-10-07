using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NpaManager {
   /// <summary>
   /// Разбор документа Word во внутренний формат NpaManager
   /// </summary>
   public interface INpaDocParser {

      /// <summary>
      /// Открыть документ в формате Word
      /// </summary>
      void OpenDoc(string fileName, DateTime dateFirst, DateTime dateLast);

      /// <summary>
      /// Закрыть документ Word
      /// </summary>
      void CloseDoc();

      /// <summary>
      /// Распарсить таблицу Word'a в таблицу данных
      /// </summary>
      void ParseTableAsync(INpaGrid npaGrid);
      
      /// <summary>
      /// Загрузка данных из табл. Word завершена
      /// </summary>
      event EventHandler<EndTableLoadEventAgs> EndTableLoad;
   }
}
