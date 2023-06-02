using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpleoDBContext _EmpleoDBContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, EmpleoDBContext EmpleoDBContext)
        {
            _logger = logger;
            _EmpleoDBContext = EmpleoDBContext;
        }

        public IActionResult Index()
        {
            var listaTrabajos = (from t in _EmpleoDBContext.trabajo select t).ToList().OrderByDescending(t => t.salario).Take(3);
            ViewData["trabajos"] = listaTrabajos;

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