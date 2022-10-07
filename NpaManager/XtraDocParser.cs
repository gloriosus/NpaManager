using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using d = System.Data;
using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace NpaManager {
   public class XtraDocParser:INpaDocParser {
      /// <summary>
      /// Загрузка данных из табл. Word завершена
      /// </summary>
      public event EventHandler<EndTableLoadEventAgs> EndTableLoad;

      #region Fields
      private DateTime dateFirst;      // дата начала квартала
      private DateTime dateLast;       // дата окончания квартала
      private NpaDataSet ds;
      private object lockNpaKind;      // объект блокировки для справочника NpaKindsRef
      private object lockIogv;         // объект блокировки для справочника IogvRef
      private RichEditControl rte;
      #endregion

      #region Ctors
      public XtraDocParser() {
         lockIogv = new object();
         lockNpaKind = new object();
         ds = DsHelper.DS;
      }
      #endregion

      #region INpaDocParser
      /// <summary>
      /// Открыть документ в формате Word
      /// </summary>
      public void OpenDoc(string fileName, DateTime dateFirst, DateTime dateLast) {
         OpenDoc(fileName);
         this.dateFirst = dateFirst;
         this.dateLast = dateLast;
      }

      /// <summary>
      /// Закрыть документ Word
      /// </summary>
      public void CloseDoc() {
         try {
            if(rte == null)
               return;
            if(!rte.IsDisposed)
               rte.Dispose();
            rte = null;
         } catch(Exception ex) {
            Debug.WriteLine(ex.Message);
         }
      }

      /// <summary>
      /// Распарсить таблицу Word'a в таблицу данных
      /// </summary>
      public void ParseTableAsync(INpaGrid npaGrid) {
         //-- Клонировать дата сет и табл.
         NpaDataSet dsClone = CloneNpaDataSet();
         d.DataTable npaClone = CloneNpaDataTable(npaGrid, dsClone);

         switch(npaGrid.TableName) {
            case "NpaI":
            ParseNpaI(npaGrid, npaClone as NpaDataSet.NpaIDataTable);
            break;
            case "NpaII":
            ParseNpaII(npaGrid, npaClone as NpaDataSet.NpaIIDataTable);
            break;
            case "NpaIII":
            ParseNpaIII(npaGrid, npaClone as NpaDataSet.NpaIIIDataTable);
            break;
            case "NpaIV":
            ParseNpaIV(npaGrid, npaClone as NpaDataSet.NpaIVDataTable);
            break;
         }
      }

      /// <summary>
      /// Получить клон без данных для NpaDataSet
      /// </summary>
      private static NpaDataSet CloneNpaDataSet() {
         NpaDataSet dsClone = DsHelper.DS.Clone() as NpaDataSet;
         dsClone.Relations.Remove("IogvRef_NpaI");       // удалить ограничения
         dsClone.Relations.Remove("IogvRef_NpaII");
         dsClone.Relations.Remove("IogvRef_NpaIII");
         dsClone.Relations.Remove("IogvRef_NpaIV");
         //dsClone.Relations.Remove("NpaKindsRef_NpaII");
         //dsClone.Relations.Remove("NpaKindsRef_NpaIII");
         return dsClone;
      }

      /// <summary>
      /// Получить клон таблицы данных нпа
      /// </summary>
      /// <returns></returns>
      private static d.DataTable CloneNpaDataTable(INpaGrid npaGrid, NpaDataSet dsClone) {
         string tableName = npaGrid.TableName;
         d.DataTable npaClone = dsClone.Tables[tableName];
         while(npaClone.Constraints.Count > 1)
            npaClone.Constraints.RemoveAt(1);

         //-- Сброс автоинкремента
         npaClone.Columns["Id"].AutoIncrementSeed = 1;
         npaClone.Columns["Id"].AutoIncrementStep = 1;
         npaClone.Columns["Id"].AutoIncrementSeed = -1;
         npaClone.Columns["Id"].AutoIncrementStep = -1;
         return npaClone;
      }

      private void ParseNpaI(INpaGrid npaGrid, NpaDataSet.NpaIDataTable npaClone) {
         var tbl = rte.Document.Tables[2];
         for(int i = 2; i < tbl.Rows.Count; i++) {
            var tblRow = tbl.Rows[i];
            var dtRow = npaClone.NewNpaIRow();

            string index = GetCellText(tblRow.Cells[0]);
            int pos = index.IndexOf('*');
            if(pos > 0) {
               string state = index.Substring(pos);
               index = index.Replace(state, "");
               dtRow.NpaState = state;
            }
            dtRow.Index = Convert.ToDecimal(index);
            dtRow.Iogv = GetCellText(tblRow.Cells[2]);
            dtRow.NpaName = GetCellText(tblRow.Cells[1]);

         }
      }

      private void ParseNpaII(INpaGrid npaGrid, NpaDataSet.NpaIIDataTable npaClone) {
         var tbl = rte.Document.Tables[3];
         for(int i = 2; i < tbl.Rows.Count; i++) {
            var tblRow = tbl.Rows[i];
         }
      }

      private void ParseNpaIII(INpaGrid npaGrid, NpaDataSet.NpaIIIDataTable npaClone) {
         var tbl = rte.Document.Tables[4];
         for(int i = 2; i < tbl.Rows.Count; i++) {
            var tblRow = tbl.Rows[i];
         }
      }

      private void ParseNpaIV(INpaGrid npaGrid, NpaDataSet.NpaIVDataTable npaClone) {
         var tbl = rte.Document.Tables[5];
         for(int i = 2; i < tbl.Rows.Count; i++) {
            var tblRow = tbl.Rows[i];
         }
      }

      #endregion

      #region Methods
      /// <summary>
      /// Открыть (загрузить) файл формата Word
      /// </summary>
      private void OpenDoc(string fileName) {
         try {
            rte = new RichEditControl();
            rte.LoadDocument(fileName);
         } catch(Exception ex) {
            Debug.WriteLine(ex.Message);
            throw ex;
         }
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
      #endregion
   }
}
