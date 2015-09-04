using EasyWeddingMiddleLayer;
using EasyWeddingUI.UnityResolverFolder;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;

namespace EasyWeddingUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            IUnityContainer container = new UnityContainer().LoadConfiguration(section);
            config.DependencyResolver = new UnityResolver(container);

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
