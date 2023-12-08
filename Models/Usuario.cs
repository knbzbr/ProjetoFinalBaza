﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBaza.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Cód. do Usuario")]

        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuario")]

        public string UsuarioNome { get; set; }=string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuario")]

        public string UsuarioEmail { get; set; }=string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuario")]

        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
