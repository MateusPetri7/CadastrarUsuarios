namespace DanoneCadastroUsuario.Application.Dto
{
    public class DanoneUsuarioDto
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }

        public DanoneUsuarioDto(Guid id, string login, string password, string email, char sexo)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            Sexo = sexo;
        }
    }
}
