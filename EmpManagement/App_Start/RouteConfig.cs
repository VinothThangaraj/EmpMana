﻿using System.Web.Mvc;
using System.Web.Routing;

namespace EmpManagement
{
    /// <summary>
    /// Route config
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Register Routes
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Authentication", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "EmpManagement.Controllers" }
            );
        }
    }
}
