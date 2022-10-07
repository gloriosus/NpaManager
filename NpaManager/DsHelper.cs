using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using NpaManager.NpaDataSetTableAdapters;

namespace NpaManager {
   public static class DsHelper {
      private static NpaDataSet ds = null;

      /// <summary>
      /// Набор данных приложения
      /// </summary>
      public static NpaDataSet DS {
         get { return ds; }
      }

      static DsHelper() {
         ds = new NpaDataSet();
         InitDefaultDateTime();
      }

      /// <summary>
      /// Установить для даты значения по умолчанию
      /// </summary>
      public static void InitDefaultDateTime() {
         ds.NpaID.DateDColumn.DefaultValue = DateTime.Today;
         ds.NpaIID.DateDColumn.DefaultValue = DateTime.Today;
         ds.NpaIIID.DateDColumn.DefaultValue = DateTime.Today;
         ds.NpaIVD.DateDColumn.DefaultValue = DateTime.Today;
      }

      /// <summary>
      /// Установить периодо по умолчанию
      /// </summary>
      private static void InitDefaultPeriod() {
         NpaDataSet.PeriodsRow periodRow = FindPeriodByDate(DateTime.Today);
      }

      /// <summary>
      /// Найти период на указанную дату
      /// </summary>
      private static NpaDataSet.PeriodsRow FindPeriodByDate(DateTime date) {
         NpaDataSet.PeriodsRow row = null;
         if (ds.Periods.Count > 0) {
            string filter = string.Format("DateFirst >={0} and DateLast <= {0}", date);
            DataView dw = new DataView(ds.Periods);
            dw.RowFilter = filter;
         }
         return row;
      }

      /// <summary>
      /// Загрузить данные по проектам НПА
      /// </summary>
      public static void FillNpaData(NpaDataSet.PeriodsRow currentPeriod) {
         string periodId = (currentPeriod != null) ? currentPeriod.PeriodId : "";

         try {
            // Справочник подразделений правительства ЕАО
            IogvRefTableAdapter iogvAdapter = new IogvRefTableAdapter();
            //int cnt = iogvAdapter.Fill(ds.IogvRef, periodId);


            // I Проекты постановлений правительства
            NpaITableAdapter npaIAdapter = new NpaITableAdapter();
            NpaIDTableAdapter npaIDAdapter = new NpaIDTableAdapter();
            ds.NpaID.Clear();

            int count = npaIAdapter.FillByPeriodId(ds.NpaI, periodId);
            string ids = ds.NpaI.GetIdList();
            int countd = npaIDAdapter.FillByIdList(ds.NpaID, ids);

            // II Проекты законов, постановлений зак. собрания
            NpaIITableAdapter npaIIAdapter = new NpaIITableAdapter();
            NpaIIDTableAdapter npaIIDAdapter = new NpaIIDTableAdapter();
            ds.NpaIID.Clear();

            count = npaIIAdapter.FillByPeriodId(ds.NpaII, periodId);
            ids = ds.NpaII.GetIdList();
            countd = npaIIDAdapter.FillByIdList(ds.NpaIID, ids);

            // III Проекты НПА губернатора, распоряжений правительства
            NpaIIITableAdapter npaIIIAdapter = new NpaIIITableAdapter();
            NpaIIIDTableAdapter npaIIIDAdapter = new NpaIIIDTableAdapter();
            ds.NpaIIID.Clear();

            count = npaIIIAdapter.FillByPeriodId(ds.NpaIII, periodId);
            ids = ds.NpaIII.GetIdList();
            countd = npaIIIDAdapter.FillByIdList(ds.NpaIIID, ids);

            // IV Проекты НПА ИОГВ
            NpaIVTableAdapter npaIVAdapter = new NpaIVTableAdapter();
            NpaIVDTableAdapter npaIVDAdapter = new NpaIVDTableAdapter();
            ds.NpaIVD.Clear();

            count = npaIVAdapter.FillByPeriodId(ds.NpaIV, periodId);
            ids = ds.NpaIV.GetIdList();
            countd = npaIVDAdapter.FillByIdList(ds.NpaIVD, ids);
         } catch (Exception ex) {
            Console.WriteLine(ex.Message);
         }
      }

      /// <summary>
      /// Загрузить данные по срокам прохождения этапов подготовки НПА
      /// </summary>
      /// <param name="periodId">период</param>
      public static int FillDeadlinesByPeriodid(string periodId) {
         int count  = 0;
         if (!string.IsNullOrEmpty(periodId)) {
            DeadlinesTableAdapter adapter = new DeadlinesTableAdapter();
            count = adapter.FillByPeriodId(ds.Deadlines, periodId);
         } else {
            ds.Deadlines.Clear();
            var row = ds.Deadlines.NewDeadlinesRow();
            row.PeriodId = periodId;
            ds.Deadlines.AddDeadlinesRow(row);
            count = 1;
         }
         return count;
      }

