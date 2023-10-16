using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("UserSystemFinancial")]
    public class UserSystemFinancial
    {
        public int Id { get; set; }
        public string EmailUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool SistemaAtual { get; set; }

        [ForeignKey("SystemFinancial")]
        [Column(Order = 1)]
        public int SistemaId { get; set; }
        // EF Relation
        public virtual SystemFinancial SystemFinancial { get; set; }
    }
}
