using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace RP.WebApi
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            RegisterFormatService(config);
            RegisterNullValue(config);
            RegisterHttpAttributes(config);

            RegisterMapRoute(config);

        }

        public static void RegisterNullValue(HttpConfiguration config)
        {
            //Oculta las propiedades que intenten viajar con valores NULL, esto optimiza las respuestas del servicio
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public static void RegisterFormatService(HttpConfiguration config)
        {
            // Web API configuration and services: Esto permite transformar el resultado en formato TEXT/HTML
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        }

        public static void RegisterHttpAttributes(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
        }

        public static void RegisterMapRoute(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }


    }
}
