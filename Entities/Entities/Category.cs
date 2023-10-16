using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Category")]
    public class Category : Base
    {
        [ForeignKey("SystemFinancial")]
        [Column(Order = 1)]
        public int SistemaId { get; set; }
        // EF Relation
        public virtual SystemFinancial SystemFinancial { get; set; }
    }
}
