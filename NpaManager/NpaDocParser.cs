using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Word = Microsoft.Office.Interop.Word;

namespace NpaManager {
   /// <summary>
   /// Парсер для работы с графиком проектов НПА в формате Word
   /// </summary>
   public class NpaDocParser : INpaDocParser {
      /// <summary>
      /// Загрузка данных из табл. Word завершена
      /// </summary>
      public event EventHandler<EndTableLoadEventAgs> EndTableLoad;

      #region Fields
      private Word.Application app;    // Приложение Word
      private Word.Document doc;       // файл doc
      private DateTime dateFirst;      // дата начала квартала
      private DateTime dateLast;       // дата окончания квартала
      private NpaDataSet ds;
      private object lockNpaKind;      // объект блокировки для справочника NpaKindsRef
      private object lockIogv;         // объект блокировки для справочника IogvRef
      #endregion

      #region Properties
      #endregion

      #region Constructors
      public NpaDocParser() {
         lockIogv = new object();
         lockNpaKind = new object();
         ds = DsHelper.DS;
      }
      #endregion

      #region Methods
      public void OpenDoc(string fileName, DateTime dateFirst, DateTime dateLast) {
         OpenDoc(fileName);
         this.dateFirst = dateFirst;
         this.dateLast = dateLast;
      }

      /// <summary>
      /// Открыть документ в формате Word
      /// </summary>
      private void OpenDoc(string fileName) {
         try {
            app = new Word.Application();
            object filename = fileName;
            object readOnly = true;
            doc = app.Documents.Open(ref filename, Type.Missing, ref readOnly);
            app.Visible = true;
         } catch (Exception ex) {
            Debug.WriteLine(ex.Message);
            throw ex;
         }
      }

      /// <summary>
      /// Закрыть документ Word
      /// </summary>
      public void CloseDoc() {
         try {
            if (app == null) return;

            object saveCahnges = Word.WdSaveOptions.wdSaveChanges;
            object originalFormat = Word.WdOriginalFormat.wdWordDocument;
            ((Word._Application)app).Quit(ref saveCahnges, ref originalFormat);
            app = null;
         } catch (Exception ex) {
            Debug.WriteLine(ex.Message);
         }
      }

      private string FormatCellValue(string cellValue) {
         cellValue = cellValue.Replace("\r", " ");
         cellValue = cellValue.Replace("\r", " ");
         cellValue = cellValue.Replace("   ", " ");
         cellValue = cellValue.Replace("  ", " ");
         cellValue = cellValue.Trim();
         return cellValue;
      }

      /// <summary>
      /// Вернать кол. полей в заголовке таблицы Word
      /// </summary>
      private int GetHeaderCellsCount(string tablename) {
         switch (tablename) {
            case "NpaI":
               return 17;
            case "NpaII":
               return 17;
            case "NpaIII":
               return 15;
            case "NpaIV":
               return 10;
         }
         return 17;
      }

      /// <summary>
      /// Распарсить таблицу Word'a в таблицу данных
      /// </summary>
      public void ParseTableAsync(INpaGrid npaGrid) {
         BackgroundWorker worker = new BackgroundWorker();
         worker.DoWork += worker_DoWork;
         worker.RunWorkerCompleted += worker_RunWorkerCompleted;
         worker.RunWorkerAsync(npaGrid);
         npaGrid.State = NpaGridState.Yellow;
      }

