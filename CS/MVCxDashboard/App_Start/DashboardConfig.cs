using System.Web.Routing;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardCommon;
using System.Xml.Linq;
using System.Linq;
using System.Data;
using DevExpress.DataAccess.Sql;

namespace MVCxDashboard {
    public class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute();

            DashboardConfigurator.Default.SetDashboardStorage(new MyDashboardFileStorage(@"~/App_Data/Dashboards/"));

        }
    
    }

    public class MyDashboardFileStorage : DashboardFileStorage {
        public MyDashboardFileStorage(string workingDirectory) : base(workingDirectory) { }
        protected override XDocument LoadDashboard(string dashboardID) {
            var doc = base.LoadDashboard(dashboardID);
            Dashboard d = new Dashboard();
            d.LoadFromXDocument(doc);
            // customization code
            var parameterCountry = d.Parameters.FirstOrDefault(p => p.Name == "CountryDashboardParameter");
            if (parameterCountry != null) {
                parameterCountry.Value = "Germany";
            }
            var nwindDataSource = d.DataSources.OfType<DashboardSqlDataSource>().FirstOrDefault(ds => ds.Name == "NwindDataSource");
            if( nwindDataSource != null) {
                var customNwindQuery = nwindDataSource.Queries.OfType<CustomSqlQuery>().FirstOrDefault(q => q.Name == "CustomInvoicesQuery");
                if(customNwindQuery != null) {
                    customNwindQuery.Sql += " AND (Invoices.OrderDate >= #2015-01-01 00:00:00#)";
                }
            }
            
            return d.SaveToXDocument();
        }
    }

}