using AulaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Manha;

namespace AulaWebApp.Controllers
{
    public class HomeController : Controller
    {   
        // Atributo da classe 
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto db;

        public HomeController(Contexto db, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.db = db;
        }

        // Action result delvolbe a tela (html)
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult bemvindo()
        {
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