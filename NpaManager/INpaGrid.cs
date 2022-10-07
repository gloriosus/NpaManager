using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace NpaManager {
   public interface INpaGrid {
      /// <summary>
      /// Таблица данных
      /// </summary>
      DataTable Tbl { get; }

      /// <summary>
      /// Автомат. подбор высоты строк
      /// </summary>
      bool RowAutoHeight { get; set; }

      /// <summary>
      /// Источник данных
      /// </summary>
      BindingSource BindingSrc { get; }

      /// <summary>
      /// Наименование таблицы в DS
      /// </summary>
      string TableName { get; set; }

      /// <summary>
      /// Состояние (красный, желтый, зелены по аналогии со светофором)
      /// </summary>
      NpaGridState State { get; set; }

      /// <summary>
      /// Признак разрешения правки данных
      /// </summary>
      bool Editable { get; set; }

      /// <summary>
      /// Добавить новую строку
      /// </summary>
      void AddNewRow();

      /// <summary>
      /// Расчитать срок для текущей строки таблицы НПА
      /// </summary>
      void RecalcDateCurrent();

      /// <summary>
      /// Расчитать срок для всего выбранного раздела НПА
      /// </summary>
      void RecalcDatesAll();

      /// <summary>
      /// Очистить даты для выделенных строк
      /// </summary>
      void ClearSelectedDeadlines();
   }
}
