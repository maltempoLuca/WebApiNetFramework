using System.Web.Http;

namespace WebApiNetFramework
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable attribute-based routing for Web API
            config.MapHttpAttributeRoutes();

            // Default Web API route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
