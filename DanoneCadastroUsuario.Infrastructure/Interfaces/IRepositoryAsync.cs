using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Infrastructure.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        Task Add(T entity);
        Task<List<T>> Get();
        Task<T> GetByGuid(Guid id);
    }
}
