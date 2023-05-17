using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