      /// <summary>
      /// Загрузить справочники из БД
      /// </summary>
      public static void FillRefData() {
         // Периоды
         PeriodsTableAdapter periodsAdapter = new PeriodsTableAdapter();
         int cnt = periodsAdapter.Fill(ds.Periods);

         // Справочник подразделений правительства ЕАО
         IogvRefTableAdapter iogvAdapter = new IogvRefTableAdapter();
         cnt += iogvAdapter.Fill(ds.IogvRef);

         // Справочник видов НПА
         NpaKindsRefTableAdapter npaKindAdapter = new NpaKindsRefTableAdapter();
         cnt += npaKindAdapter.Fill(ds.NpaKindsRef);

         // Справочник состояний
         NpaStatusRefTableAdapter npaStatusAdapter = new NpaStatusRefTableAdapter();
         cnt += npaStatusAdapter.Fill(ds.NpaStatusRef);
      }

      /// <summary>
      /// Инициализировать значения для периодов
      /// </summary>
      private static void InitQuartersData() {
         PeriodsTableAdapter periodsAdapter = new PeriodsTableAdapter();
         periodsAdapter.Fill(ds.Periods);

         //-- добавить и запомнить в БД
         //ds.Periods.AddPeriodsRow("IV квартал 2014 г", 2014, 4, new DateTime(2014, 10, 1), new DateTime(2014, 12, 31, 23, 59, 59));
         //ds.Periods.AddPeriodsRow("I квартал 2015 г", 2015, 1, new DateTime(2015, 1, 1), new DateTime(2015, 3, 31, 23, 59, 59));
         //ds.Periods.AddPeriodsRow("II квартал 2015 г", 2015, 2, new DateTime(2015, 4, 1), new DateTime(2015, 6, 30, 23, 59, 59));
         //ds.Periods.AddPeriodsRow("III квартал 2015 г", 2015, 3, new DateTime(2015, 7, 1), new DateTime(2015, 9, 30, 23, 59, 59));
         //ds.Periods.AddPeriodsRow("IV квартал 2015 г", 2015, 4, new DateTime(2015, 10, 1), new DateTime(2015, 12, 31, 23, 59, 59));
         //periodsAdapter.Update(ds.Periods);
      }

      /// <summary>
      /// Установить значения по умолчанию для периода в табл. проектов НПА
      /// </summary>
      public static void SetDefaultPeriod(NpaDataSet.PeriodsRow periodRow) {
         if (periodRow != null) {
            ds.NpaI.PeriodIdColumn.DefaultValue = periodRow.PeriodId;
            ds.NpaII.PeriodIdColumn.DefaultValue = periodRow.PeriodId;
            ds.NpaIII.PeriodIdColumn.DefaultValue = periodRow.PeriodId;
            ds.NpaIV.PeriodIdColumn.DefaultValue = periodRow.PeriodId;
         }
      }

      /// <summary>
      /// Получитить строку текущего периода из справочника периодов на текущую дату
      /// </summary>
      public static NpaDataSet.PeriodsRow GetCurrentPeriod() {
         DateTime today = DateTime.Today;
         var row = GetPeriod(today);
         return row;
      }

      /// <summary>
      /// Получить период на заданную дату
      /// </summary>
      /// <returns></returns>
      public static NpaDataSet.PeriodsRow GetPeriod(DateTime date) {
         var row = ds.Periods.FirstOrDefault(r => r.DateFirst <= date && r.DateEnd >= date);
         return row;
      }

      /// <summary>
      /// Обновить все данные в 
      /// </summary>
      public static int UpdateAll() {
         int count = 0;
         count += UpdatePeriods();
         count += UpdateIogvRef();
         count += UpdateNpaKinds();
         count += UpdateNpaTbl();
         return count;
      }

      /// <summary>
      /// Обновить данные в таблицах проектов НПА
      /// </summary>
      public static int UpdateNpaTbl() {
         int count = 0;
         count = UpdateIogvRef();  // Справочник подразделений правительства ЕАО
         count += UpdateNpaKinds();    // Справочник видов НПА
         count += UpdateNpaI();        // I Проекты постановлений правительства
         count += UpdateNpaII();       // II Проекты законов, постановлений зак. собрания
         count += UpdateNpaIII();      // III Проекты НПА губернатора, распоряжений правительства
         count += UpdateNpaIV();       // IV проекты НПА ИОГВ
         return count;
      }

      /// <summary>
      /// Обновить табл. периодов
      /// </summary>
      public static int UpdatePeriods() {
         int count = 0;
         DataTable tbl = ds.Periods.GetChanges();
         if (tbl != null) {
            PeriodsTableAdapter periodsAdapter = new PeriodsTableAdapter();
            count = periodsAdapter.Update(ds.Periods);
         }
         return count;
      }

