using DanoneCadastroUsuario.Application.Dto;

namespace DanoneCadastroUsuario.Application.Interfaces
{
    public interface IDanoneUsuarioService
    {
        void Add(string login, string password, string telefone, char sexo);
        Task<List<DanoneUsuarioDto>> Get();
        Task<DanoneUsuarioDto> GetById(Guid id);
    }
}
