﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalBaza.Models;

#nullable disable

namespace ProjetoFinalBaza.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalBaza.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteCpf");

                    b.Property<string>("ClienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteEndereco");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("ClienteNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNumero");

                    b.Property<string>("ClienteSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteSexo");

                    b.Property<string>("ClienteTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteTelefone");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ColaboradorCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorCpf");

                    b.Property<string>("ColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorNome");

                    b.Property<string>("ColaboradorSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorSexo");

                    b.Property<string>("ColaboradorTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorTelefone");

                    b.Property<int>("TipoColaboradorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("TipoColaboradorId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.LocalRealizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("LocalRealizacaoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LocalRealizacaoNome");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("LocalReslizacao");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoNome");

                    b.Property<string>("ProcedimentoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoObservacao");

                    b.Property<int>("TipoProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoProcedimentoId");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.ProcedimentoRealizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRealizacao");

                    b.Property<int?>("LocalRealizacaoId")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoRealizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoRealizacao");

                    b.Property<int?>("ProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("LocalRealizacaoId");

                    b.HasIndex("ProcedimentoId");

                    b.ToTable("ProcedimentoRealizacao");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.TipoColaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoColaboradorNome");

                    b.HasKey("Id");

                    b.ToTable("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.TipoProcedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProcedimentoNome");

                    b.HasKey("Id");

                    b.ToTable("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Cidade", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Cliente", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Colaborador", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFinalBaza.Models.TipoColaborador", "TipoColaborador")
                        .WithMany()
                        .HasForeignKey("TipoColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.LocalRealizacao", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.Procedimento", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.TipoProcedimento", "TipoProcedimento")
                        .WithMany()
                        .HasForeignKey("TipoProcedimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProcedimento");
                });

            modelBuilder.Entity("ProjetoFinalBaza.Models.ProcedimentoRealizacao", b =>
                {
                    b.HasOne("ProjetoFinalBaza.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjetoFinalBaza.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("ProjetoFinalBaza.Models.LocalRealizacao", "LocalRealizacao")
                        .WithMany()
                        .HasForeignKey("LocalRealizacaoId");

                    b.HasOne("ProjetoFinalBaza.Models.Procedimento", "Procedimento")
                        .WithMany()
                        .HasForeignKey("ProcedimentoId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("LocalRealizacao");

                    b.Navigation("Procedimento");
                });
#pragma warning restore 612, 618
        }
    }
}
