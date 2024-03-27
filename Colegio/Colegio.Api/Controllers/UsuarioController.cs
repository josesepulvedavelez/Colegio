using Colegio.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository) 
        { 
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("IniciarSesion/{usuario}/{contrasena}")]
        public async Task<IActionResult> IniciarSesion(string usuario, string contrasena)
        {
            var result = await _usuarioRepository.IniciarSesion(usuario, contrasena);
            return Ok(result);
        }

    }
}
