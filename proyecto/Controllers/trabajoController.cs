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

        // dtrabajo/id
        public async Task<IActionResult> dtrabajo(int? id)
        {
            if (id == null || _EmpleoDBContext.trabajo == null)
            {
                return NotFound();
            }

            var trabajos = await _EmpleoDBContext.trabajo
                .FirstOrDefaultAsync(t => t.id_trabajo == id);
            if (trabajos == null)
            {
                return NotFound();
            }

            return View(trabajos);
        }
    }
}
