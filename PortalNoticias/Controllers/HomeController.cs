using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalNoticias.Models;

namespace PortalNoticias.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> TodasAsNoticias;
        public ActionResult Index()
        {
            var UltimasNoticias = TodasAsNoticias.Take(3).OrderByDescending(x => x.Data);
            ViewBag.Categorias = TodasAsNoticias.Select(x => x.Categoria).Distinct();
            return View(UltimasNoticias);
        }

        public HomeController()
        {
            TodasAsNoticias = new Noticia().getTodasAsNoticias();
        }

        public ActionResult MostraTodasAsNoticias()
        {
            return View(TodasAsNoticias);
        }

        public ActionResult MostraNoticia(int NoticiaId, string titulo, string categoria)
        {
            var umaNoticia = TodasAsNoticias.Where(x => x.NoticiaId == NoticiaId).FirstOrDefault();
            // outra forma de fazer: TodasAsNoticias.FirstOrDefault(x => x.NoticiaId == NoticiaId);
            return View(umaNoticia);
        }

        public ActionResult NoticiasPorCategoria(string categoria)
        {
            var noticiasPorCategoria = TodasAsNoticias.Where(x => x.Categoria.ToLower() == categoria).ToList();
            ViewBag.Categoria = categoria.ToUpper();
            return View(noticiasPorCategoria);
        }

    }
}