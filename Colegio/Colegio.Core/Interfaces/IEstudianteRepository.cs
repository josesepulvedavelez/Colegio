using Colegio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IEstudianteRepository
    {
        Task<IEnumerable<Estudiante>> ConsultarEstudiantes();
        Task<int> GuardarEstudiante(Estudiante estudiante);
    }
}
