using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser // Adicionar uma propriedade para classe do identity
    {
        [Column("USR_CPF")]
        public string Cpf { get; set; }
    }
}
