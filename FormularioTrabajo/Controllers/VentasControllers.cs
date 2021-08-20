
using Microsoft.AspNetCore.Mvc;
using FormularioTrabajo.Models;

namespace FormularioTrabajo.Controllers
{    
    public class VentasController: Controller
    {
    public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HacerVenta(Ventas objHacerVenta)
        {
            double Subtotal=0;
            double Total=0;
            double IGV=1.18;
            Subtotal =objHacerVenta.Cantidad*objHacerVenta.PrecioProducto;
            Total = Subtotal*IGV;
            ViewData["Message"] = "TOTAL DE VENTA: "+ Total;
            return View("Index");
        }
    }
}