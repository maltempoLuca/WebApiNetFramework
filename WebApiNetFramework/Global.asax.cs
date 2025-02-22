using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiNetFramework
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
        protected void Application_BeginRequest()
        {
            // Redirect to Swagger UI automatically when the application starts
            if (HttpContext.Current.Request.Url.AbsolutePath == "/")
            {
                HttpContext.Current.Response.Redirect("/swagger", true);
            }
        }
    }
}