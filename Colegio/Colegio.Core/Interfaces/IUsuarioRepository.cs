using Colegio.Core.Dtos;
using Colegio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> IniciarSesion(string usuario, string contrasena);
    }
}
