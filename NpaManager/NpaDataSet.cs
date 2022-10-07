using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace NpaManager {
   public partial class NpaDataSet {
      partial class NpaStatusRefDataTable {
      }

      partial class NpaIIDDataTable {
      }

      partial class PeriodsDataTable {
      }

      partial class NpaIDataTable {
         /// <summary>
         /// Вернуть список всех Id в виде строки
         /// </summary>
         public string GetIdList() {
            string val = "";
            foreach(var row in this) {
               val = string.Format("{0}, {1}", val, row.Id);
            }
            if(val.Length > 0)
               val = val.Substring(1);
            return val;
         }

         /// <summary>
         /// Найти по заданному индексу
         /// </summary>
         public NpaIRow FindByIndex(decimal value) {
            NpaDataSet.NpaIRow row = (from r in this.AsEnumerable<NpaDataSet.NpaIRow>()
                                      where r.Index == value
                                      select r).SingleOrDefault();
            return row;
         }
      }

      partial class NpaIIDataTable {
         /// <summary>
         /// Вернуть список всех Id в виде строки
         /// </summary>
         public string GetIdList() {
            string val = "";
            foreach(var row in this) {
               val = string.Format("{0}, {1}", val, row.Id);
            }
            if(val.Length > 0)
               val = val.Substring(1);
            return val;
         }

         /// <summary>
         /// Найти по заданному индексу
         /// </summary>
         public NpaIIRow FindByIndex(decimal value) {
            NpaDataSet.NpaIIRow row = (from r in this.AsEnumerable<NpaDataSet.NpaIIRow>()
                                       where r.Index == value
                                       select r).SingleOrDefault();
            return row;
         }
      }

      partial class NpaIIIDataTable {
         /// <summary>
         /// Вернуть список всех Id в виде строки
         /// </summary>
         public string GetIdList() {
            string val = "";
            foreach(var row in this) {
               val = string.Format("{0}, {1}", val, row.Id);
            }
            if(val.Length > 0)
               val = val.Substring(1);
            return val;
         }

         /// <summary>
         /// Найти по заданному индексу
         /// </summary>
         public NpaIIIRow FindByIndex(decimal value) {
            NpaDataSet.NpaIIIRow row = (from r in this.AsEnumerable<NpaDataSet.NpaIIIRow>()
                                        where r.Index == value
                                        select r).SingleOrDefault();
            return row;
         }
      }

      partial class NpaIVDataTable {
         /// <summary>
         /// Вернуть список всех Id в виде строки
         /// </summary>
         public string GetIdList() {
            string val = "";
            foreach(var row in this) {
               val = string.Format("{0}, {1}", val, row.Id);
            }
            if(val.Length > 0)
               val = val.Substring(1);
            return val;
         }

         /// <summary>
         /// Найти по заданному индексу
         /// </summary>
         public NpaIVRow FindByIndex(decimal value) {
            NpaDataSet.NpaIVRow row = (from r in this.AsEnumerable<NpaDataSet.NpaIVRow>()
                                       where r.Index == value
                                       select r).SingleOrDefault();
            return row;
         }
      }

      public static DateTime Min(DateTime date1, DateTime date2) {
         if(date1 <= date2)
            return date1;
         return date2;
      }

      public partial class NpaIRow {
         /// <summary>
         /// Вернуть массив наименований полей табл истории
         /// </summary>
         public string[] GetDetailFiledNames() {
            string[] detailfieldNames = new string[] { "PlanDateLaw", "PlanDateEcon", "PlanDateLingv", "PlanDateOrg", "PlanDateGov", "NpaNote" };
            return detailfieldNames;
         }

         /// <summary>
         /// Вернуть мин. дату. Если дат нет, то будет возвращена текущая дата
         /// </summary>
         public DateTime GetMinDate() {
            DateTime minDateTime = DateTime.Today;
            if(!this.IsPlanDateLawNull())
               minDateTime = Min(minDateTime, this.PlanDateLaw);
            if(!this.IsPlanDateEconNull())
               minDateTime = Min(minDateTime, this.PlanDateEcon);
            if(!this.IsPlanDateLingvNull())
               minDateTime = Min(minDateTime, this.PlanDateLingv);
            if(!this.IsPlanDateOrgNull())
               minDateTime = Min(minDateTime, this.PlanDateOrg);
            if(!this.IsPlanDateGovNull())
               minDateTime = Min(minDateTime, this.PlanDateGov);
            return minDateTime;
         }

         /// <summary>
         /// Обновить историю на заданную дату из текущих значений
         /// </summary>
         public void UpdateHistory(DateTime dateUpdate) {
            NpaDataSet.NpaIDRow childRow = null;
            DataRow[] childrows = this.GetChildRows("NpaID_NpaI");
            if(childrows != null && childrows.Length > 0) {
               for(int i = 0; i < childrows.Length; i++) {
                  NpaDataSet.NpaIDRow childrow = childrows[i] as NpaDataSet.NpaIDRow;
                  if(childrow.DateD == dateUpdate) {
                     childRow = childrow;
                     break;
                  }
               }
            }
            if(childRow == null) {
               NpaDataSet.NpaIDDataTable tbl = ((NpaDataSet)this.Table.DataSet).NpaID;
               childRow = tbl.NewNpaIDRow();
               childRow.Id = this.Id;
               childRow.DateD = dateUpdate;
               tbl.AddNpaIDRow(childRow);
            }
            string[] fieldNames = GetDetailFiledNames();
            foreach(string fieldName in fieldNames) {  // запомним в истории
               childRow[fieldName] = this[fieldName];
            }
         }

         /// <summary>
         /// пересчитать сроки подготовки проекта НПА
         /// </summary>
         public void RecalcDeadlines(DeadlinesRow r, bool OnlyIsDBNull = true) {
            if(IsPlanDateGovNull())
               return;
            if(IsPlanDateOrgNull())
               PlanDateOrg = PlanDateGov.AddDays(-r.DeadlineOrgI);
            if(IsPlanDateLingvNull())
               PlanDateLingv = PlanDateOrg.AddDays(-r.DeadlineLingvI);
            if(IsPlanDateEconNull())
               PlanDateEcon = PlanDateLingv.AddDays(-r.DeadlineEconI);
            if(IsPlanDateLawNull())
               PlanDateLaw = PlanDateEcon.AddDays(-r.DeadlineLawI);
         }

         /// <summary>
         /// Очистить сроки этапов подготовки НПА
         /// </summary>
         public void ClearDeadlines() {
            SetPlanDateOrgNull();
            SetPlanDateLingvNull();
            SetPlanDateEconNull();
            SetPlanDateLawNull();
         }
      }

      public partial class NpaIIRow {
         /// <summary>
         /// Вернуть массив наименований полей табл истории
         /// </summary>
         public string[] GetDetailFiledNames() {
            string[] detailfieldNames = new string[] { "PlanDateLaw", "PlanDateOther", "PlanDateAssembly", "PlanDateGov", "NpaNote" };
            return detailfieldNames;
         }

         /// <summary>
         /// Вернуть мин. дату. Если дат нет, то будет возвращена текущая дата
         /// </summary>
         public DateTime GetMinDate() {
            DateTime minDateTime = DateTime.Today;
            if(!this.IsPlanDateLawNull())
               minDateTime = Min(minDateTime, this.PlanDateLaw);
            if(!this.IsPlanDateOtherNull())
               minDateTime = Min(minDateTime, this.PlanDateOther);
            if(!this.IsPlanDateAssemblyNull())
               minDateTime = Min(minDateTime, this.PlanDateAssembly);
            if(!this.IsPlanDateGovNull())
               minDateTime = Min(minDateTime, this.PlanDateGov);
            return minDateTime;
         }

         /// <summary>
         /// Обновить историю на заданную дату из текущих значений
         /// </summary>
         public void UpdateHistory(DateTime dateUpdate) {
            NpaDataSet.NpaIIDRow childRow = null;
            DataRow[] childrows = this.GetChildRows("NpaIID_NpaII");
            if(childrows != null && childrows.Length > 0) {
               for(int i = 0; i < childrows.Length; i++) {
                  NpaDataSet.NpaIIDRow childrow = childrows[i] as NpaDataSet.NpaIIDRow;
                  if(childrow.DateD == dateUpdate) {
                     childRow = childrow;
                     break;
                  }
               }
            }
            if(childRow == null) {
               NpaDataSet.NpaIIDDataTable tbl = ((NpaDataSet)this.Table.DataSet).NpaIID;
               childRow = tbl.NewNpaIIDRow();
               childRow.Id = this.Id;
               childRow.DateD = dateUpdate;
               tbl.AddNpaIIDRow(childRow);
            }
            string[] fieldNames = GetDetailFiledNames();
            foreach(string fieldName in fieldNames) {  // запомним в истории
               childRow[fieldName] = this[fieldName];
            }
         }

         /// <summary>
         /// Пересчитать даты сроков
         /// </summary>
         public void RecalcDeadlines(DeadlinesRow r) {
            if(IsPlanDateGovNull())
               return;
            if(IsPlanDateAssemblyNull())
               PlanDateAssembly = PlanDateGov.AddDays(-r.DeadlineAssemblyII);
            if(IsPlanDateOtherNull())
               PlanDateOther = PlanDateAssembly.AddDays(-r.DeadlineOtherII);
            if(IsPlanDateLawNull())
               PlanDateLaw = PlanDateOther.AddDays(-r.DeadlineLawII);
         }

         /// <summary>
         /// Очистить сроки этапов подготовки НПА
         /// </summary>
         public void ClearDeadlines() {
            SetPlanDateAssemblyNull();
            SetPlanDateOtherNull();
            SetPlanDateLawNull();
         }
      }

      public partial class NpaIIIRow {
         /// <summary>
         /// Вернуть массив наименований полей табл истории
         /// </summary>
         public string[] GetDetailFiledNames() {
            string[] detailfieldNames = new string[] { "PlanDateLaw", "PlanDateLingv", "PlanDateGov", "NpaNote" };
            return detailfieldNames;
         }

         /// <summary>
         /// Вернуть мин. дату. Если дат нет, то будет возвращена текущая дата
         /// </summary>
         public DateTime GetMinDate() {
            DateTime minDateTime = DateTime.Today;
            if(!this.IsPlanDateLawNull())
               minDateTime = Min(minDateTime, this.PlanDateLaw);
            if(!this.IsPlanDateLingvNull())
               minDateTime = Min(minDateTime, this.PlanDateLingv);
            if(!this.IsPlanDateGovNull())
               minDateTime = Min(minDateTime, this.PlanDateGov);
            return minDateTime;
         }

         /// <summary>
         /// Обновить историю на заданную дату из текущих значений
         /// </summary>
         public void UpdateHistory(DateTime dateUpdate) {
            NpaDataSet.NpaIIIDRow childRow = null;
            DataRow[] childrows = this.GetChildRows("NpaIIID_NpaIII");
            if(childrows != null && childrows.Length > 0) {
               for(int i = 0; i < childrows.Length; i++) {
                  NpaDataSet.NpaIIIDRow childrow = childrows[i] as NpaDataSet.NpaIIIDRow;
                  if(childrow.DateD == dateUpdate) {
                     childRow = childrow;
                     break;
                  }
               }
            }
            if(childRow == null) {
               NpaDataSet.NpaIIIDDataTable tbl = ((NpaDataSet)this.Table.DataSet).NpaIIID;
               childRow = tbl.NewNpaIIIDRow();
               childRow.Id = this.Id;
               childRow.DateD = dateUpdate;
               tbl.AddNpaIIIDRow(childRow);
            }
            string[] fieldNames = GetDetailFiledNames();
            foreach(string fieldName in fieldNames) {  // запомним в истории
               childRow[fieldName] = this[fieldName];
            }
         }

         /// <summary>
         /// Пересчитать даты сроков
         /// </summary>
         public void RecalcDeadlines(DeadlinesRow r) {
            if(IsPlanDateGovNull())
               return;
            if(IsPlanDateLingvNull())
               PlanDateLingv = PlanDateGov.AddDays(-r.DeadlineLingvIII);
            if(IsPlanDateLawNull())
               PlanDateLaw = PlanDateLingv.AddDays(-r.DeadlineLawIII);
         }

         /// <summary>
         /// Очистить сроки этапов подготовки НПА
         /// </summary>
         public void ClearDeadlines() {
            SetPlanDateLingvNull();
            SetPlanDateLawNull();
         }
      }

      public partial class NpaIVRow {
         /// <summary>
         /// Вернуть массив наименований полей табл истории
         /// </summary>
         public string[] GetDetailFiledNames() {
            string[] detailfieldNames = new string[] { "PlanDateLaw", "RegDateLaw", "NpaNote" };
            return detailfieldNames;
         }

         /// <summary>
         /// Вернуть мин. дату. Если дат нет, то будет возвращена текущая дата
         /// </summary>
         public DateTime GetMinDate() {
            DateTime minDateTime = DateTime.Today;
            if(!this.IsPlanDateLawNull())
               minDateTime = Min(minDateTime, this.PlanDateLaw);
            if(!this.IsRegDateLawNull())
               minDateTime = Min(minDateTime, this.RegDateLaw);
            return minDateTime;
         }

         /// <summary>
         /// Обновить историю на заданную дату из текущих значений
         /// </summary>
         public void UpdateHistory(DateTime dateUpdate) {
            NpaDataSet.NpaIVDRow childRow = null;
            DataRow[] childrows = this.GetChildRows("NpaIVD_NpaIV");
            if(childrows != null && childrows.Length > 0) {
               for(int i = 0; i < childrows.Length; i++) {
                  NpaDataSet.NpaIVDRow childrow = childrows[i] as NpaDataSet.NpaIVDRow;
                  if(childrow.DateD == dateUpdate) {
                     childRow = childrow;
                     break;
                  }
               }
            }
            if(childRow == null) {
               NpaDataSet.NpaIVDDataTable tbl = ((NpaDataSet)this.Table.DataSet).NpaIVD;
               childRow = tbl.NewNpaIVDRow();
               childRow.Id = this.Id;
               childRow.DateD = dateUpdate;
               tbl.AddNpaIVDRow(childRow);
            }
            string[] fieldNames = GetDetailFiledNames();
            foreach(string fieldName in fieldNames) {  // запомним в истории
               childRow[fieldName] = this[fieldName];
            }
         }

         /// <summary>
         /// Пересчитать даты сроков
         /// </summary>
         public void RecalcDeadlines(DeadlinesRow r) {
            if(IsRegDateLawNull())
               return;
            if(IsPlanDateLawNull())
               PlanDateLaw = RegDateLaw.AddDays(-r.DeadlineLawIV);
         }

         /// <summary>
         /// Очистить сроки этапов подготовки НПА
         /// </summary>
         public void ClearDeadlines() {
            SetPlanDateLawNull();
         }
      }

   }
}

