
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using store_app.Services;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        private ProductoVendidoService ps;
        public ProductoVendidoController(ProductoVendidoService productService) {
            this.ps = productService;
        }
        [HttpGet]
        public  List<ProductoVendido> listar()
        {
            return this.ps.Listar();
        }
    }
}
