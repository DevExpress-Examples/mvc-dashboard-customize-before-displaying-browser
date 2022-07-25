<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579311/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T596822)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for MVC - How to customize a dashboard before displaying it in a browser

This example demonstrates how to define a custom [Dashboard Storage](https://docs.devexpress.com/Dashboard/116299/web-dashboard/aspnet-web-forms-dashboard-control/prepare-dashboard-storage) and override the **LoadDashboard** method that is used to load dashboards. From this method, you can edit the loaded dashboard and provide the updated version to the ASP.NET MVC Dashboard control. In this example, a custom descendant of the [DashboardFileStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardFileStorage) class is created. It allows defining the default parameter value and customizing the data source query to filter displayed data.

## Files to Look At

* [DashboardConfig.cs](./CS/MVCxDashboard/App_Start/DashboardConfig.cs)

## Documentation

- [DashboardFileStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardFileStorage)

## More Examples
  
- [Web Dashboard - How to customize a dashboard before displaying it in a browser](https://github.com/DevExpress-Examples/web-dashboard-how-to-customize-a-dashboard-before-displaying-it-in-a-browser)
