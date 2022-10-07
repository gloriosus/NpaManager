using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace NpaManager {
   /// <summary>
   /// Разбор документа Word образца 2018 года 
   /// </summary>
   public class NpaDocParser2 : INpaDocParser {
      public event EventHandler<EndTableLoadEventAgs> EndTableLoad;

      #region Fields
      private NpaManager.NpaDataSet ds = DsHelper.DS;
      private RichEditControl rte;
      private DateTime dateFirst;      // дата начала квартала
      private DateTime dateLast;       // дата окончания квартала
      private object lockNpaKind;      // объект блокировки для справочника NpaKindsRef
      private object lockIogv;         // объект блокировки для справочника IogvRef
      #endregion

      #region Constructors
      public NpaDocParser2() {
         lockIogv = new object();
         lockNpaKind = new object();
         rte = new RichEditControl();
         ds = DsHelper.DS;
      }
      #endregion

      #region INpaDocParser
      /// <summary>
      /// Открыть документ Word
      /// </summary>
      public void OpenDoc(string fileName, DateTime dateFirst, DateTime dateLast) {
         this.dateFirst = dateFirst;
         this.dateLast = dateLast;
         rte.LoadDocument(fileName);
      }

      /// <summary>
      /// Закрыть документ
      /// </summary>
      public void CloseDoc() {
      }

      /// <summary>
      /// Распарсить таблицу Word'a в таблицу данных
      /// </summary>
      /// <param name="npaGrid"></param>
      public void ParseTableAsync(INpaGrid npaGrid) {
         NpaDataSet dsClone = DsHelper.CloneNpaDataSet();
         Task task;
         if(npaGrid.TableName == "NpaI") {
            task = Task.Factory.StartNew(() => ParseNpaI(npaGrid, dsClone));
         } else if(npaGrid.TableName == "NpaII")
            task = Task.Factory.StartNew(() => ParseNpaII(npaGrid, dsClone));
         else if(npaGrid.TableName == "NpaIII")
            task = Task.Factory.StartNew(() => ParseNpaIII(npaGrid, dsClone));
         else
            task = Task.Factory.StartNew(() => ParseNpaIV(npaGrid, dsClone));
         npaGrid.State = NpaGridState.Yellow;
         TaskScheduler sheduler = TaskScheduler.FromCurrentSynchronizationContext();
         task.ContinueWith((t) => ParseTableCompleted(npaGrid, dsClone), sheduler);
      }

      /// <summary>
      /// Переброс данных из клона в рабочий набор данных
      /// </summary>
      private void ParseTableCompleted(INpaGrid npaGrid, NpaDataSet dsClone) {
         //-- Перебросить данные из клона в рабочий набор данных
         DataTable npaClone = dsClone.Tables[npaGrid.TableName];
         DataTableReader tblReader = new DataTableReader(npaClone);
         npaGrid.Tbl.Load(tblReader, LoadOption.Upsert);
         npaGrid.Tbl.DefaultView.Sort = "Index asc";
         //-- очисить ошибку
         foreach(DataRow r in npaGrid.Tbl.Rows) {
            if(r.HasErrors)
               r.ClearErrors();
         }

         //-- перебросить данные из клонов подчиненных табл в раб. набор данных
         foreach(DataRelation rel in npaClone.ChildRelations) {
            string childTblName = rel.ChildTable.TableName;
            tblReader = new DataTableReader(rel.ChildTable);
            DsHelper.DS.Tables[childTblName].Load(tblReader, LoadOption.Upsert);
         }

         npaGrid.State = NpaGridState.Green;
         EndTableLoadEventAgs args = new EndTableLoadEventAgs(npaGrid);
         OnEndTableLoad(args);
      }

      /// <summary>
      /// Разобрать 1-ую ячейску строки (1, 2.,2***,4.* ...) на порядковый номер и признак состояния
      /// </summary>
      private static Tuple<decimal, string> ParseIndexState(string strIndex) {
         strIndex = strIndex.Replace("\r\n", "");
         string state = "";
         int pos = strIndex.IndexOf('*');
         if(pos > 0) {
            state = strIndex.Substring(pos);
            strIndex = strIndex.Replace(state, "");
         }
         strIndex = strIndex.Trim();
         if(strIndex.EndsWith("."))
            strIndex = strIndex.Substring(0, strIndex.Length - 1);
         decimal index = Convert.ToDecimal(strIndex);
         return new Tuple<decimal, string>(index, state);
      }

      /// <summary>
      /// II. Проекты постановлений правительства Еврейской автономной области
      /// </summary>
      private void ParseNpaI(INpaGrid npaGrid, NpaDataSet clone) {
         var tblI = rte.Document.Tables[2];            // II. Проекты постановлений правительства Еврейской автономной области
         for(int i = 2; i < tblI.Rows.Count; i++) {
            var tblRow = tblI.Rows[i];
            NpaDataSet.NpaIRow row = clone.NpaI.NewNpaIRow();

            string index = GetCellText(tblRow.Cells[0]);
            if(string.IsNullOrWhiteSpace(index)) {
               return;
            }
            Tuple<decimal, string> t = ParseIndexState(index);
            row.Index = t.Item1;
            row.NpaState = t.Item2;
            row.Iogv = GetCellText(tblRow.Cells[2]);
            row.NpaName = GetCellText(tblRow.Cells[1]);

            string strDate = "15 " + GetCellText(tblRow[3]);
            DateTime date = StringToDate(strDate, dateLast);
            row.PlanDateGov = date;

            DataRow iogvRow = DsHelper.DS.IogvRef.FindByIogv(row.Iogv);
            if(iogvRow == null) {
               DsHelper.DS.IogvRef.AddIogvRefRow(row.Iogv);
            }

            clone.NpaI.AddNpaIRow(row);
            // заполнить историю
            //DateTime minDate = row.GetMinDate();
            row.UpdateHistory(DateTime.Today);
         }
      }

      /// <summary>
      /// I. Проекты законов Еврейской автономной области
      /// </summary>
      private void ParseNpaII(INpaGrid npaGrid, NpaDataSet clone) {
         var tblI = rte.Document.Tables[1];            // I. Проекты законов Еврейской автономной области
         for(int i = 2; i < tblI.Rows.Count; i++) {
            var tblRow = tblI.Rows[i];
            NpaDataSet.NpaIIRow row = clone.NpaII.NewNpaIIRow();

            string index = GetCellText(tblRow.Cells[0]);
            if(string.IsNullOrWhiteSpace(index)) {
               return;
            }
            Tuple<decimal, string> t = ParseIndexState(index);
            row.Index = t.Item1;
            row.NpaState = t.Item2;
            row.Iogv = GetCellText(tblRow.Cells[2]);
            row.NpaName = GetCellText(tblRow.Cells[1]);

            string strDate = "15 " + GetCellText(tblRow[3]);
            DateTime date = StringToDate(strDate, dateLast);
            row.PlanDateGov = date;

            DataRow iogvRow = DsHelper.DS.IogvRef.FindByIogv(row.Iogv);
            if(iogvRow == null) {
               DsHelper.DS.IogvRef.AddIogvRefRow(row.Iogv);
            }

            clone.NpaII.AddNpaIIRow(row);
            // заполнить историю
            //DateTime minDate = row.GetMinDate();
            row.UpdateHistory(DateTime.Today);
         }
      }

      /// <summary>
      /// III. Проекты постановлений и распоряжений губернатора области, распоряжений правительства области
      /// </summary>
      private void ParseNpaIII(INpaGrid npaGrid, NpaDataSet clone) {
         var tblI = rte.Document.Tables[3];            // III. Проекты постановлений и распоряжений губернатора области, распоряжений правительства области
         for(int i = 2; i < tblI.Rows.Count; i++) {
            var tblRow = tblI.Rows[i];
            NpaDataSet.NpaIIIRow row = clone.NpaIII.NewNpaIIIRow();

            string index = GetCellText(tblRow.Cells[0]);
            if(string.IsNullOrWhiteSpace(index)) {
               return;
            }
            Tuple<decimal, string> t = ParseIndexState(index);
            row.Index = t.Item1;
            row.NpaState = t.Item2;
            row.NpaKind = GetCellText(tblRow.Cells[1]);
            row.Iogv = GetCellText(tblRow.Cells[3]).Trim();
            row.NpaName = GetCellText(tblRow.Cells[2]);

            string strDate = "15 " + GetCellText(tblRow[4]);
            DateTime date = StringToDate(strDate, dateLast);
            row.PlanDateGov = date;

            DataRow iogvRow = DsHelper.DS.IogvRef.FindByIogv(row.Iogv);
            if(iogvRow == null) {
               DsHelper.DS.IogvRef.AddIogvRefRow(row.Iogv);
            }

            clone.NpaIII.AddNpaIIIRow(row);
            // заполнить историю
            //DateTime minDate = row.GetMinDate();
            row.UpdateHistory(DateTime.Today);
         }
      }

      /// <summary>
      /// IV Проекты приказов органов исполнительной власти области, формируемых правительством Еврейской автономной области, носящие нормативный характер
      /// </summary>
      private void ParseNpaIV(INpaGrid npaGrid, NpaDataSet clone) {
         var tblI = rte.Document.Tables[4];            // Проекты приказов органов исполнительной власти области, формируемых правительством Еврейской автономной области, носящие нормативный характер
         for(int i = 2; i < tblI.Rows.Count; i++) {
            var tblRow = tblI.Rows[i];
            NpaDataSet.NpaIVRow row = clone.NpaIV.NewNpaIVRow();

            string index = GetCellText(tblRow.Cells[0]);
            if(string.IsNullOrWhiteSpace(index)) {
               return;
            }
            Tuple<decimal, string> t = ParseIndexState(index);
            row.Index = t.Item1;
            row.NpaState = t.Item2;
            row.Iogv = GetCellText(tblRow.Cells[2]);
            row.NpaName = GetCellText(tblRow.Cells[1]);

            string strDate = "15 " + GetCellText(tblRow[3]);
            DateTime date = StringToDate(strDate, dateLast);
            row.RegDateLaw = date;

            DataRow iogvRow = DsHelper.DS.IogvRef.FindByIogv(row.Iogv);
            if(iogvRow == null) {
               DsHelper.DS.IogvRef.AddIogvRefRow(row.Iogv);
            }

            clone.NpaIV.AddNpaIVRow(row);
            // заполнить историю
            //DateTime minDate = row.GetMinDate();
            row.UpdateHistory(DateTime.Today);
         }
      }

      /// <summary>
      /// Оповестить подписчиков о наступлении события EndTableLoad
      /// </summary>
      protected virtual void OnEndTableLoad(EndTableLoadEventAgs e) {
         EventHandler<EndTableLoadEventAgs> temp = EndTableLoad;
         if(temp != null)
            temp(this, e);
      }
      #endregion

      #region Methods
      /// <summary>
      /// Прочитать текст из ячейки таблицы
      /// </summary>
      private string GetCellText(TableCell cell) {
         var doc = rte.Document;
         string txt = doc.GetText(cell.Range);
         txt = (txt != null) ? txt.Trim(new char[] { '\r', '\n', ' ' }) : "";
         return txt;
      }

      /// <summary>
      /// Строку вида "Апрель 2018", "Май 2018" преобразовать в дату
      /// </summary>
      private DateTime StringToDate(string strDate, DateTime defaultDate) {
         DateTime date = defaultDate;
         string[] items = strDate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         if(items.Length == 3) {
            int day = Convert.ToInt32(items[0]);
            var dic = GetMonthDictionary();
            int month = dic[items[1]];
            int year = Convert.ToInt32(items[2]);
            date = new DateTime(year, month, day);
         }
         return date;
      }

      /// <summary>
      /// Создать словарь для отображения наименования месяца года в номер месяца
      /// </summary>
      private Dictionary<string, int> GetMonthDictionary() {
         Dictionary<string, int> dic = new Dictionary<string, int>();
         dic.Add("Январь", 1);
         dic.Add("январь", 1);
         dic.Add("Февраль", 2);
         dic.Add("февраль", 2);
         dic.Add("Март", 3);
         dic.Add("март", 3);
         dic.Add("Апрель", 4);
         dic.Add("апрель", 4);
         dic.Add("Май", 5);
         dic.Add("май", 5);
         dic.Add("Июнь", 6);
         dic.Add("июнь", 6);
         dic.Add("Июль", 7);
         dic.Add("июль", 7);
         dic.Add("Август", 8);
         dic.Add("август", 8);
         dic.Add("Сентябрь", 9);
         dic.Add("сентябрь", 9);
         dic.Add("Октябрь", 10);
         dic.Add("октябрь", 10);
         dic.Add("Ноябрь", 11);
         dic.Add("ноябрь", 11);
         dic.Add("Декабрь", 12);
         dic.Add("декабрь", 12);
         return dic;
      }
      #endregion
   }
}
