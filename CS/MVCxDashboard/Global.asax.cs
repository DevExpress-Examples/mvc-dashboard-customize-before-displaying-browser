using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCxDashboard {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            DashboardConfig.RegisterService(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
        }

        protected void Application_Error(object sender, EventArgs e) {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            HttpContext.Current.Session["Log"] += DateTime.Now.ToLocalTime().ToString() + Environment.NewLine;
            AddToLog(exception);
            HttpContext.Current.Session["Log"] += "--------------------------------------" + Environment.NewLine + Environment.NewLine;
        }

        void AddToLog(Exception exception) {

            StringBuilder sb = new StringBuilder();            
            sb.AppendLine(exception.Message);            
            sb.AppendLine("Source File: " + HttpContext.Current.Request.RawUrl);            
            sb.AppendLine("Stack Trace: ");
            sb.AppendLine(exception.StackTrace);
            HttpContext.Current.Session["Log"] += sb.ToString();
            if (exception.InnerException != null) {
                HttpContext.Current.Session["Log"] += Environment.NewLine + "InnerException: ";
                AddToLog(exception.InnerException);
            }
            
        }


    }
}