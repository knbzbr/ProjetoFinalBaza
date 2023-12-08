using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Cód. do Tipo de Procedimento")]

        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome do Tipo de Procedimento")]

        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
