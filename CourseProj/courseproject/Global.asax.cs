using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using Michaels_Stuff.Dal;
using Michaels_Stuff.App_Start;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Michaels_Stuff
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //This will create the database the first time and run the initilizer in the Dal
            //write your seed data there
            Database.SetInitializer<KendallsoftEntity>(new kendallsoftInitializer());

            using (var context = new KendallsoftEntity())
            {
                context.Database.Initialize(true);
            }

            //WebAPI Stuff for Serialization Problem
            //HttpConfiguration config = GlobalConfiguration.Configuration;
            //((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;

            //MKExplained
            //Needs to be called early if you want to use the Web API
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           
        }
    }
}
