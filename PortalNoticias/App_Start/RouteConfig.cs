using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortalNoticias
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute
                (
                name : "Todas",
                url : "noticias/",
                defaults: new { controller="Home", action="MostraTodasAsNoticias"}
                );

            routes.MapRoute(name: "categorias", url : "noticias/{categoria}", defaults: new { controller = "Home", action = "NoticiasPorCategoria" });

            routes.MapRoute(name: "veja", url: "noticias/{categoria}/{titulo}-{NoticiaId}", defaults: new { controller = "Home", action = "MostraNoticia"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
