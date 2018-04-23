Namespace T228313
    Partial Public Class OrderDetailsReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo3 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery3 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo4 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrderDetailsReport))
            Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim dynamicListLookUpSettings2 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.CategoryID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ProductID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
            Me.TotalPrice = New DevExpress.XtraReports.UI.CalculatedField()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tbHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.trHeaderRow = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcDateHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcNameHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcTotalHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCountryHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCityHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcQuantityHeader = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tbDetail = New DevExpress.XtraReports.UI.XRTable()
            Me.trDetailRow = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tcDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCountry = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcCity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tcTotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.lbTotalSummary = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me.tbHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbDetail})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NorthwindConnection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.FilterString = "[Order Details.ProductID] = ?ProductID"
            tableQuery1.Name = "Order Details"
            queryParameter1.Name = "ProductID"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.ProductID]", GetType(Integer))
            tableQuery1.Parameters.Add(queryParameter1)
            relationColumnInfo1.NestedKeyColumn = "OrderID"
            relationColumnInfo1.ParentKeyColumn = "OrderID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Orders"
            relationInfo1.ParentTable = "Order Details"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1})
            tableInfo1.Name = "Order Details"
            columnInfo1.Name = "OrderID"
            columnInfo2.Name = "ProductID"
            columnInfo3.Name = "UnitPrice"
            columnInfo4.Name = "Quantity"
            columnInfo5.Name = "Discount"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5})
            tableInfo2.Name = "Orders"
            columnInfo6.Name = "OrderDate"
            columnInfo7.Name = "ShipName"
            columnInfo8.Name = "ShipCity"
            columnInfo9.Name = "ShipCountry"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo6, columnInfo7, columnInfo8, columnInfo9})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2})
            tableQuery2.Name = "Categories"
            tableInfo3.Name = "Categories"
            columnInfo10.Name = "CategoryID"
            columnInfo11.Name = "CategoryName"
            tableInfo3.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo10, columnInfo11})
            tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo3})
            tableQuery3.Name = "Products"
            tableInfo4.Name = "Products"
            columnInfo12.Name = "ProductID"
            columnInfo13.Name = "ProductName"
            columnInfo14.Name = "CategoryID"
            tableInfo4.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo12, columnInfo13, columnInfo14})
            tableQuery3.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo4})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2, tableQuery3})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' CategoryID
            ' 
            Me.CategoryID.Description = "Category"
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "Categories"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "CategoryName"
            dynamicListLookUpSettings1.FilterString = Nothing
            dynamicListLookUpSettings1.ValueMember = "CategoryID"
            Me.CategoryID.LookUpSettings = dynamicListLookUpSettings1
            Me.CategoryID.Name = "CategoryID"
            Me.CategoryID.Type = GetType(Integer)
            Me.CategoryID.ValueInfo = "1"
            ' 
            ' ProductID
            ' 
            Me.ProductID.Description = "Product"
            dynamicListLookUpSettings2.DataAdapter = Nothing
            dynamicListLookUpSettings2.DataMember = "Products"
            dynamicListLookUpSettings2.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings2.DisplayMember = "ProductName"
            dynamicListLookUpSettings2.FilterString = "[CategoryID] = ?CategoryID"
            dynamicListLookUpSettings2.ValueMember = "ProductID"
            Me.ProductID.LookUpSettings = dynamicListLookUpSettings2
            Me.ProductID.Name = "ProductID"
            Me.ProductID.Type = GetType(Integer)
            Me.ProductID.ValueInfo = "1"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
            Me.ReportHeader.HeightF = 50F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' lbHeader
            ' 
            Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 28F)
            Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbHeader.Name = "lbHeader"
            Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.lbHeader.SizeF = New System.Drawing.SizeF(650F, 50F)
            Me.lbHeader.StylePriority.UseFont = False
            Me.lbHeader.StylePriority.UseTextAlignment = False
            Me.lbHeader.Text = "Order Details"
            Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' TotalPrice
            ' 
            Me.TotalPrice.DataMember = "Order Details"
            Me.TotalPrice.Expression = "[Quantity]  *  [UnitPrice]"
            Me.TotalPrice.Name = "TotalPrice"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tbHeader})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 29.99999F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            ' 
            ' tbHeader
            ' 
            Me.tbHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.tbHeader.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.tbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbHeader.Name = "tbHeader"
            Me.tbHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trHeaderRow})
            Me.tbHeader.SizeF = New System.Drawing.SizeF(650F, 29.99998F)
            Me.tbHeader.StylePriority.UseBorders = False
            Me.tbHeader.StylePriority.UseFont = False
            Me.tbHeader.StylePriority.UseTextAlignment = False
            Me.tbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' trHeaderRow
            ' 
            Me.trHeaderRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcDateHeader, Me.tcNameHeader, Me.tcCountryHeader, Me.tcCityHeader, Me.tcQuantityHeader, Me.tcTotalHeader})
            Me.trHeaderRow.Name = "trHeaderRow"
            Me.trHeaderRow.Weight = 1R
            ' 
            ' tcDateHeader
            ' 
            Me.tcDateHeader.Name = "tcDateHeader"
            Me.tcDateHeader.Text = "Date"
            Me.tcDateHeader.Weight = 0.84615392831655645R
            ' 
            ' tcNameHeader
            ' 
            Me.tcNameHeader.Name = "tcNameHeader"
            Me.tcNameHeader.Text = "Name"
            Me.tcNameHeader.Weight = 1.6923076453575721R
            ' 
            ' tcTotalHeader
            ' 
            Me.tcTotalHeader.Name = "tcTotalHeader"
            Me.tcTotalHeader.StylePriority.UseTextAlignment = False
            Me.tcTotalHeader.Text = "Total"
            Me.tcTotalHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            Me.tcTotalHeader.Weight = 0.63461444561298075R
            ' 
            ' tcCountryHeader
            ' 
            Me.tcCountryHeader.Name = "tcCountryHeader"
            Me.tcCountryHeader.Text = "Country"
            Me.tcCountryHeader.Weight = 0.84615386376014123R
            ' 
            ' tcCityHeader
            ' 
            Me.tcCityHeader.Name = "tcCityHeader"
            Me.tcCityHeader.Text = "City"
            Me.tcCityHeader.Weight = 0.84615381681002111R
            ' 
            ' tcQuantityHeader
            ' 
            Me.tcQuantityHeader.Name = "tcQuantityHeader"
            Me.tcQuantityHeader.StylePriority.UseTextAlignment = False
            Me.tcQuantityHeader.Text = "Quantity"
            Me.tcQuantityHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
            Me.tcQuantityHeader.Weight = 0.6346163001427283R
            ' 
            ' tbDetail
            ' 
            Me.tbDetail.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tbDetail.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.tbDetail.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tbDetail.Name = "tbDetail"
            Me.tbDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trDetailRow})
            Me.tbDetail.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.tbDetail.StylePriority.UseBorders = False
            Me.tbDetail.StylePriority.UseFont = False
            Me.tbDetail.StylePriority.UseTextAlignment = False
            Me.tbDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' trDetailRow
            ' 
            Me.trDetailRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tcDate, Me.tcName, Me.tcCountry, Me.tcCity, Me.tcQuantity, Me.tcTotal})
            Me.trDetailRow.Name = "trDetailRow"
            Me.trDetailRow.Weight = 1R
            ' 
            ' tcDate
            ' 
            Me.tcDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.OrderDate", "{0:dd-MMM-yy}")})
            Me.tcDate.Name = "tcDate"
            Me.tcDate.Text = "Date"
            Me.tcDate.Weight = 0.84615392831655645R
            ' 
            ' tcName
            ' 
            Me.tcName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.ShipName")})
            Me.tcName.Name = "tcName"
            Me.tcName.Text = "Name"
            Me.tcName.Weight = 1.6923076453575721R
            ' 
            ' tcCountry
            ' 
            Me.tcCountry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.ShipCountry")})
            Me.tcCountry.Name = "tcCountry"
            Me.tcCountry.Text = "Country"
            Me.tcCountry.Weight = 0.84615386376014123R
            ' 
            ' tcCity
            ' 
            Me.tcCity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.ShipCity")})
            Me.tcCity.Name = "tcCity"
            Me.tcCity.Text = "City"
            Me.tcCity.Weight = 0.84615381681002111R
            ' 
            ' tcQuantity
            ' 
            Me.tcQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.Quantity")})
            Me.tcQuantity.Name = "tcQuantity"
            Me.tcQuantity.StylePriority.UseTextAlignment = False
            Me.tcQuantity.Text = "Quantity"
            Me.tcQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcQuantity.Weight = 0.6346163001427283R
            ' 
            ' tcTotal
            ' 
            Me.tcTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.TotalPrice", "{0:c}")})
            Me.tcTotal.Name = "tcTotal"
            Me.tcTotal.StylePriority.UseTextAlignment = False
            Me.tcTotal.Text = "Total"
            Me.tcTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tcTotal.Weight = 0.63461444561298075R
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbTotalSummary})
            Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
            Me.GroupFooter1.HeightF = 23F
            Me.GroupFooter1.Name = "GroupFooter1"
            ' 
            ' lbTotalSummary
            ' 
            Me.lbTotalSummary.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.lbTotalSummary.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.TotalPrice")})
            Me.lbTotalSummary.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.lbTotalSummary.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbTotalSummary.Name = "lbTotalSummary"
            Me.lbTotalSummary.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.lbTotalSummary.SizeF = New System.Drawing.SizeF(650F, 23F)
            Me.lbTotalSummary.StylePriority.UseBorders = False
            Me.lbTotalSummary.StylePriority.UseFont = False
            Me.lbTotalSummary.StylePriority.UseTextAlignment = False
            xrSummary1.FormatString = "{0:c}"
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.lbTotalSummary.Summary = xrSummary1
            Me.lbTotalSummary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' OrderDetailsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupFooter1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.TotalPrice})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Order Details"
            Me.DataSource = Me.sqlDataSource1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CategoryID, Me.ProductID})
            Me.Version = "14.2"
            DirectCast(Me.tbHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbDetail, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private tbDetail As DevExpress.XtraReports.UI.XRTable
        Private trDetailRow As DevExpress.XtraReports.UI.XRTableRow
        Private tcDate As DevExpress.XtraReports.UI.XRTableCell
        Private tcName As DevExpress.XtraReports.UI.XRTableCell
        Private tcCountry As DevExpress.XtraReports.UI.XRTableCell
        Private tcCity As DevExpress.XtraReports.UI.XRTableCell
        Private tcQuantity As DevExpress.XtraReports.UI.XRTableCell
        Private tcTotal As DevExpress.XtraReports.UI.XRTableCell
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private CategoryID As DevExpress.XtraReports.Parameters.Parameter
        Private ProductID As DevExpress.XtraReports.Parameters.Parameter
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private lbHeader As DevExpress.XtraReports.UI.XRLabel
        Private TotalPrice As DevExpress.XtraReports.UI.CalculatedField
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private tbHeader As DevExpress.XtraReports.UI.XRTable
        Private trHeaderRow As DevExpress.XtraReports.UI.XRTableRow
        Private tcDateHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcNameHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcCountryHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcCityHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcQuantityHeader As DevExpress.XtraReports.UI.XRTableCell
        Private tcTotalHeader As DevExpress.XtraReports.UI.XRTableCell
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
        Private lbTotalSummary As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
