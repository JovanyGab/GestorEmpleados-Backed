using Microsoft.AspNetCore.Mvc;

namespace GI.GestorInventarios.API.Controllers
{
    public class InventariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
