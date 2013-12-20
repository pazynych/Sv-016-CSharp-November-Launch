using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FreeShop.Common;

using log4net;
using log4net.Config;

namespace FreeShop.DAL
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(WebApiApplication)); 
        
        protected void Application_Start()
        {
            
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            log.Info("Logger test");
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
