using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BunnyStudioApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Defaultt",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Task", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Defaultt3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default1ee",
                url: "api/{controller}/{id}",
                defaults: new { controller = "Task", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Default1tt",
               url: "api/{controller}/{id}",
               defaults: new { controller = "User", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Default1eeasdasd",
               url: "api/{controller}",
               defaults: new { controller = "Task", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Default1ttads",
               url: "api/{controller}",
               defaults: new { controller = "User", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Default1yty",
               url: "{api}/{controller}/{id}",
               defaults: new { controller = "Home", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default2",
                url: "{api}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default3",
                url: "{api}/{controller}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default4",
                url: "{api}/{controller}/{action}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default5",
                url: "{api}/{action}",
                defaults: new { controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
