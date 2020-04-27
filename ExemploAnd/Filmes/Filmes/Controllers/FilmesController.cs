using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmes.Models;

namespace Filmes.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult detail()
        {
            var filme = new Models.Filme() { titulo = " Senhor dos aneis ", ano = 2000} ;
            return View(filme);
        }




    }
}