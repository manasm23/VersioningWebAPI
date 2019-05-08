using System.Web.Http;
using System.Web.Http.Dispatcher;
using Versioning_WebAPI.Helper;

namespace Versioning_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IHttpControllerSelector), new CustomSelectController(config));
        }
    }
}
