using Prueba.Cors.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Prueba.Cors
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            //var cors = new EnableCorsAttribute("https://localhost:44372","*","*","*");
            //config.EnableCors(cors);

            //sin whitelist
            config.EnableCors();

            // Añade el DomainFilterHandler al pipeline de manejo de mensajes
            //config.MessageHandlers.Add(new DomainFilterHandler("https://localhost:44380", "*", "*"));


            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
