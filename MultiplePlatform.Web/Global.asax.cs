using Autofac;
using Autofac.Integration.Mvc;
using MultiplePlatform.Data;
using MultiplePlatform.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MultiplePlatform.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            //依赖注入
            AutofacEngine.RegisterAutofac();


        }
    }
}
