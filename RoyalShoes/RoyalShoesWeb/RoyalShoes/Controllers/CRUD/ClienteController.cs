using Microsoft.AspNetCore.Mvc;
using RoyalShoes.DataAccess.CRUD;
using RoyalShoes.Models.CRUD;

namespace RoyalShoes.Controllers.CRUD
{
    public class ClienteController : Controller
    {
        private readonly ClienteDataAccess _cliente;

        public ClienteController(IConfiguration configuration)
        {
            _cliente = new ClienteDataAccess(configuration);
        }

        // GET: ClienteController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: ClienteController/Details/5
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ClienteModels> clientes = await _cliente.Mostrar();

            // Resto del código del controlador

            return View(clientes);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(ClienteModels Registrar)
        {
            if (ModelState.IsValid)
            {
                bool registrado = await _cliente.Guardar(Registrar);
                if (registrado)
                {
                    // Registro exitoso, redireccionar a una página de éxito o realizar alguna otra acción
                    return RedirectToAction("Index");
                }
                else
                {
                    // Error en el registro, mostrar un mensaje de error o realizar alguna otra acción
                    ModelState.AddModelError("", "Error en el registro. Por favor, inténtalo nuevamente.");
                }
            }
            return View(Registrar);
        }

        public IActionResult Editar()
        {
            return View();
        }
    }
}
