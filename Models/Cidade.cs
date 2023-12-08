using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Cód. da Cidade")]

        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]

        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]

        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
