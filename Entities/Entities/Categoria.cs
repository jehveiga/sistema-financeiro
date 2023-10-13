using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Categoria")]
    public class Categoria : Base
    {
        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int SistemaId { get; set; }
        // EF Relation
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
