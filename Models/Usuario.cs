using Microsoft.AspNetCore.Identity;

namespace LoginUsuarioAPI.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario(): base() { }
    }
}
