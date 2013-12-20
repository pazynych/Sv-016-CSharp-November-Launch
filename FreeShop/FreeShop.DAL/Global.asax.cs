using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FreeShop.Common;

namespace FreeShop.DAL
{
    public class WebApiApplication : System.Web.HttpApplication
    {
 
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // ConsoleManager.InitializeConsoleManager();
            // ConsoleManager.EventLogerInit();
            // 
            // System.Diagnostics.EventLog myLog = new System.Diagnostics.EventLog();
            // myLog.Source = "MySource";
            // 
            // // Write an informational entry to the event log.    
            // myLog.WriteEntry("Writing to event log.");
        }
    }
}
