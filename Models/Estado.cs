using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Cód. do Estado")]

        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]

        public string EstadoNome { get; set; } = string.Empty;

    }
}
