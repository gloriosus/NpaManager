using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraWaitForm;
using DXUtils;

namespace NpaManager {
   /// <summary>
   /// Экспорт НПА в документ Word
   /// </summary>
   public class ExportToWord {
      #region Fields
      private RichEditControl rte;
      private string filename;         // Имя файла .docx
      NpaDataSet.PeriodsRow period;
      private NpaDataSet ds;
      private int version;
      private Dictionary<int, string> monthDictionary;
      private ProgressBarHelper pg;
      #endregion

      #region Constructors
      public ExportToWord(string templateName, string filename, NpaDataSet.PeriodsRow period) {
         this.filename = filename;
         this.period = period;
         rte = new RichEditControl();
         rte.LoadDocumentTemplate(templateName, DocumentFormat.OpenXml);
         ds = DsHelper.DS;
         version = (filename.IndexOf("v2") < 0) ? 1 : 2;
         monthDictionary = new Dictionary<int, string>() {
            { 1, "Январь" }, { 2, "Февраль" }, { 3, "Март"}, { 4, "Апрель"}, { 5, "Май"}, { 6, "Июнь"},
            { 7, "Июль"}, { 8, "Август"}, { 9, "Сентябрь"}, { 10, "Октябрь"}, { 11,"Ноябрь"}, { 12,"Декабрь"}
         };

         pg = new ProgressBarHelper(AppContext.CurrentContext.MainForm);
      }
      #endregion

      #region Methods
      /// <summary>
      /// Закрыть документ Word
      /// </summary>
      public void CloseDoc() {
         rte.Document.SaveDocument(filename, DocumentFormat.OpenXml);
      }

      public void DoIt() {
         pg.Maximum = ds.NpaI.Count + ds.NpaII.Count + ds.NpaIII.Count + ds.NpaIV.Count;
         pg.ProgressBarOn();
         WriteCurrentDate();  // Записать текущую дату
         if(version == 1) {
            //WriteNpaI();         // Записать данные в табл. I
            //WriteNpaII();        // Записать данные в табл. II
            //WriteNpaIII();       // Записать данные в табл. III
            //WriteNpaIV();        // Записать данные в табл. IV
         } else if(version == 2) {
            WriteNpa2I();
            WriteNpa2II();
            WriteNpa2III();
            WriteNpa2IV();
         }
         pg.ProgressBarOff();
      }

      /// <summary>
      /// Записать текущую дату в табл. 1
      /// </summary>
      private string WriteCurrentDate() {
         string currentDate = GetCurrentDateStr();
         var range = rte.Document.Tables[0].Rows[1].Cells[0].Range;
         rte.Document.Delete(range);
         rte.Document.InsertText(range.Start, currentDate);
         return currentDate;
      }

      #region Version 1
      /// <summary>
      /// Записать данные в тбл. I Проекты постановлений правительства
      /// </summary>
      private void WriteNpaI() {
         Table tbl = rte.Document.Tables[1];
         foreach(var row in ds.NpaI) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            var range = tblRow.Range;
            CharacterProperties cp = rte.Document.BeginUpdateCharacters(range);
            cp.Bold = false;
            rte.Document.EndUpdateCharacters(cp);

            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);
            //cell.Range.Font.Bold = 0;

            cell = tblRow.Cells[1];      // Наименование проекта постановления
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[2];      // Подразделение
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            cell = tblRow.Cells[3];         // дата юр экспертизы или примечание
            if(!row.IsNpaNoteNull()) {         // Примечание не пустое
               if(tblRow.Cells.Count == 8) {
                  tbl.MergeCells(tblRow[3], tblRow[7]);
               }
               rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaNote);
            } else {                            // Примечание пустое
               if(tblRow.Cells.Count == 4) {   // Требуется разбить последнюю ячейку 4 на четыре ячейки
                  tblRow.Cells.Last.Split(1, 4);
               }
               if(!row.IsPlanDateLawNull()) {
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLaw.ToString("dd.MM"));
               }

