﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Cód. do Cliente")]

        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]

        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "Cpf do Cliente")]

        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo do Cliente")]

        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do Cliente")]

        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço do Cliente")]

        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Numero do Cliente")]

        public string ClienteNumero { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

    }
}
