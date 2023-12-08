using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using ProjetoFinalBaza.Models;

namespace ProjetoFinalBaza.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Colaborador>? Colaborador { get; set; }
        public DbSet<Estado>? Estado { get; set; }
        public DbSet<LocalRealizacao>? LocalRealizacao { get; set; }
        public DbSet<Procedimento>? Procedimento { get; set; }
        public DbSet<ProcedimentoRealizacao>? ProcedimentoRealizacao { get; set; }
        public DbSet<TipoColaborador>? TipoColaborador { get; set; }
        public DbSet<TipoProcedimento>? TipoProcedimento { get; set; }
        public DbSet<ProjetoFinalBaza.Models.Usuario>? Usuario { get; set; }
       

    }
}
