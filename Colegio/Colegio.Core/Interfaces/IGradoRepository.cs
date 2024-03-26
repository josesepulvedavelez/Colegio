using Colegio.Core.Dtos;
using Colegio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IGradoRepository
    {
        Task<IEnumerable<Grado>> ConsultarGrados();
        Task<int> GuardarGrado(Grado grado);
        Task<int> ActualizarGrado(int id, Grado gradoActualizado);
    }
}