      /// <summary>
      /// </summary>
      /// <param name="npaGrid"></param>
      private NpaDataSet AsyncParseTable(string tableName) {
         int headerCellsCount = GetHeaderCellsCount(tableName);
         Word.Table tbl = GetWordTable(tableName);
         DataTable npa = DsHelper.DS.Tables[tableName];
         StringBuilder sb = new StringBuilder();

         //-- Клонировать дата сет и табл.
         NpaDataSet dsClone = npa.DataSet.Clone() as NpaDataSet;
         dsClone.Relations.Remove("IogvRef_NpaI");       // удалить ограничения
         dsClone.Relations.Remove("IogvRef_NpaII");
         dsClone.Relations.Remove("IogvRef_NpaIII");
         dsClone.Relations.Remove("IogvRef_NpaIV");
         //dsClone.Relations.Remove("NpaKindsRef_NpaII");
         //dsClone.Relations.Remove("NpaKindsRef_NpaIII");

         DataTable npaClone = dsClone.Tables[tableName];
         while(npaClone.Constraints.Count > 1)
            npaClone.Constraints.RemoveAt(1);

         //-- Сброс автоинкремента
         npaClone.Columns["Id"].AutoIncrementSeed = 1;
         npaClone.Columns["Id"].AutoIncrementStep = 1;
         npaClone.Columns["Id"].AutoIncrementSeed = -1;
         npaClone.Columns["Id"].AutoIncrementStep = -1;

         int rowIdx = 0;
         int colIdx = 1;
         Word.Cell cell = tbl.Cell(1, 1);
         int cellIdx = 1;
         do {
            if (cellIdx > headerCellsCount) {
               if (rowIdx != cell.RowIndex) {
                  string line = sb.ToString();
                  ParseNpaTableRow(npaClone, line);
                  sb.Remove(0, sb.Length);
               }

               string txt = cell.Range.Text;
               txt = txt.Replace("\a", "");
               sb.AppendFormat("|{0}", txt);

               rowIdx = cell.RowIndex;
               colIdx = cell.ColumnIndex;
            }
            cell = cell.Next;
            cellIdx++;
         } while (cell != null);
         string lastLine = sb.ToString();
         ParseNpaTableRow(npaClone, lastLine);
         return dsClone;
      }

      /// <summary>
      /// Вернуть таблицу ворд
      /// </summary>
      private Word.Table GetWordTable(string tableName) {
         Word.Table tbl = null;
         switch (tableName) {
            case "NpaI":
               tbl = doc.Tables[2];
               break;
            case "NpaII":
               tbl = doc.Tables[3];
               break;
            case "NpaIII":
               tbl = doc.Tables[4];
               break;
            case "NpaIV":
               tbl = doc.Tables[5];
               break;
         }
         return tbl;
      }

      /// <summary>
      /// Парсить строку из указанной тбл. Word в заданную табл. данных
      /// </summary>
      private void ParseNpaTableRow(DataTable tbl, string line) {
         switch (tbl.TableName) {
            case "NpaI":
               NpaDataSet.NpaIDataTable npaI = tbl as NpaDataSet.NpaIDataTable;
               ParseNpaITableRow(npaI, line);
               break;
            case "NpaII":
               NpaDataSet.NpaIIDataTable npaII = tbl as NpaDataSet.NpaIIDataTable;
               ParseNpaIITableRow(npaII, line);
               break;
            case "NpaIII":
               NpaDataSet.NpaIIIDataTable npaIII = tbl as NpaDataSet.NpaIIIDataTable;
               ParseNpaIIITableRow(npaIII, line);
               break;
            case "NpaIV":
               NpaDataSet.NpaIVDataTable npaIV = tbl as NpaDataSet.NpaIVDataTable;
               ParseNpaIVTableRow(npaIV, line);
               break;
         }
      }