namespace NpaManager.NpaDataSetTableAdapters {
   partial class PeriodsTableAdapter {
   }

   partial class IogvRefTableAdapter {
      /// <summary>
      /// Заполнить табл. данных по списку указанных Iogv
      /// </summary>
      /// <param name="table"></param>
      /// <param name="iogvs">строка вида "1, 2, 3"</param>
      /// <returns>кол. выбранных из БД записей</returns>
      public int FillByIogvList(NpaDataSet.IogvRefDataTable table, string iogvs) {
         int count = 0;
         if (iogvs != null && iogvs.Length > 0) {
            string sql = string.Format("Select Iogv IogvRef Where Iogv in ({0})", iogvs);
            SqlCommand cmd = new SqlCommand(sql, Connection);
            Adapter.SelectCommand = cmd;
            if (ClearBeforeFill == true) {
               table.Clear();
            }
            count = Adapter.Fill(table);
         }
         return count;
      }
   }

   partial class NpaIITableAdapter {
   }

   public partial class NpaITableAdapter {
   }

   public partial class NpaIDTableAdapter {
      /// <summary>
      /// Заполнить табл. данных по списку указанных Id
      /// </summary>
      /// <param name="table"></param>
      /// <param name="ids">строка вида "1, 2, 3"</param>
      /// <returns>кол. выбранных из БД записей</returns>
      public int FillByIdList(NpaDataSet.NpaIDDataTable table, string ids) {
         int count = 0;
         if (ids != null && ids.Length > 0) {
            string sql = string.Format("Select Id, DateD, PlanDateLaw,PlanDateEcon, PlanDateLingv, PlanDateOrg, PlanDateGov, NpaNote From NpaID Where Id in ({0})", ids);
            SqlCommand cmd = new SqlCommand(sql, Connection);
            Adapter.SelectCommand = cmd;
            if (ClearBeforeFill == true) {
               table.Clear();
            }
            count = Adapter.Fill(table);
         }
         return count;
      }
   }

