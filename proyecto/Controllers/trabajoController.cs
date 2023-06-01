using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class trabajoController : Controller
    {
        private readonly EmpleoDBContext _EmpleoDBContext;

         public trabajoController(EmpleoDBContext EmpleoDBContext)
        { 
            _EmpleoDBContext = EmpleoDBContext;
        }

        public IActionResult Index()
        {
            var listaTrabajos = (from t in _EmpleoDBContext.trabajo select t).ToList();
            ViewData["trabajos"] = listaTrabajos;

            return View();
        }
    }
}
