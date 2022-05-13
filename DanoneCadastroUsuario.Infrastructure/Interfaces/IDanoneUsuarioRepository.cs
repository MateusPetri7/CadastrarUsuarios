using DanoneCadastroUsuario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Infrastructure.Interfaces
{
    public interface IDanoneUsuarioRepository : IRepositoryAsync<DanoneUsuarioEntity>
    { }
}