      /// <summary>
      /// Получить список органов власти для выбранного периода
      /// </summary>
      public static List<string> GetCurrentIogv() {
         List<string> result = new List<string>();
         List<DataTable> tables = new List<DataTable>() { ds.NpaI, ds.NpaII, ds.NpaIII, ds.NpaIV };
         foreach(DataTable dt in tables){
            result.AddRange(dt.AsEnumerable().Select(i => i.Field<string>("Iogv")));
         }
         result = result.Distinct().ToList();
         result.Sort();
         return result;
      }

      /// <summary>
      /// Обновить справочник подразделений
      /// </summary>
      public static int UpdateIogvRef() {
         int count = 0;
         DataTable tbl = ds.IogvRef.GetChanges();
         if (tbl != null) {
            IogvRefTableAdapter iogvAdapter = new IogvRefTableAdapter();
            count = iogvAdapter.Update(ds.IogvRef);
         }
         return count;
      }

      /// <summary>
      /// Переименовать в таблицах NpaX значнеие поля Iogv. Новое
      /// </summary>
      /// <param name="existIogv">существующее значение</param>
      /// <param name="newIogv">новое значение. Должно находиться в справочнике IogvRef</param>
      public static void RenameNpaXIogv(string existIogv, string newIogv) {
         IogvRefTableAdapter iogvAdapter = new IogvRefTableAdapter();
         int cnt = iogvAdapter.RenameNpaIogv(newIogv, existIogv);
      }

      /// <summary>
      /// Подсчитать кол. записей в таблицах NpaX для заданного значения Iogv
      /// </summary>
      public static int TotalNpaByIogv(string iogv) {
         IogvRefTableAdapter iogvAdapter = new IogvRefTableAdapter();
         int count = (int)iogvAdapter.TotalNpaByIogv(iogv);
         return count;
      }

      /// <summary>
      /// Обновить справочник видов НПА
      /// </summary>
      public static int UpdateNpaKinds() {
         int count = 0;
         DataTable tbl = tbl = ds.NpaKindsRef.GetChanges();
         if (tbl != null) {
            NpaKindsRefTableAdapter npaKindAdapter = new NpaKindsRefTableAdapter();
            count += npaKindAdapter.Update(ds.NpaKindsRef);
         }
         return count;
      }

