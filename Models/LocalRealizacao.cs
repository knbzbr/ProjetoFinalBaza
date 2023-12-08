using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("LocalReslizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name  = "Cód. do Local de Realização")]

        public int Id { get; set; }

        [Column("LocalRealizacaoNome")]
        [Display(Name = "Nome do Local Realização")]

        public string LocalRealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
