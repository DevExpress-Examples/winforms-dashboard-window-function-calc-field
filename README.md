<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/404742878/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1028236)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for WinForms - How to Use Window Functions in Calculated Fields

This example emulates the standard [Percent of Total](https://docs.devexpress.com/Dashboard/115920/common-features/advanced-analytics/window-calculations/creating-window-calculations#percent-of-total) window calculation behavior in the calculated field's expression.

You cannot include the [window functions](https://docs.devexpress.com/Dashboard/400122/common-features/advanced-analytics/expression-constants-operators-and-functions#functions) in a [calculated field](https://docs.devexpress.com/Dashboard/116934/common-features/advanced-analytics/calculated-fields) directly. To support window functions inside a calculated field expression, use the [w-Function](https://docs.devexpress.com/Dashboard/401421/common-features/advanced-analytics/aggregations/w-function-aggregation-intermediate-level).

This example contains the calculated field with the following expression:

`ToDouble(Sum([Sales])) / w(Total(Sum([Sales])), partitionBy(), orderBy())`

The second part of this expression uses the *w-Function* with the embedded *window function* (`Total` in this example) to calculate the total Sales summary for the entire aggregated data collection. The current row summary is divided by this total to obtain the percentage. In addition, the *Percent* [formatting](https://docs.devexpress.com/Dashboard/15697/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/data-shaping/formatting-data) is applied.

![](images/screenshot.png)

<!-- default file list -->
## Files to Review

* [DesignerForm1.cs](./CS/DesignerForm1.cs) ([DesignerForm1.vb](./VB/DesignerForm1.vb))
* [dashboard1.xml](./CS/dashboard1.xml)
<!-- default file list end -->

## Documentation

- [Window Calculations](https://docs.devexpress.com/Dashboard/115869/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/data-analysis/window-calculations)
- [w Function - Window Calculations at the Intermediate Aggregation Level](https://docs.devexpress.com/Dashboard/401421/common-features/advanced-analytics/aggregations/w-function-aggregation-intermediate-level)
- [Calculated Field](https://docs.devexpress.com/Dashboard/116934/common-features/advanced-analytics/calculated-fields)


## More Examples

- [Dashboard for WinForms - How to Use the W Function to Show Top N Products by Category](https://github.com/DevExpress-Examples/winforms-dashboard-w-function-example)
- [Dashboard for WinForms - How to display best and worst monthly sales for each year](https://github.com/DevExpress-Examples/how-to-display-best-and-worst-monthly-sales-for-each-year-t369371)
- [Dashboard for WinForms - How to Calculate the Contribution of Quarterly Sales to Total Yearly Sales](https://github.com/DevExpress-Examples/how-to-calculate-the-contribution-of-quarterly-sales-to-total-yearly-sales)
- [Dashboard for WinForms - How to evaluate a customer acquisition using the quarter/year of their first purchase](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to divide customers' count by the number of orders they made](https://github.com/DevExpress-Examples/how-to-divide-customers-count-by-the-number-of-orders-they-made-t372356)
- [Dashboard for WinForms - How to calculate Highest Product Sales by Year](https://github.com/DevExpress-Examples/how-to-show-products-with-the-best-sales-in-a-year-along-with-sales-values-t372408)
- [Dashboard for WinForms - How to display sales by years in comparison with the previous year's sales](https://github.com/DevExpress-Examples/win-dashboard-display-previous-year-sales)
- [Dashboard for WinForms - How to Display Product Sales that are Greater than $20k](https://github.com/DevExpress-Examples/How-to-Display-Product-Sales-that-are-Greater-than-20k)
- [Dashboard for WinForms - How to Display Products with Sales Greater than Average Sales per Category](https://github.com/DevExpress-Examples/How-to-Display-Product-with-Sales-Greater-than-Average-Sales-per-Category)
