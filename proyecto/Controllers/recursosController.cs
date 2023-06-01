using Microsoft.AspNetCore.Mvc;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class recursosController : Controller
    {
        private readonly EmpleoDBContext _EmpleoDBContext;

        public recursosController(EmpleoDBContext EmpleoDBContext)
        {
            _EmpleoDBContext = EmpleoDBContext;
        }

        public IActionResult Index()
        {
            var listaRecursos = (from t in _EmpleoDBContext.recursos select t).ToList();
            ViewData["recursos"] = listaRecursos;

            return View();
        }
    }
}
