using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanoneCadastroUsuario.Domain.Entities
{
    public class DanoneUsuarioEntity : EntityBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }
        public DanoneUsuarioEntity(string login, string password, string email, char sexo)
        {
            Login = login;
            Password = password;
            Email = email;
            Sexo = sexo;    
        }
    }
}
