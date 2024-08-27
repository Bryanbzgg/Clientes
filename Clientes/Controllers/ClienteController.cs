using Clientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(1, "manojotajota", "éujotajota@gmail.co", "7334-5278", new DateOnly(2000, 6, 1));
            Cliente c3 = new Cliente(2, "manorato", "éuratojoga@gmail.co", "9876-5434", new DateOnly(2000, 6, 1));
            Cliente c4 = new Cliente(4, "shereki", "oshereki@gmail.co", "9237-5489", new DateOnly(2000, 6, 1));
            Cliente c5 = new Cliente(5, "carlindolavas", "lavajato@gmail.co", "8756-4372", new DateOnly(2000, 6, 1));

            List<Cliente> listClientes = new List<Cliente>();

            listClientes.Add(c1);
            listClientes.Add(c2);
            listClientes.Add(c3);
            listClientes.Add(c4);
            listClientes.Add(c5);


            return View(listClientes);
        }
    }
}
