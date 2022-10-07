using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace NpaManager {
   public partial class NpaGridBase : UserControl, INpaGrid, INotifyPropertyChanged {
      public event PropertyChangedEventHandler PropertyChanged;

      #region Fields
      private string tableName;
      private NpaGridState _state;  // Состояние (красный, желтый, зеленый)
      #endregion

      #region Properties
      public DataTable Tbl {
         get { return DS.Tables[tableName]; }
      }

      /// <summary>
      /// Автомат. подбор высоты строк
      /// </summary>
      public virtual bool RowAutoHeight { get; set; }

      public BindingSource BindingSrc {
         get { return bindingSrc; }
      }

      /// <summary>
      /// Имя табл. данных для отображения 
      /// </summary>
      public string TableName {
         get { return tableName; }
         set {
            tableName = value;
            bindingSrc.DataMember = tableName;
         }
      }

      /// <summary>
      /// Состояние по примеру сфетофора
      /// </summary>
      public NpaGridState State {
         get { return _state; }
         set {
            if (_state != value) {
               _state = value;
               OnPropertyChanged("State");
            }
         }
      }

      public virtual bool Editable { get; set; }
      #endregion

      #region Constructors
      public NpaGridBase() {
         InitializeComponent();
         _state = NpaGridState.Red;
         RowAutoHeight = false;
      }
      #endregion

      #region Methods
      /// <summary>
      /// Добавить новую строку
      /// </summary>
      public virtual void AddNewRow() {
      }

      /// <summary>
      /// Убрать выделение уже существующее выделение и выделить в гриде только теущую строку
      /// </summary>
      protected virtual void SelectOnlyCurrentRow(GridView gv) {
         if (bindingSrc.Current != null) {
            int[] selectedRows = gv.GetSelectedRows();
            foreach (var idx in selectedRows) {
               gv.UnselectRow(idx);
            }
            int rowHandle = gv.FindRow(bindingSrc.Current);
            gv.SelectRow(rowHandle);
         }
      }

      /// <summary>
      /// Найти позицию для вставки источник данных упорядоченный по полю Index
      /// </summary>
      protected virtual int FindNewPos(decimal newIndex) {
         DataSet ds = bindingSrc.DataSource as DataSet;
         DataTable tbl = ds.Tables[bindingSrc.DataMember];

         for (int i = 0; i < tbl.Rows.Count; i++) {
            DataRow drv = tbl.Rows[i];
            decimal index = (decimal)drv["Index"];
            if (newIndex < index) {
               return i;
            }
         }
         return bindingSrc.Count;
      }

      /// <summary>
      /// асчитать срок для текущей строки таблицы НПА
      /// </summary>
      public virtual void RecalcDateCurrent() {
         if (this.Editable) {
            if (BindingSrc.Current != null) {
               DataRowView drv = BindingSrc.Current as DataRowView;
               DataRow row = drv.Row;
               DsHelper.RecalcDateCurrent(row);
            }
         } else
            MessageBox.Show("Пересчет не возможен.");
      }

      /// <summary>
      /// Расчитать срок для всего выбранного раздела НПА
      /// </summary>
      public virtual void RecalcDatesAll() {
         if (this.Editable)
            if (BindingSrc.Current != null) {
               DataRowView drv = BindingSrc.Current as DataRowView;
               DataTable tbl = drv.Row.Table;
               DsHelper.RecalcDatesAll(tbl);
            } else
            MessageBox.Show("Пересчет не возможен.");
      }

      /// <summary>
      /// Очистить даты для выделенных строк
      /// </summary>
      public virtual void ClearSelectedDeadlines() {
      }

      /// <summary>
      /// Оповестить об изменении значения свойства
      /// </summary>
      /// <param name="propertyName">изменившееся свойство</param>
      protected virtual void OnPropertyChanged(string propertyName) {
         PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
         PropertyChangedEventHandler temp = PropertyChanged;
         if (temp != null)
            temp(this, e);
      }

      /// <summary>
      /// вернуть мин. из двух дат
      /// </summary>
      protected static DateTime Min(DateTime date1, DateTime date2) {
         if (date1 <= date2)
            return date1;
         return date2;
      }
      #endregion

      #region Events
      /// <summary>
      /// Изменились данные в источнике данных
      /// </summary>
      private void bindingSrc_ListChanged(object sender, ListChangedEventArgs e) {
         if (bindingSrc.DataMember != "") {
            if (e.ListChangedType == ListChangedType.Reset) {
               if (bindingSrc.Count > 0)
                  State = NpaGridState.Green;
               else
                  State = NpaGridState.Red;
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted) {
               State = NpaGridState.Yellow;
            }
         }
      }
      #endregion

   }
}