      /// <summary>
      /// Обновить I Проекты постановлений правительства
      /// </summary>
      public static int UpdateNpaI() {
         int count = 0;

         NpaITableAdapter npaIAdapter = new NpaITableAdapter();
         NpaIDTableAdapter npaIDAdapter = new NpaIDTableAdapter();

         try {
            count += npaIAdapter.Update(ds.NpaI);
         }catch(DBConcurrencyException ex) {
            ds.NpaI.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         try {
            count += npaIDAdapter.Update(ds.NpaID);
         } catch (DBConcurrencyException ex) {
            ds.NpaID.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         return count;
      }

      /// <summary>
      /// Обновить II Проекты законов, постановлений зак. собрания
      /// </summary>
      public static int UpdateNpaII() {
         int count = 0;

         NpaIITableAdapter npaIIAdapter = new NpaIITableAdapter();
         NpaIIDTableAdapter npaIIDAdapter = new NpaIIDTableAdapter();

         try {
            count += npaIIAdapter.Update(ds.NpaII);
         }catch(DBConcurrencyException ex) {
            ds.NpaII.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         try {
            count += npaIIDAdapter.Update(ds.NpaIID);
         } catch (DBConcurrencyException ex) {
            ds.NpaIID.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         return count;
      }

      /// <summary>
      /// Обновить III Проекты НПА губернатора, распоряжений правительства
      /// </summary>
      public static int UpdateNpaIII() {
         int count = 0;

         NpaIIITableAdapter npaIIIAdapter = new NpaIIITableAdapter();
         NpaIIIDTableAdapter npaIIIDAdapter = new NpaIIIDTableAdapter();

         try {
            count += npaIIIAdapter.Update(ds.NpaIII);
         }catch(DBConcurrencyException ex) {
            ds.NpaIII.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         try {
            count += npaIIIDAdapter.Update(ds.NpaIIID);
         } catch (DBConcurrencyException ex) {
            ds.NpaIIID.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         return count;
      }

      /// <summary>
      /// Обновить IV проекты НПА ИОГВ
      /// </summary>
      public static int UpdateNpaIV() {
         int count = 0;

         NpaIVTableAdapter npaIVAdapter = new NpaIVTableAdapter();
         NpaIVDTableAdapter npaIVDAdapter = new NpaIVDTableAdapter();

         try {
            count += npaIVAdapter.Update(ds.NpaIV);
         }catch(DBConcurrencyException ex) {
            ds.NpaIV.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }

         try {
         count += npaIVDAdapter.Update(ds.NpaIVD);
         } catch (DBConcurrencyException ex) {
            ds.NpaIVD.AcceptChanges();
            Debug.WriteLine(ex.Message);
         }


         return count;
      }

      /// <summary>
      /// Подсчитать кол. измененных элементов в NpaDataSet
      /// </summary>
      public static int GetModifiedCount() {
         int modifiedCount = 0;
         foreach (DataTable tblSrc in ds.Tables) {
            DataTable tbl = tblSrc.GetChanges();
            if (tbl != null)
               modifiedCount += tbl.Rows.Count;
         }
         return modifiedCount;
      }

      /// <summary>
      /// Подсчитать кол. проектов НПА привязанных к заданному кварталу
      /// </summary>
      public static int GetCountChildNpa(string periodId) {
         PeriodsTableAdapter adapter = new PeriodsTableAdapter();
         int count = (int)adapter.GetCountChildsNpa(periodId);
         return count;
      }

      /// <summary>
      /// Обновить данные по срокам подготовки проектов НПА
      /// </summary>
      public static void UpdateDeadlines() {
         if (ds.Deadlines.Count < 1)
            return;
         var row = ds.Deadlines[0];
         if (string.IsNullOrEmpty(row.PeriodId))
            return;
         DeadlinesTableAdapter adapter = new DeadlinesTableAdapter();
         adapter.Update(row);
      }

      /// <summary>
      /// Расчитать срок для текущей строки таблицы НПА
      /// </summary>
      public static void RecalcDateCurrent(DataRow row) {
         if (ds.Deadlines.Count < 1) {
            string periodId = row["PeriodId"].ToString();
            FillDeadlinesByPeriodid(periodId);
         }
         var rowDeadlines = ds.Deadlines[0];
         if (row is NpaDataSet.NpaIRow) {
            NpaDataSet.NpaIRow rowI = row as NpaDataSet.NpaIRow;
            rowI.RecalcDeadlines(rowDeadlines);
         } else if (row is NpaDataSet.NpaIIRow) {
            NpaDataSet.NpaIIRow rowII = row as NpaDataSet.NpaIIRow;
            rowII.RecalcDeadlines(rowDeadlines);
         } else if (row is NpaDataSet.NpaIIIRow) {
            NpaDataSet.NpaIIIRow rowIII = row as NpaDataSet.NpaIIIRow;
            rowIII.RecalcDeadlines(rowDeadlines);
         } else if (row is NpaDataSet.NpaIVRow) {
            NpaDataSet.NpaIVRow rowIV = row as NpaDataSet.NpaIVRow;
            rowIV.RecalcDeadlines(rowDeadlines);
         }
 
      }

      /// <summary>
      /// Расчитать срок для всего выбранного раздела НПА
      /// </summary>
      public static void RecalcDatesAll(DataTable tbl) {
         foreach (DataRow row in tbl.Rows) {
            RecalcDateCurrent(row);
         }
      }

      /// <summary>
      /// Клонировать структура набора данных
      /// </summary>
      /// <returns></returns>
      public static NpaDataSet CloneNpaDataSet() {
         NpaDataSet clone = (NpaDataSet)ds.Clone();
         clone.Relations.Remove("IogvRef_NpaI");       // удалить ограничения
         clone.Relations.Remove("IogvRef_NpaII");
         clone.Relations.Remove("IogvRef_NpaIII");
         clone.Relations.Remove("IogvRef_NpaIV");
         //clone.Relations.Remove("NpaKindsRef_NpaII");
         //clone.Relations.Remove("NpaKindsRef_NpaIII");

         foreach(DataTable tbl in clone.Tables) {
            if("NpaIII;NpaIV".IndexOf(tbl.TableName) < 0)
               continue;
            while(tbl.Constraints.Count > 1)
               tbl.Constraints.RemoveAt(1);
            //-- Сброс автоинкремента
            tbl.Columns["Id"].AutoIncrementSeed = 1;
            tbl.Columns["Id"].AutoIncrementStep = 1;
            tbl.Columns["Id"].AutoIncrementSeed = -1;
            tbl.Columns["Id"].AutoIncrementStep = -1;
         }

         //---  Копировать справочные данные
         DataTableReader reader = new DataTableReader(ds.NpaStatusRef);
         clone.NpaStatusRef.Load(reader);

         reader = new DataTableReader(ds.Periods);
         clone.Periods.Load(reader);

         reader = new DataTableReader(ds.NpaKindsRef);
         clone.NpaKindsRef.Load(reader);

         return clone;
      }

   }
}
