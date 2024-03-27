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
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly ColegioContext _colegioContext;
        
        public UsuarioRepository(ColegioContext colegioContext) 
        { 
            _colegioContext = colegioContext;
        }

        public async Task<bool> IniciarSesion(string usuario, string contrasena)
        {
            var result = await _colegioContext.Usuario
                                 .FirstOrDefaultAsync(x => x.NombreUsuario == usuario &&
                                                      x.Contrasena == contrasena);
            if (result != null)
            {
                UsuarioDto.NombreUsuario = result.NombreUsuario;
                UsuarioDto.Nivel = result.Nivel;
                UsuarioDto.Estado = result.Estado;
                UsuarioDto.UsuarioId = result.UsuarioId;
            }

            return result != null;
        }

    }
}
