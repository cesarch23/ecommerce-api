using EcommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using store_app.Services;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : Controller
    {
        private readonly UsuarioService uServ;
        public UsuarioController(UsuarioService usuarioService) {
            this.uServ = usuarioService;
        }
        [HttpGet]
        public List<Usuario> listar()
        {
            return this.uServ.Listar();
        }
    }
}
