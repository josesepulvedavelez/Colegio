using Colegio.Core.Dtos;
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
    public class GradoRepository : IGradoRepository
    {
        private readonly ColegioContext _colegioContext;

        public GradoRepository(ColegioContext colegioContext) 
        { 
            _colegioContext = colegioContext;
        }

        public async Task<IEnumerable<Grado>> ConsultarGrados()
        {
            var grados = await _colegioContext.Grado.ToListAsync();

            return grados;
        }

        public async Task<int> GuardarGrado(Grado grado)
        {
            await _colegioContext.Grado.AddAsync(grado);
            await _colegioContext.SaveChangesAsync();

            return grado.GradoId;
        }

        public async Task<int> ActualizarGrado(int id, Grado gradoActualizado)
        {
            var gradoExistente = await _colegioContext.Grado.FindAsync(id);
            await _colegioContext.Entry(gradoExistente).ReloadAsync();

            gradoExistente.GradoNombre = gradoActualizado.GradoNombre;
            gradoExistente.Observaciones = gradoActualizado.Observaciones;
            gradoExistente.Estado = gradoActualizado.Estado;

            await _colegioContext.SaveChangesAsync();

            return gradoExistente.GradoId;
        }

    }
}
