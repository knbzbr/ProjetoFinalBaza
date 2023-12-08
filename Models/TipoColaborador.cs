using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Cód. do Tipo de Colaborador")]

        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome do Tipo de Colaborador")]

        public string TipoColaboradorNome { get; set; } = string.Empty;



    }
}
