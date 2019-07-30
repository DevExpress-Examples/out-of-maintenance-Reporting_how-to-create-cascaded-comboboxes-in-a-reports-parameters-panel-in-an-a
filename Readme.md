<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/T228313/Default.aspx) (VB: [Default.aspx](./VB/T228313/Default.aspx))
* [OrderDetailsReport.Designer.cs](./CS/T228313/OrderDetailsReport.Designer.cs) (VB: [OrderDetailsReport.Designer.vb](./VB/T228313/OrderDetailsReport.Designer.vb))
<!-- default file list end -->
#  How to create cascaded ComboBoxes in a report's Parameters panel in an ASP.NET WebForm application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t228313/)**
<!-- run online end -->


<p>This example demonstrates how to add cascaded ComboBox parameters to the XtraReport by using a report's built-in functionality. As the built-in report functionality is used, this task can be completed in the Visual Studio report designer at design time and it is not necessary to write any custom code. </p>
<p>To accomplish this task, use the approach demonstrated in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument11911">How to: Assign a List of Values to a Report Parameter</a> help topic to assign a collection of values to the report parameter. Then use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraReportsParametersLookUpSettings_FilterStringtopic">LookUpSettings.FilterString</a> property to filter your report parameter's values collection by another report parameter value. In this code example, the following filter expression is used to filter the <em>ProductID</em> parameter's values collection (by the <em>CategoryID</em> data field) by using the <em>CategoryID</em> parameter value:<br /><em>[CategoryID] = ?CategoryID</em><br /><br />In this filter expression, the report's parameter name should start with the <strong>?</strong> prefix.<br /><br /><strong>Note</strong>: The parameter that is used in the filter should be added to the report's parameters collection before the filtered parameter. You can change the report's parameters  in the dialog box that can be edited by using the "Edit Parameters..." command in the Visual Studio Report Designer.</p>

<br/>


