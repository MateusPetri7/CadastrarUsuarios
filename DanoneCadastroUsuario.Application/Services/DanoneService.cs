using DanoneCadastroUsuario.Application.Dto;
using DanoneCadastroUsuario.Application.Interfaces;
using DanoneCadastroUsuario.Infrastructure.Interfaces;
using Utils;

namespace DanoneCadastroUsuario.Application.Services
{
    public class DanoneUsuarioService : IDanoneUsuarioService
    {
        private readonly IDanoneUsuarioRepository _repository;

        public DanoneUsuarioService(IDanoneUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Add(string login, string password, string email, char sexo) => _repository.Add(new Domain.Entities.DanoneUsuarioEntity(login, password, email, sexo));

        public async Task<List<DanoneUsuarioDto>> Get()
        {
            var result = await _repository.Get();

            return result.Select(x => new DanoneUsuarioDto(x.Id, x.Login, x.Password, x.Email, x.Sexo)).ToList();
        }

        public async Task<DanoneUsuarioDto> GetById(Guid id)
        {
            var result = await _repository.GetByGuid(id);
            if (result == null)
            {
                //return (EnumRetornosHttps.BadRequest, new MensagemRetornoDto($"O usuário não foi encontrado."));
            }

            return new DanoneUsuarioDto(result.Id, result.Login, result.Password, result.Email, result.Sexo);
        }
    }
}
