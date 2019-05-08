using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace Versioning_WebAPI.Helper
{
    public class CustomSelectController : DefaultHttpControllerSelector
    {
        private readonly HttpConfiguration _config;
        public CustomSelectController(HttpConfiguration configuration) : base(configuration)
        {
            _config = configuration;
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            //returns all possible API Controllers
            var controllers = GetControllerMapping();
            //return the information about the route
            var routeData = request.GetRouteData();
            //get the controller name passed
            var controllerName = routeData.Values["controller"].ToString();

            string apiVersion = "1";

            //get querystring from the URI
            var versionQueryString = HttpUtility.ParseQueryString(request.RequestUri.Query);

            if(versionQueryString["version"]!=null)
            {
                apiVersion = Convert.ToString(versionQueryString["version"]);
            }

            if (apiVersion == "1")
            {
                controllerName += "V1";
            }
            else
            {
                controllerName += "V2";
            }

            if (controllers.TryGetValue(controllerName, out HttpControllerDescriptor controllerDescriptor))
            {
                return controllerDescriptor;
            }

            return null;
        }
    }
}