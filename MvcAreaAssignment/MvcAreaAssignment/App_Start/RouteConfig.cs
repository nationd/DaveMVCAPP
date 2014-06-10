﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAreaAssignment
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
               defaults: new { controller = "Management", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Areas.ContactDetails.Controllers"}
            ).DataTokens.Add("area","ContactDetails");
        }
    }
}