using DanoneCadastroUsuario.Domain.Entities;
using DanoneCadastroUsuario.Infrastructure.Context;
using DanoneCadastroUsuario.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Infrastructure.Repositories
{
    public class DanoneRepositoryBase<T> : IRepositoryAsync<T> where T : EntityBase
    {
        private readonly DanoneCadastroUsuarioContext _context;

        public DanoneRepositoryBase(DanoneCadastroUsuarioContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> GetByGuid(Guid id)
        {
            return await _context.Set<T>().FirstAsync(x => x.Id == id);
        }
    }
}
