<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MVCxDashboard/App_Start/DashboardConfig.cs)
<!-- default file list end -->
# Dashboard for MVC - How to customize a dashboard before displaying it in a browser


This example demonstrates how to define a custom [Dashboard Storage](https://docs.devexpress.com/Dashboard/116299/web-dashboard/aspnet-web-forms-dashboard-control/prepare-dashboard-storage) and override the **LoadDashboard** method that is used to load dashboards. From this method, you can edit the loaded dashboard and provide the updated version to the ASP.NET MVC Dashboard control. In this example, a custom descendant of the [DashboardFileStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardFileStorage) class is created. It allows defining the default parameter value and customizing the data source query to filter displayed data.

## More Examples
  
- [Web Dashboard - How to customize a dashboard before displaying it in a browser](https://github.com/DevExpress-Examples/web-dashboard-how-to-customize-a-dashboard-before-displaying-it-in-a-browser)
