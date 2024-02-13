using EcommerceAPI.Models;
using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private ProductoServicio productoServicio;
        public ProductoController( ProductoServicio productService){
            productoServicio = productService;
         }
        [HttpGet]
        public List<Producto> productList()
        {
            return this.productoServicio.Listar();
        }
    }
}
