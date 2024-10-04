using Colegio.Core.Interfaces;
using Colegio.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteRepository _estudianteRepository;
        
        public EstudianteController(IEstudianteRepository estudianteRepository) 
        { 
            _estudianteRepository = estudianteRepository;
        }

        [HttpGet("ConsultarEstudiantes")]
        public async Task<IActionResult> ConsultarEstudiantes()
        {
            var result = await _estudianteRepository.ConsultarEstudiantes();

            return Ok(result);
        }

        [HttpPost("GuardarEstudiante")]
        public async Task<IActionResult> GuardarEstudiante([FromBody] Estudiante estudiante)
        {
            var result = await _estudianteRepository.GuardarEstudiante(estudiante);

            return Ok(result);
        }

    }
}
