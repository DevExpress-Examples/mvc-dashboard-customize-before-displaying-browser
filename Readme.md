# How to customize a dashboard before displaying it in a browser


<p>This example demonstrates how to define a custom <a href="https://documentation.devexpress.com/Dashboard/116299/Building-the-Designer-and-Viewer-Applications/Web-Dashboard/ASP-NET-Dashboard-Control/Preparing-a-Dashboard-Storage">Dashboard Storage</a> and override the <strong>LoadDashboard </strong>method that is used to load dashboards. From this method, you can edit the loaded dashboard and provide the updated version to the MVCxDashboard control. In this example, a custom descendant of the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardFileStorage.class">DashboardFileStorage</a> class is created. It allows defining the default parameter value and customizing the data source query to filter displayed data.</p>

<br/>


