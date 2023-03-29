using Microsoft.AspNetCore.Mvc;

namespace AulaWebApp.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
