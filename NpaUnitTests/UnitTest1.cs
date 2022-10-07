using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NpaManager;
using static NpaManager.NpaDataSet;

namespace NpaUnitTests {
   [TestClass]
   public class WordTests {
      private static string fileName = "График нпа.docx";
      private static NpaManager.NpaDataSet ds = DsHelper.DS;
      private static RichEditControl rte;

      [ClassInitialize()]
      public static void ClassInit(TestContext context) {
         DsHelper.FillRefData();
         var periodRow = DsHelper.GetCurrentPeriod();
         DsHelper.SetDefaultPeriod(periodRow);

         rte = new RichEditControl();
         rte.LoadDocument(fileName);
      }

      [TestInitialize()]
      public void Initialize() {
         DsHelper.DS.NpaI.RejectChanges();
      }


      [TestMethod]
      public void TestTablesCount() {
         Assert.IsNotNull(rte.Document);
         Assert.AreEqual(5, rte.Document.Tables.Count);
      }

      [TestMethod]
      public void TestTableRowsCount() {
         var tblI = rte.Document.Tables[1];  //I. Проекты законов Еврейской автономной области

         Assert.IsNotNull(tblI);
         Assert.AreEqual(13, tblI.Rows.Count);

         var tblII = rte.Document.Tables[2]; //II. Проекты постановлений правительства Еврейской автономной области
         Assert.AreEqual(98, tblII.Rows.Count);

         var tblIII = rte.Document.Tables[3]; //III. Проекты постановлений и распоряжений губернатора ЕАО, распоряжений правительства ЕАО
         Assert.AreEqual(62, tblIII.Rows.Count);

         var tblIV = rte.Document.Tables[4]; //V. Проекты приказов органов исполнительной власти области, формируемых правительством ЕАО, носящие нормативный характер
         Assert.AreEqual(33, tblIV.Rows.Count);
      }

      [TestMethod]
      public void GetDSRefsLoad() {
         Assert.IsTrue(ds.Periods.Count > 0);
         Assert.IsTrue(ds.NpaStatusRef.Count > 0);
         Assert.IsTrue(ds.NpaKindsRef.Count > 0);
         Assert.IsTrue(ds.IogvRef.Count > 0);
      }

      [TestMethod]
      public void NpaI_NewRow_Clone() {
         NpaDataSet clone = DsHelper.CloneNpaDataSet();
         NpaIRow row = clone.NpaI.NewNpaIRow();

         Assert.IsNotNull(row);
         Assert.AreEqual("В работе", row.Status);
      }

      [TestMethod]
      public void CloneNpaDataSetTest() {
         NpaDataSet clone = DsHelper.CloneNpaDataSet();

         Assert.IsNotNull(clone);
         Assert.IsTrue(clone.NpaStatusRef.Count > 0);
         Assert.AreEqual(4, clone.NpaStatusRef.Count);

         Assert.IsTrue(clone.Periods.Count > 0);

         Assert.IsTrue(clone.NpaI.Constraints.Count == 1);
         Assert.IsTrue(clone.NpaII.Constraints.Count == 1);
         Assert.IsTrue(clone.NpaIII.Constraints.Count == 1);
         Assert.IsTrue(clone.NpaIV.Constraints.Count == 1);
      }

      [TestMethod]
      public void FindPeriodByDate() {
         DateTime date = new DateTime(2018, 6, 20);
         PeriodsRow row  = DsHelper.GetPeriod(date);

         Assert.IsNotNull(row);
         Assert.AreEqual("II квартал 2018 г", row.PeriodId);
      }

      [TestMethod]
      public void DateFromString() {
         string str = "01 Июнь 2018";

         string[] items = str.Split();
         int day = Convert.ToInt32(items[0]);
         var dic = GetMonthDictionary();
         int month = dic[items[1]];
         int year = Convert.ToInt32(items[2]);
         DateTime date = new DateTime(year, month, day);


         Assert.AreEqual(new DateTime(2018, 6, 1), date);
      }

      [TestMethod]
      public void LoadTemplateTest() {
         string template = "1.dot";
         RichEditControl rteT = new RichEditControl();
         rteT.LoadDocumentTemplate(template, DocumentFormat.Doc);
         int tblCount = rteT.Document.Tables.Count;

         Assert.IsTrue(tblCount > 0);
      }

      [TestMethod]
      public void WordReplaceTextTbl() {
         string template = "1.dot";
         RichEditControl rteT = new RichEditControl();
         rteT.LoadDocumentTemplate(template, DocumentFormat.Doc);

         string txt = DateTime.Today.ToString("« dd » MMMM yyyy года");

         var range = rteT.Document.Tables[0].Rows[1].Cells[0].Range;
         string txtSrc = rteT.Document.GetText(range);
         SubDocument doc = range.BeginUpdateDocument();
         doc.Delete(range);
         //doc.Replace(range, "");
         range.EndUpdateDocument(doc);

         string txtDst = doc.GetText(range);

         Assert.AreEqual(txt, txtDst);
      }

      /// <summary>
      /// Прочитать текст из ячейки таблицы
      /// </summary>
      private string GetCellText(TableCell cell) {
         var doc = rte.Document;
         string txt = doc.GetText(cell.Range);
         txt = txt.Trim(new char[] { '\r', '\n', ' ' });
         return txt;
      }

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
   }
}