               if(!row.IsPlanDateEconNull()) {
                  cell = tblRow.Cells[4];      // Экономисты
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateEcon.ToString("dd.MM"));
               }

               if(!row.IsPlanDateLingvNull()) {
                  cell = tblRow.Cells[5];      // Лингвисты
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLingv.ToString("dd.MM"));
               }

               if(!row.IsPlanDateOrgNull()) {
                  cell = tblRow.Cells[6];      // орг. управление
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateOrg.ToString("dd.MM"));
               }
            }

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells[7];      // Дата рассмотрения на заседании правительства
               rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateGov.ToString("dd.MM"));
            }
         }
      }

      /// <summary>
      /// Записать данные в тбл. II. Проекты законов области, постановлений Законодательного Собрания области
      /// </summary>
      private void WriteNpaII() {
         Table tbl = rte.Document.Tables[2];
         foreach(var row in ds.NpaII) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];      // Вид нормативно правового акта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaKind);

            cell = tblRow.Cells[2];      // Наименование проекта постановления
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[3];      // Подразделение
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            cell = tblRow.Cells[4];         // дата юр экспертизы или примечание
            if(!row.IsNpaNoteNull()) {         // Примечание не пустое
               if(tblRow.Cells.Count == 8) {
                  tbl.MergeCells(tblRow[4], tblRow[7]);
               }
               rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaNote);
            } else {                            // Примечание пустое
               if(tblRow.Cells.Count == 5) {   // Требуется разбит ячейку 4 на три ячейки
                  tblRow.Cells.Last.Split(1, 4);
               }
               if(!row.IsPlanDateLawNull()) {
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLaw.ToString("dd.MM"));
               }

               if(!row.IsPlanDateOtherNull()) {
                  cell = tblRow.Cells[5];      // Заинтересованные лица
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateOther.ToString("dd.MM"));
               }

               if(!row.IsPlanDateAssemblyNull()) {
                  cell = tblRow.Cells[6];      // комитет зак. собрания
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateAssembly.ToString("dd.MM"));
               }
            }

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells.Last;      // Дата рассмотрения на заседании правительства
               rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateGov.ToString("dd.MM"));
            }
         }
      }

      /// <summary>
      /// Записать данные в тбл. III
      /// </summary>
      private void WriteNpaIII() {
         Table tbl = rte.Document.Tables[3];
         foreach(var row in ds.NpaIII) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells.First;      // № п.п.
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];      // Вид нормативно правового акта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaKind);

            cell = tblRow.Cells[2];      // Наименование проекта постановления
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[3];      // Подразделение
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            cell = tblRow.Cells[4];      // дата юр экспертизы или примечание
            if(!row.IsNpaNoteNull()) {  // Примечание не пустое
               if(tblRow.Cells.Count == 7) {
                  tbl.MergeCells(tblRow[4], tblRow[6]);
               }
               rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaNote);
            } else {                            // Примечание пустое
               if(tblRow.Cells.Count == 5) {   // Требуется разбит ячейку 4 на две ячейки
                  cell.Split(1, 3);
               }
               if(!row.IsPlanDateLawNull()) {
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLaw.ToString("dd.MM"));
               }

               if(!row.IsPlanDateLingvNull()) {
                  cell = tblRow.Cells[5];      // Лингвистическая экспертиза
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLingv.ToString("dd.MM"));
               }
            }

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells.Last;      // Дата рассмотрения на заседании правительства
               rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateGov.ToString("dd.MM"));
            }
         }
      }

      /// <summary>
      /// Записать данные в тбл. IV
      /// </summary>
      private void WriteNpaIV() {
         Table tbl = rte.Document.Tables[4];
         foreach(var row in ds.NpaIV) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];      // Наименование проекта постановления
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[2];      // Подразделение
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);


            cell = tblRow.Cells[3];         // дата юр экспертизы или примечание
            if(!row.IsNpaNoteNull()) {         // Примечание не пустое
               rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaNote);
            } else {                            // Примечание пустое
               if(!row.IsPlanDateLawNull()) {
                  rte.Document.InsertSingleLineText(cell.Range.Start, row.PlanDateLaw.ToString("dd.MM"));
               }
            }

            if(!row.IsRegDateLawNull()) {
               cell = tblRow.Cells.Last;      // Дата регистрации в юр. управлении
               rte.Document.InsertSingleLineText(cell.Range.Start, row.RegDateLaw.ToString("dd.MM"));
            }
         }
      }
      #endregion

      #region Version 2
      /// <summary>
      /// Записать данные в тбл. I. Проекты законов области, постановлений Законодательного Собрания области
      /// </summary>
      private void WriteNpa2I() {
         Table tbl = rte.Document.Tables[1];
         foreach(var row in ds.NpaII) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            var range = tblRow.Range;
            CharacterProperties cp = rte.Document.BeginUpdateCharacters(range);
            cp.Bold = false;
            rte.Document.EndUpdateCharacters(cp);

            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];    // Наименование проекта закона Еврейской автономной области
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[2];    // Ответственный за подготовку проекта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells[3];   // Дата внесения на рассмотрение Законодательного Собрания области
               string dateStr = GetDateString(row.PlanDateGov);
               rte.Document.InsertSingleLineText(cell.Range.Start, dateStr);
            }
            pg.PerformStep();
         }
      }

      /// <summary>
      /// Записать данные в тбл. II. Проекты постановлений правительства Еврейской автономной области
      /// </summary>
      private void WriteNpa2II() {
         Table tbl = rte.Document.Tables[2];
         foreach(var row in ds.NpaI) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            var range = tblRow.Range;
            CharacterProperties cp = rte.Document.BeginUpdateCharacters(range);
            cp.Bold = false;
            rte.Document.EndUpdateCharacters(cp);

            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];    // Наименование проекта закона Еврейской автономной области
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[2];    // Ответственный за подготовку проекта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells[3];   // Дата принятия проекта правительством Еврейской автономной области
               string dateStr = GetDateString(row.PlanDateGov);
               rte.Document.InsertSingleLineText(cell.Range.Start, dateStr);
            }
            pg.PerformStep();
         }
      }

      /// <summary>
      /// Записать данные в тбл. III. Проекты постановлений и распоряжений губернатора, распоряжений правительства Еврейской автономной области
      /// </summary>
      private void WriteNpa2III() {
         Table tbl = rte.Document.Tables[3];
         foreach(var row in ds.NpaIII) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            var range = tblRow.Range;
            CharacterProperties cp = rte.Document.BeginUpdateCharacters(range);
            cp.Bold = false;
            rte.Document.EndUpdateCharacters(cp);

            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];    // Вид проекта нормативного правового акта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaKind);

            cell = tblRow.Cells[2];    // Наименование проекта нормативного правового акта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[3];    // Ответственный за подготовку проекта
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            if(!row.IsPlanDateGovNull()) {
               cell = tblRow.Cells[4];   // Дата регистрации нормативного правового акта
               string dateStr = GetDateString(row.PlanDateGov);
               rte.Document.InsertSingleLineText(cell.Range.Start, dateStr);
            }
            pg.PerformStep();
         }
      }

      /// <summary>
      /// Записать данные в тбл. IV. Проекты приказов органов исполнительной власти области, формируемых правительством, носящие нормативный характер
      /// </summary>
      private void WriteNpa2IV() {
         Table tbl = rte.Document.Tables[4];
         foreach(var row in ds.NpaIV) {
            System.Windows.Forms.Application.DoEvents();
            TableRow tblRow = tbl.Rows.Append(); // добвить строку в табл.

            var cell = tblRow.Cells[0];      // № п.п.
            var range = tblRow.Range;
            CharacterProperties cp = rte.Document.BeginUpdateCharacters(range);
            cp.Bold = false;
            rte.Document.EndUpdateCharacters(cp);

            rte.Document.InsertSingleLineText(cell.Range.Start, row.Index.ToString("0.###", NumberFormatInfo.InvariantInfo) + row.NpaState);

            cell = tblRow.Cells[1];    // Наименование проекта приказа
            rte.Document.InsertSingleLineText(cell.Range.Start, row.NpaName);

            cell = tblRow.Cells[2];    // Ответственный за подготовку проекта прикза
            rte.Document.InsertSingleLineText(cell.Range.Start, row.Iogv);

            if(!row.IsRegDateLawNull()) {
               cell = tblRow.Cells[3];   // Срок представления в юридическое управление для регистрации
               string dateStr = GetDateString(row.RegDateLaw);
               rte.Document.InsertSingleLineText(cell.Range.Start, dateStr);
            }
            pg.PerformStep();
         }
      }
      #endregion

      /// <summary>
      /// Получить строковое представление даты "месяц год"
      /// </summary>
      private string GetDateString(DateTime date) {
         string str = string.Format("{0} {1}", monthDictionary[date.Month], date.Year);
         return str;
      }

      /// <summary>
      /// Получить
      /// </summary>
      private string GetCurrentDateStr() {
         DateTime today = DateTime.Today;
         return today.ToString("« dd » MMMM yyyy года");
      }
      #endregion
   }
}
