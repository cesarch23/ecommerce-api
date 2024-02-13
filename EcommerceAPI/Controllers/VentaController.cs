using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using store_app.Services;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class VentaController : Controller
    {
        private VentaService ventaServ;
        public VentaController(VentaService ventaServ) { 
            this.ventaServ = ventaServ;
        }
        [HttpGet]
        public List<Venta> lista()
        {
            return this.ventaServ.Listar();
        }
    }
}
