﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace AutDemo.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new ErrosGlobaisFilterAttribute());

            // config.Filters.Add(new BasicAuthorization());

            // Enable Cors
            // Install-Package Microsoft.AspNet.WebApi.Cors
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );
        }
    }
}