      /// <summary>
      /// Распарсить строку табл. Word'a и добавить строку в таблицу данных
      /// </summary>
      private void ParseNpaITableRow(NpaDataSet.NpaIDataTable npa, string line) {
         string[] itemsArr = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
         List<string> items = new List<string>(itemsArr);
         if (items.Count < 5) return;
         ParseState(items);
         // убрать переводы коретки и пробелы вокруг текста
         items[1] = FormatCellValue(items[1]); // индекс
         items[2] = FormatCellValue(items[2]); // Название НПА
         items[3] = FormatCellValue(items[3]); // Структурное подразделение

         NpaDataSet.NpaIRow row = npa.NewNpaIRow();
         decimal index = Convert.ToDecimal(items[0], NumberFormatInfo.InvariantInfo);
         NpaDataSet.NpaIRow rowExists = GetNpaIRowByIndex(index);
         if (rowExists != null)
            row.Id = rowExists.Id;
         row.Index = index;
         row.NpaState = items[1];
         row.NpaName = items[2];
         NpaDataSet.IogvRefRow iogvRow = GetIogvRow( items[3]);
         row.Iogv = iogvRow.Iogv;
         if (items.Count == 6) {
            row.NpaNote = items[4];
            DateTime? dateGov = GetDateTime(items[5]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         if (items.Count == 9) {
            DateTime? dateLaw = GetDateTime(items[4]);
            if (dateLaw != null)
               row.PlanDateLaw = (DateTime)dateLaw;
            DateTime? dateEcon = GetDateTime(items[5]);
            if (dateEcon != null)
               row.PlanDateEcon = (DateTime)dateEcon;
            DateTime? dateLingv = GetDateTime(items[6]);
            if (dateLingv != null)
               row.PlanDateLingv = (DateTime)dateLingv;
            DateTime? dateOrg = GetDateTime(items[7]);
            if (dateOrg != null)
               row.PlanDateOrg = (DateTime)dateOrg;
            DateTime? dateGov = GetDateTime(items[8]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         npa.AddNpaIRow(row);
         // заполнить историю
         DateTime minDate = row.GetMinDate();
         row.UpdateHistory(minDate);
      }

      /// <summary>
      /// Распарсить строку табл. Word'a и добавить строку в таблицу данных
      /// </summary>
      private void ParseNpaIITableRow(NpaDataSet.NpaIIDataTable npa, string line) {
         string[] itemsArr = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
         List<string> items = new List<string>(itemsArr);
         if (items.Count < 5)
            return;
         ParseState(items);
         // убрать переводы коретки
         items[0] = FormatCellValue(items[0]); // индекс
         items[1] = FormatCellValue(items[1]); // cостояние
         items[2] = FormatCellValue(items[2]); // Вид НПА
         items[3] = FormatCellValue(items[3]); // Название НПА
         items[4] = FormatCellValue(items[4]); // Структурное подразделение

         NpaDataSet.NpaIIRow row = npa.NewNpaIIRow();
         decimal index = Convert.ToDecimal(items[0], NumberFormatInfo.InvariantInfo);
         NpaDataSet.NpaIIRow rowExists = GetNpaIIRowByIndex(index);
         if (rowExists != null)
            row.Id = rowExists.Id;
         row.Index = index;
         row.NpaState = items[1];
         NpaDataSet.NpaKindsRefRow npaKindRow = GetNpaKindRow(items[2]);
         row.NpaKind = npaKindRow.NpaKind;
         row.NpaName = items[3];
         NpaDataSet.IogvRefRow iogvRow = GetIogvRow(items[4]);
         row.Iogv = iogvRow.Iogv;
         if (items.Count == 7) {
            row.NpaNote = items[5];
            DateTime? dateGov = GetDateTime(items[6]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         if (items.Count == 9) {
            DateTime? dateLaw = GetDateTime(items[5]);
            if (dateLaw != null)
               row.PlanDateLaw = (DateTime)dateLaw;
            DateTime? dateAnother = GetDateTime(items[6]);
            if (dateAnother != null)
               row.PlanDateOther = (DateTime)dateAnother;
            DateTime? dateAssembly = GetDateTime(items[7]);
            if (dateAssembly != null)
               row.PlanDateAssembly = (DateTime)dateAssembly;
            DateTime? dateGov = GetDateTime(items[8]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         npa.AddNpaIIRow(row);
         // заполнить историю
         DateTime minDate = row.GetMinDate();
         row.UpdateHistory(minDate);
      }

      /// <summary>
      /// Распарсить строку табл. Word'a и добавить строку в таблицу данных
      /// </summary>
      private void ParseNpaIIITableRow(NpaDataSet.NpaIIIDataTable npa, string line) {
         string[] itemsArr = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
         List<string> items = new List<string>(itemsArr);
         if (items.Count < 5)
            return;
         ParseState(items);
         // убрать переводы коретки
         items[1] = FormatCellValue(items[1]); // индекс
         items[2] = FormatCellValue(items[2]); // Вид НПА
         items[3] = FormatCellValue(items[3]); // Название НПА
         items[4] = FormatCellValue(items[4]); // Структурное подразделение

         NpaDataSet.NpaIIIRow row = npa.NewNpaIIIRow();
         decimal index = Convert.ToDecimal(items[0], NumberFormatInfo.InvariantInfo);
         NpaDataSet.NpaIIIRow rowExists = GetNpaIIIRowByIndex(index);
         if (rowExists != null)
            row.Id = rowExists.Id;
         row.Index = index;
         row.NpaState = items[1];
         NpaDataSet.NpaKindsRefRow npaKindRow = GetNpaKindRow(items[2]);
         row.NpaKind = npaKindRow.NpaKind;
         row.NpaName = items[3];
         NpaDataSet.IogvRefRow iogvRow = GetIogvRow(items[4]);
         row.Iogv = iogvRow.Iogv;
         if (items.Count == 7) {
            row.NpaNote = items[5];
            DateTime? dateGov = GetDateTime(items[6]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         if (items.Count == 8) {
            DateTime? dateLaw = GetDateTime(items[5]);
            if (dateLaw != null)
               row.PlanDateLaw = (DateTime)dateLaw;
            DateTime? dateLingv = GetDateTime(items[6]);
            if (dateLingv != null)
               row.PlanDateLingv = (DateTime)dateLingv;
            DateTime? dateGov = GetDateTime(items[7]);
            if (dateGov != null)
               row.PlanDateGov = (DateTime)dateGov;
         }
         npa.AddNpaIIIRow(row);
         // заполнить историю
         DateTime minDate = row.GetMinDate();
         row.UpdateHistory(minDate);
      }

      /// <summary>
      /// Распарсить строку табл. Word'a и добавить строку в таблицу данных
      /// </summary>
      private void ParseNpaIVTableRow(NpaDataSet.NpaIVDataTable npa, string line) {
         string[] itemsArr = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
         List<string> items = new List<string>(itemsArr);
         if (items.Count < 4)
            return;
         ParseState(items);
         // убрать переводы коретки
         items[1] = FormatCellValue(items[1]); // индекс
         items[2] = FormatCellValue(items[2]); // Название НПА
         items[3] = FormatCellValue(items[3]); // Структурное подразделение

         NpaDataSet.NpaIVRow row = npa.NewNpaIVRow();
         decimal index = Convert.ToDecimal(items[0], NumberFormatInfo.InvariantInfo);
         NpaDataSet.NpaIVRow rowExists = GetNpaIVRowByIndex(index);
         if (rowExists != null)
            row.Id = rowExists.Id;
         row.Index = index;
         row.NpaState = items[1];
         row.NpaName = items[2];
         NpaDataSet.IogvRefRow iogvRow = GetIogvRow(items[3]);
         row.Iogv = iogvRow.Iogv;
         if (items.Count == 5) {
            row.NpaNote = items[4];
         }
         if (items.Count == 6) {
            DateTime? dateLaw = GetDateTime(items[4]);
            if (dateLaw != null)
               row.PlanDateLaw = (DateTime)dateLaw;
            else
               row.NpaNote = items[4];
            DateTime? dateReg = GetDateTime(items[5]);
            if (dateReg != null)
               row.RegDateLaw = (DateTime)dateReg;
         }
         npa.AddNpaIVRow(row);
         // заполнить историю
         DateTime minDate = row.GetMinDate();
         row.UpdateHistory(minDate);
      }

      /// <summary>
      /// Получить строку табл.NpaI для заданного индекса
      /// </summary>
      private NpaDataSet.NpaIRow GetNpaIRowByIndex(decimal value) {
         NpaDataSet.NpaIRow row = ds.NpaI.FindByIndex(value);
         return row;
      }

      /// <summary>
      /// Получить строку табл.NpaII для заданного индекса
      /// </summary>
      private NpaDataSet.NpaIIRow GetNpaIIRowByIndex(decimal value) {
         NpaDataSet.NpaIIRow row = ds.NpaII.FindByIndex(value);
         return row;
      }

      /// <summary>
      /// Получить строку табл.NpaIII для заданного индекса
      /// </summary>
      private NpaDataSet.NpaIIIRow GetNpaIIIRowByIndex(decimal value) {
         NpaDataSet.NpaIIIRow row = ds.NpaIII.FindByIndex(value);
         return row;
      }

      /// <summary>
      /// Получить строку табл.NpaIV для заданного индекса
      /// </summary>
      private NpaDataSet.NpaIVRow GetNpaIVRowByIndex(decimal value) {
         NpaDataSet.NpaIVRow row = ds.NpaIV.FindByIndex(value);
         return row;
      }

      /// <summary>
      /// Получить строку из справочника
      /// </summary>
      private NpaDataSet.IogvRefRow GetIogvRow(string value) {
         NpaDataSet.IogvRefRow row = null;
         lock (lockIogv) {
            row = ds.IogvRef.FindByIogv(value);
            if (row == null) {
               row = ds.IogvRef.AddIogvRefRow(value);
            }
         }
         return row;
      }

      /// <summary>
      /// Получить строку из справочника
      /// </summary>
      private NpaDataSet.NpaKindsRefRow GetNpaKindRow(string value) {
         NpaDataSet.NpaKindsRefRow row = null;
         lock (lockNpaKind) {
            row = ds.NpaKindsRef.FindByNpaKind(value);
            if (row == null) {
               row = ds.NpaKindsRef.AddNpaKindsRefRow(value);
            }
         }
         return row;
      }

      /// <summary>
      /// Выделить состояние (звездочки) из порядкового номера
      /// </summary>
      private void ParseState(List<string> items) {
         items.Insert(1, "");
         string str = items[0];
         str = str.Replace("\r", "");
         int idx = str.IndexOf('*');
         if (idx > 0) {
            items[0] = str.Substring(0, idx);
            items[1] = str.Substring(idx);
         }else
            items[0] = str;
      }

      /// <summary>
      /// Получить дату из строковой даты табл. Word
      /// </summary>
      private DateTime? GetDateTime(string item) {
         int year = dateFirst.Year;
         item = item.Trim();
         if (!item.EndsWith("."))
            item = item + ".";
         item = string.Format("{0}{1}", item, year);
         DateTime? dateTime = null;
         DateTime date;
         bool ok = DateTime.TryParse(item, out date);
         if (ok) {
            if (date > dateLast)         // для I кв. даты могут быть в предыдущем году
               date = date.AddYears(-1);
            dateTime = date;
         }
         return dateTime;
      }

      /// <summary>
      /// Оповестить подписчиков о наступлении события EndTableLoad
      /// </summary>
      protected virtual void OnEndTableLoad(EndTableLoadEventAgs e) {
         EventHandler<EndTableLoadEventAgs> temp = EndTableLoad;
         if (temp != null)
            temp(this, e);
      }
      #endregion

      #region Events
      /// <summary>
      /// Запустить асинхронную обработку
      /// </summary>
      private void worker_DoWork(object sender, DoWorkEventArgs e) {
         INpaGrid npaGrid = e.Argument as INpaGrid;
         NpaDataSet dsClone = AsyncParseTable(npaGrid.TableName);
         e.Result = new object[] { npaGrid, dsClone };
      }

      /// <summary>
      /// Асинхронная обработка завершена
      /// </summary>
      private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
         object[] objects = e.Result as object[];
         INpaGrid npaGrid = objects[0] as INpaGrid;
         NpaDataSet dsClone = objects[1] as NpaDataSet;
         if (e.Error != null) {
            Debug.WriteLine(e.Error.Message);
            npaGrid.State = NpaGridState.Red;
            return;
         }
         //-- Перебросить данные из клона в рабочий набор данных
         DataTable npaClone = dsClone.Tables[npaGrid.TableName];
         DataTableReader tblReader = new DataTableReader(npaClone);
         npaGrid.Tbl.Load(tblReader, LoadOption.Upsert);
         npaGrid.Tbl.DefaultView.Sort = "Index asc";
         //-- очисить ошибку
         foreach (DataRow r in npaGrid.Tbl.Rows) {
            if (r.HasErrors)
               r.ClearErrors();
         }

         //-- перебросить данные из клонов подчиненных табл в раб. набор данных
         foreach (DataRelation rel in npaClone.ChildRelations) {
            string childTblName = rel.ChildTable.TableName;
            tblReader = new DataTableReader(rel.ChildTable);
            DsHelper.DS.Tables[childTblName].Load(tblReader, LoadOption.Upsert);
         }

         npaGrid.State = NpaGridState.Green;
         EndTableLoadEventAgs args = new EndTableLoadEventAgs(npaGrid);
         OnEndTableLoad(args);
      }
      #endregion
   }
}
