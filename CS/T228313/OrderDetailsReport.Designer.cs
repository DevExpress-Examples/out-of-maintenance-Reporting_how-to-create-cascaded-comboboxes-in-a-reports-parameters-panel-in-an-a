namespace T228313 {
    partial class OrderDetailsReport {
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo3 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableQuery tableQuery3 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo4 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsReport));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.CategoryID = new DevExpress.XtraReports.Parameters.Parameter();
            this.ProductID = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalPrice = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tbHeader = new DevExpress.XtraReports.UI.XRTable();
            this.trHeaderRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcDateHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcTotalHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCountryHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCityHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcQuantityHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbDetail = new DevExpress.XtraReports.UI.XRTable();
            this.trDetailRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCountry = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcCity = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lbTotalSummary = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbDetail});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NorthwindConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.FilterString = "[Order Details.ProductID] = ?ProductID";
            tableQuery1.Name = "Order Details";
            queryParameter1.Name = "ProductID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.ProductID]", typeof(int));
            tableQuery1.Parameters.Add(queryParameter1);
            relationColumnInfo1.NestedKeyColumn = "OrderID";
            relationColumnInfo1.ParentKeyColumn = "OrderID";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "Orders";
            relationInfo1.ParentTable = "Order Details";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1});
            tableInfo1.Name = "Order Details";
            columnInfo1.Name = "OrderID";
            columnInfo2.Name = "ProductID";
            columnInfo3.Name = "UnitPrice";
            columnInfo4.Name = "Quantity";
            columnInfo5.Name = "Discount";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5});
            tableInfo2.Name = "Orders";
            columnInfo6.Name = "OrderDate";
            columnInfo7.Name = "ShipName";
            columnInfo8.Name = "ShipCity";
            columnInfo9.Name = "ShipCountry";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo6,
            columnInfo7,
            columnInfo8,
            columnInfo9});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2});
            tableQuery2.Name = "Categories";
            tableInfo3.Name = "Categories";
            columnInfo10.Name = "CategoryID";
            columnInfo11.Name = "CategoryName";
            tableInfo3.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo10,
            columnInfo11});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo3});
            tableQuery3.Name = "Products";
            tableInfo4.Name = "Products";
            columnInfo12.Name = "ProductID";
            columnInfo13.Name = "ProductName";
            columnInfo14.Name = "CategoryID";
            tableInfo4.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo12,
            columnInfo13,
            columnInfo14});
            tableQuery3.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo4});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1,
            tableQuery2,
            tableQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // CategoryID
            // 
            this.CategoryID.Description = "Category";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "Categories";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "CategoryName";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.ValueMember = "CategoryID";
            this.CategoryID.LookUpSettings = dynamicListLookUpSettings1;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Type = typeof(int);
            this.CategoryID.ValueInfo = "1";
            // 
            // ProductID
            // 
            this.ProductID.Description = "Product";
            dynamicListLookUpSettings2.DataAdapter = null;
            dynamicListLookUpSettings2.DataMember = "Products";
            dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings2.DisplayMember = "ProductName";
            dynamicListLookUpSettings2.FilterString = "[CategoryID] = ?CategoryID";
            dynamicListLookUpSettings2.ValueMember = "ProductID";
            this.ProductID.LookUpSettings = dynamicListLookUpSettings2;
            this.ProductID.Name = "ProductID";
            this.ProductID.Type = typeof(int);
            this.ProductID.ValueInfo = "1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.HeightF = 50F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 28F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650F, 50F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Order Details";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataMember = "Order Details";
            this.TotalPrice.Expression = "[Quantity]  *  [UnitPrice]";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbHeader});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 29.99999F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // tbHeader
            // 
            this.tbHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tbHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trHeaderRow});
            this.tbHeader.SizeF = new System.Drawing.SizeF(650F, 29.99998F);
            this.tbHeader.StylePriority.UseBorders = false;
            this.tbHeader.StylePriority.UseFont = false;
            this.tbHeader.StylePriority.UseTextAlignment = false;
            this.tbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // trHeaderRow
            // 
            this.trHeaderRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcDateHeader,
            this.tcNameHeader,
            this.tcCountryHeader,
            this.tcCityHeader,
            this.tcQuantityHeader,
            this.tcTotalHeader});
            this.trHeaderRow.Name = "trHeaderRow";
            this.trHeaderRow.Weight = 1D;
            // 
            // tcDateHeader
            // 
            this.tcDateHeader.Name = "tcDateHeader";
            this.tcDateHeader.Text = "Date";
            this.tcDateHeader.Weight = 0.84615392831655645D;
            // 
            // tcNameHeader
            // 
            this.tcNameHeader.Name = "tcNameHeader";
            this.tcNameHeader.Text = "Name";
            this.tcNameHeader.Weight = 1.6923076453575721D;
            // 
            // tcTotalHeader
            // 
            this.tcTotalHeader.Name = "tcTotalHeader";
            this.tcTotalHeader.StylePriority.UseTextAlignment = false;
            this.tcTotalHeader.Text = "Total";
            this.tcTotalHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.tcTotalHeader.Weight = 0.63461444561298075D;
            // 
            // tcCountryHeader
            // 
            this.tcCountryHeader.Name = "tcCountryHeader";
            this.tcCountryHeader.Text = "Country";
            this.tcCountryHeader.Weight = 0.84615386376014123D;
            // 
            // tcCityHeader
            // 
            this.tcCityHeader.Name = "tcCityHeader";
            this.tcCityHeader.Text = "City";
            this.tcCityHeader.Weight = 0.84615381681002111D;
            // 
            // tcQuantityHeader
            // 
            this.tcQuantityHeader.Name = "tcQuantityHeader";
            this.tcQuantityHeader.StylePriority.UseTextAlignment = false;
            this.tcQuantityHeader.Text = "Quantity";
            this.tcQuantityHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.tcQuantityHeader.Weight = 0.6346163001427283D;
            // 
            // tbDetail
            // 
            this.tbDetail.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tbDetail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tbDetail.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trDetailRow});
            this.tbDetail.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.tbDetail.StylePriority.UseBorders = false;
            this.tbDetail.StylePriority.UseFont = false;
            this.tbDetail.StylePriority.UseTextAlignment = false;
            this.tbDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // trDetailRow
            // 
            this.trDetailRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcDate,
            this.tcName,
            this.tcCountry,
            this.tcCity,
            this.tcQuantity,
            this.tcTotal});
            this.trDetailRow.Name = "trDetailRow";
            this.trDetailRow.Weight = 1D;
            // 
            // tcDate
            // 
            this.tcDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.OrderDate", "{0:dd-MMM-yy}")});
            this.tcDate.Name = "tcDate";
            this.tcDate.Text = "Date";
            this.tcDate.Weight = 0.84615392831655645D;
            // 
            // tcName
            // 
            this.tcName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.ShipName")});
            this.tcName.Name = "tcName";
            this.tcName.Text = "Name";
            this.tcName.Weight = 1.6923076453575721D;
            // 
            // tcCountry
            // 
            this.tcCountry.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.ShipCountry")});
            this.tcCountry.Name = "tcCountry";
            this.tcCountry.Text = "Country";
            this.tcCountry.Weight = 0.84615386376014123D;
            // 
            // tcCity
            // 
            this.tcCity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.ShipCity")});
            this.tcCity.Name = "tcCity";
            this.tcCity.Text = "City";
            this.tcCity.Weight = 0.84615381681002111D;
            // 
            // tcQuantity
            // 
            this.tcQuantity.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.Quantity")});
            this.tcQuantity.Name = "tcQuantity";
            this.tcQuantity.StylePriority.UseTextAlignment = false;
            this.tcQuantity.Text = "Quantity";
            this.tcQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcQuantity.Weight = 0.6346163001427283D;
            // 
            // tcTotal
            // 
            this.tcTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.TotalPrice", "{0:c}")});
            this.tcTotal.Name = "tcTotal";
            this.tcTotal.StylePriority.UseTextAlignment = false;
            this.tcTotal.Text = "Total";
            this.tcTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcTotal.Weight = 0.63461444561298075D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbTotalSummary});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 23F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // lbTotalSummary
            // 
            this.lbTotalSummary.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lbTotalSummary.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order Details.TotalPrice")});
            this.lbTotalSummary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalSummary.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbTotalSummary.Name = "lbTotalSummary";
            this.lbTotalSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbTotalSummary.SizeF = new System.Drawing.SizeF(650F, 23F);
            this.lbTotalSummary.StylePriority.UseBorders = false;
            this.lbTotalSummary.StylePriority.UseFont = false;
            this.lbTotalSummary.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:c}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lbTotalSummary.Summary = xrSummary1;
            this.lbTotalSummary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // OrderDetailsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalPrice});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Order Details";
            this.DataSource = this.sqlDataSource1;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CategoryID,
            this.ProductID});
            this.Version = "14.2";
            ((System.ComponentModel.ISupportInitialize)(this.tbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable tbDetail;
        private DevExpress.XtraReports.UI.XRTableRow trDetailRow;
        private DevExpress.XtraReports.UI.XRTableCell tcDate;
        private DevExpress.XtraReports.UI.XRTableCell tcName;
        private DevExpress.XtraReports.UI.XRTableCell tcCountry;
        private DevExpress.XtraReports.UI.XRTableCell tcCity;
        private DevExpress.XtraReports.UI.XRTableCell tcQuantity;
        private DevExpress.XtraReports.UI.XRTableCell tcTotal;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter CategoryID;
        private DevExpress.XtraReports.Parameters.Parameter ProductID;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
        private DevExpress.XtraReports.UI.CalculatedField TotalPrice;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable tbHeader;
        private DevExpress.XtraReports.UI.XRTableRow trHeaderRow;
        private DevExpress.XtraReports.UI.XRTableCell tcDateHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcNameHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcCountryHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcCityHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcQuantityHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcTotalHeader;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel lbTotalSummary;
    }
}
