using DanoneCadastroUsuario.Application.Interfaces;
using DanoneCadastroUsuario.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DanoneCadastroUsuario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DanoneUsuarioController : ControllerBase
    {
        private readonly IDanoneUsuarioService _usuarioService;

        public DanoneUsuarioController(IDanoneUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get() => Ok(await _usuarioService.Get());

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id) => Ok(await _usuarioService.GetById(id));

        [HttpPost]
        public IActionResult Post([FromBody] InputDanoneUsuarioDto usuarioDto)
        {
            _usuarioService.Add(usuarioDto.Login, usuarioDto.Password, usuarioDto.Email, usuarioDto.Sexo);

            return Ok();
        }
    }
}