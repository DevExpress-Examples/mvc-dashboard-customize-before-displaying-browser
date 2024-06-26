<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579311/20.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T596822)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MVCxDashboard/App_Start/DashboardConfig.cs)
<!-- default file list end -->
# Dashboard for MVC - How to customize a dashboard before displaying it in a browser


This example demonstrates how to define a custom [Dashboard Storage](https://docs.devexpress.com/Dashboard/116299/web-dashboard/aspnet-web-forms-dashboard-control/prepare-dashboard-storage) and override the **LoadDashboard** method that is used to load dashboards. From this method, you can edit the loaded dashboard and provide the updated version to the ASP.NET MVC Dashboard control. In this example, a custom descendant of the [DashboardFileStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardFileStorage) class is created. It allows defining the default parameter value and customizing the data source query to filter displayed data.

## More Examples
  
- [Web Dashboard - How to customize a dashboard before displaying it in a browser](https://github.com/DevExpress-Examples/web-dashboard-how-to-customize-a-dashboard-before-displaying-it-in-a-browser)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-customize-before-displaying-browser&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-customize-before-displaying-browser&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
