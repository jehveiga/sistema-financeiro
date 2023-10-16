using Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("Expense")]
    public class Expense : Base
    {
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public EnumTypeExpense TipoDespesa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        public bool DespesaAtrasada { get; set; }

        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoriaId { get; set; }

        // EF Relation
        public Category Category { get; set; }
    }
}
