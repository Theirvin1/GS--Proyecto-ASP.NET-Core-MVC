using Microsoft.AspNetCore.Mvc;
using ProyectoMCV.Models;

namespace ProyectoMCV.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> _productos = new List<Producto>();

        public IActionResult Index()
        {
            return View(_productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = _productos.Count + 1;
                _productos.Add(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
            return RedirectToAction("Index");
        }
    }
}