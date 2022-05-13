using DanoneCadastroUsuario.Domain.Entities;
using DanoneCadastroUsuario.Infrastructure.Context;
using DanoneCadastroUsuario.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Infrastructure.Repositories
{
    public class DanoneUsuarioRepository : DanoneRepositoryBase<DanoneUsuarioEntity>, IDanoneUsuarioRepository
    {
        public DanoneUsuarioRepository(DanoneCadastroUsuarioContext context) : base(context)
        {
        }
    }
}
