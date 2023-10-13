using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("UsuarioSistemaFinanceiro")]
    public class UsuarioSistemaFinanceiro
    {
        public int Id { get; set; }
        public string EmailUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool SistemaAtual { get; set; }

        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int SistemaId { get; set; }
        // EF Relation
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
