using Colegio.Core.Interfaces;
using Colegio.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Infra.Repositories
{
    public class EstudianteRepository: IEstudianteRepository
    {
        private readonly ColegioContext _colegioContext;

        public EstudianteRepository(ColegioContext colegioContext)
        { 
            _colegioContext = colegioContext;
        }

        public async Task<IEnumerable<Estudiante>> ConsultarEstudiantes()
        {
            var result = await _colegioContext.Estudiante.ToListAsync();

            return result;
        }

        public async Task<int> GuardarEstudiante(Estudiante estudiante)
        {
            var result = await _colegioContext.Estudiante.AddAsync(estudiante);
            await _colegioContext.SaveChangesAsync();

            return estudiante.EstudianteId;
        }

    }
}
