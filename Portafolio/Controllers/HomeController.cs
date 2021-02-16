using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Food()
        {
            ViewData["Message"] = "Página de Comida";

            return View();
        }

        public IActionResult Shoes()
        {
            ViewData["Message"] = "Página de Zapatos";

            return View();
        }

        public IActionResult Kids()
        {
            ViewData["Message"] = "Página de Niños";

            return View();
        }

        public IActionResult HairSalon()
        {
            ViewData["Message"] = "Página de Estética y Salón de Belleza";

            return View();
        }

        public IActionResult Music()
        {
            ViewData["Message"] = "Página de Música";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Acerca de.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contacto.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
