//using System.Web.Http;
//using System.Web.Mvc;
//using System.Web.Optimization;
//using System.Web.Routing;

//namespace EF6_WebApi
//{
//    public class WebApiApplication : System.Web.HttpApplication
//    {
//        protected void Application_Start()
//        {
//            GlobalConfiguration.Configure(WebApiConfig.Register);
//            var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
//            xml.UseXmlSerializer = true;
//            xml.Indent = true;
            
//            AreaRegistration.RegisterAllAreas();
//            RouteConfig.RegisterRoutes(RouteTable.Routes);
//            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
//            //BundleConfig.RegisterBundles(BundleTable.Bundles);
//        }
//    }
//}
