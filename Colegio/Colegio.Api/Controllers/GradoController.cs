using Colegio.Core.Interfaces;
using Colegio.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoController : ControllerBase
    {
        private readonly IGradoRepository _gradoRepository;

        public GradoController(IGradoRepository gradoRepository) 
        { 
            _gradoRepository = gradoRepository;
        }

        [HttpGet("ConsultarGrados")]
        public async Task<IActionResult> ConsultarGrados()
        { 
            var grados = await _gradoRepository.ConsultarGrados();

            return Ok(grados);
        }

        [HttpPost("GuardarGrado")]
        public async Task<IActionResult> GuardarGrado(Grado grado)
        {
            var gradox = await _gradoRepository.GuardarGrado(grado);

            return Ok(gradox);
        }

        [HttpPut("ActualizarGrado")]
        public async Task<IActionResult> ActualizarGrado(int id, Grado grado)
        { 
            var gradox = await _gradoRepository.ActualizarGrado(id, grado);

            return Ok(gradox);
        }

    }
}