   public partial class NpaIIDTableAdapter {
      /// <summary>
      /// Заполнить табл. данных по списку указанных Id
      /// </summary>
      /// <param name="table"></param>
      /// <param name="ids">строка вида "1, 2, 3"</param>
      /// <returns>кол. выбранных из БД записей</returns>
      public int FillByIdList(NpaDataSet.NpaIIDDataTable table, string ids) {
         int count = 0;
         if (ids != null && ids.Length > 0) {
            string sql = string.Format("Select Id, DateD, PlanDateLaw, PlanDateOther, PlanDateAssembly,PlanDateGov, NpaNote From NpaIID Where Id in ({0})", ids);
            SqlCommand cmd = new SqlCommand(sql, Connection);
            Adapter.SelectCommand = cmd;
            if (ClearBeforeFill == true) {
               table.Clear();
            }
            count = Adapter.Fill(table);
         }
         return count;
      }
   }

   public partial class NpaIIIDTableAdapter {
      /// <summary>
      /// Заполнить табл. данных по списку указанных Id
      /// </summary>
      /// <param name="table"></param>
      /// <param name="ids">строка вида "1, 2, 3"</param>
      /// <returns>кол. выбранных из БД записей</returns>
      public int FillByIdList(NpaDataSet.NpaIIIDDataTable table, string ids) {
         int count = 0;
         if (ids != null && ids.Length > 0) {
            string sql = string.Format("Select Id, DateD, PlanDateLaw, PlanDateLingv, PlanDateGov, NpaNote From NpaIIID Where Id in ({0})", ids);
            SqlCommand cmd = new SqlCommand(sql, Connection);
            Adapter.SelectCommand = cmd;
            if (ClearBeforeFill == true) {
               table.Clear();
            }
            count = Adapter.Fill(table);
         }
         return count;
      }
   }

   public partial class NpaIVDTableAdapter {
      /// <summary>
      /// Заполнить табл. данных по списку указанных Id
      /// </summary>
      /// <param name="table"></param>
      /// <param name="ids">строка вида "1, 2, 3"</param>
      /// <returns>кол. выбранных из БД записей</returns>
      public int FillByIdList(NpaDataSet.NpaIVDDataTable table, string ids) {
         int count = 0;
         if (ids != null && ids.Length > 0) {
            string sql = string.Format("Select Id, DateD, PlanDatelaw, RegDateLaw, NpaNote From NpaIVD Where Id in ({0})", ids);
            SqlCommand cmd = new SqlCommand(sql, Connection);
            Adapter.SelectCommand = cmd;
            if (ClearBeforeFill == true) {
               table.Clear();
            }
            count = Adapter.Fill(table);
         }
         return count;
      }
   }

}

