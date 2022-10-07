namespace NpaManager {
   partial class IogvReport {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.npaDataSet1 = new NpaManager.NpaDataSet();
         this.iogvRefTableAdapter = new NpaManager.NpaDataSetTableAdapters.IogvRefTableAdapter();
         this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
         this.Detail.Dpi = 254F;
         this.Detail.HeightF = 96.39584F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
         this.Detail.StylePriority.UseBorders = false;
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrTable1
         // 
         this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrTable1.Dpi = 254F;
         this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrTable1.Name = "xrTable1";
         this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
         this.xrTable1.SizeF = new System.Drawing.SizeF(1707F, 96.39584F);
         this.xrTable1.StylePriority.UseBorders = false;
         // 
         // xrTableRow1
         // 
         this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
         this.xrTableRow1.Dpi = 254F;
         this.xrTableRow1.Name = "xrTableRow1";
         this.xrTableRow1.Weight = 1.2578234630168972D;
         // 
         // xrTableCell1
         // 
         this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "IogvRef.Iogv")});
         this.xrTableCell1.Dpi = 254F;
         this.xrTableCell1.Multiline = true;
         this.xrTableCell1.Name = "xrTableCell1";
         this.xrTableCell1.StylePriority.UseBorders = false;
         this.xrTableCell1.Weight = 1D;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
         this.TopMargin.Dpi = 254F;
         this.TopMargin.HeightF = 75.41666F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
         this.TopMargin.StylePriority.UseTextAlignment = false;
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Dpi = 254F;
         this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
         this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(1707F, 49.27083F);
         this.xrPageInfo1.StylePriority.UseFont = false;
         this.xrPageInfo1.StylePriority.UseTextAlignment = false;
         this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // BottomMargin
         // 
         this.BottomMargin.Dpi = 254F;
         this.BottomMargin.HeightF = 63.52083F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // npaDataSet1
         // 
         this.npaDataSet1.DataSetName = "NpaDataSet";
         this.npaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // iogvRefTableAdapter
         // 
         this.iogvRefTableAdapter.ClearBeforeFill = true;
         // 
         // ReportHeader
         // 
         this.ReportHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
         this.ReportHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
         this.ReportHeader.Dpi = 254F;
         this.ReportHeader.HeightF = 152F;
         this.ReportHeader.Name = "ReportHeader";
         this.ReportHeader.StylePriority.UseBorderDashStyle = false;
         this.ReportHeader.StylePriority.UseBorders = false;
         // 
         // xrLabel1
         // 
         this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel1.Dpi = 254F;
         this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.xrLabel1.ForeColor = System.Drawing.Color.DarkBlue;
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25.00001F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(1707F, 62.5F);
         this.xrLabel1.StylePriority.UseBorders = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "Справочник подразделений правительства ЕАО";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
         this.GroupHeader1.Dpi = 254F;
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 112.2708F;
         this.GroupHeader1.Name = "GroupHeader1";
         this.GroupHeader1.RepeatEveryPage = true;
         // 
         // xrTable2
         // 
         this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrTable2.Dpi = 254F;
         this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrTable2.Name = "xrTable2";
         this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
         this.xrTable2.SizeF = new System.Drawing.SizeF(1707F, 112.2708F);
         this.xrTable2.StylePriority.UseBorders = false;
         // 
         // xrTableRow2
         // 
         this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4});
         this.xrTableRow2.Dpi = 254F;
         this.xrTableRow2.Name = "xrTableRow2";
         this.xrTableRow2.Weight = 1.813378970650203D;
         // 
         // xrTableCell4
         // 
         this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.xrTableCell4.Dpi = 254F;
         this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.xrTableCell4.Multiline = true;
         this.xrTableCell4.Name = "xrTableCell4";
         this.xrTableCell4.StylePriority.UseBorders = false;
         this.xrTableCell4.StylePriority.UseFont = false;
         this.xrTableCell4.StylePriority.UseTextAlignment = false;
         this.xrTableCell4.Text = "Наименование подразделения";
         this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         this.xrTableCell4.Weight = 1D;
         // 
         // IogvReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1});
         this.Bookmark = "Справочник подразделений";
         this.DataAdapter = this.iogvRefTableAdapter;
         this.DataMember = "IogvRef";
         this.DataSource = this.npaDataSet1;
         this.Dpi = 254F;
         this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.Margins = new System.Drawing.Printing.Margins(196, 193, 75, 64);
         this.PageHeight = 2970;
         this.PageWidth = 2100;
         this.PaperKind = System.Drawing.Printing.PaperKind.A4;
         this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
         this.Version = "14.2";
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.npaDataSet1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private NpaDataSet npaDataSet1;
      private NpaDataSetTableAdapters.IogvRefTableAdapter iogvRefTableAdapter;
      private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
      private DevExpress.XtraReports.UI.XRLabel xrLabel1;
      private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
      private DevExpress.XtraReports.UI.XRTable xrTable1;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
      private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
      private DevExpress.XtraReports.UI.XRTable xrTable2;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
   }
}
