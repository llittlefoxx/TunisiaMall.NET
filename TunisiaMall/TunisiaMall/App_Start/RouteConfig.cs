using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TunisiaMall
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //indique au compilateur qu'on va ajouter plusieurs routes
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                //nom de l'action
               name: "welcom",
               url: "{controller}/{action}/{a}/{b}"
           //http://localhost:2860/Hello/welcom/1/2
           //on active la 3éme ligne si nous avons le meme nom d'action dans differents controlleurs
           //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }

    }
}
