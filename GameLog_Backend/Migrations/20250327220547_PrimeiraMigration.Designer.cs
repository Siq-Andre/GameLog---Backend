﻿// <auto-generated />
using System;
using GameLog_Backend.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameLog_Backend.Migrations
{
    [DbContext(typeof(GameLogContext))]
    [Migration("20250327220547_PrimeiraMigration")]
    partial class PrimeiraMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameLog_Backend.Entities.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AvaliacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<int>("JogoId")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<string>("TextoAvaliacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.CurtidaDeAvaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CurtidaDeAvaliacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvaliacaoId")
                        .HasColumnType("int");

                    b.Property<bool>("Curtida")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("CurtidasDeAvaliacoes");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmpresaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("NomeEmpresa")
                        .IsUnique();

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GeneroId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("TituloGenero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("TituloGenero")
                        .IsUnique();

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JogoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassificacaoIndicativa")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DataLancamento")
                        .HasColumnType("date");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.RespostaDeAvaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RespostaDeAvaliacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvaliacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("RespostasDeAvaliacao");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.SegueUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioSeguidoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioSeguidorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioSeguidoId");

                    b.HasIndex("UsuarioSeguidorId");

                    b.ToTable("SegueUsuarios");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("EstaAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("FotoDePerfil")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GeneroJogo", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("JogosId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "JogosId");

                    b.HasIndex("JogosId");

                    b.ToTable("JogoGenero", (string)null);
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Avaliacao", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLog_Backend.Entities.Usuario", null)
                        .WithMany("Avaliacoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.CurtidaDeAvaliacao", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Avaliacao", null)
                        .WithMany("CurtidasDeAvaliacao")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Jogo", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.RespostaDeAvaliacao", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Avaliacao", null)
                        .WithMany("RespostasDeAvaliacao")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLog_Backend.Entities.SegueUsuario", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Usuario", "UsuarioSeguido")
                        .WithMany()
                        .HasForeignKey("UsuarioSeguidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GameLog_Backend.Entities.Usuario", "UsuarioSeguidor")
                        .WithMany()
                        .HasForeignKey("UsuarioSeguidorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UsuarioSeguido");

                    b.Navigation("UsuarioSeguidor");
                });

            modelBuilder.Entity("GeneroJogo", b =>
                {
                    b.HasOne("GameLog_Backend.Entities.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameLog_Backend.Entities.Jogo", null)
                        .WithMany()
                        .HasForeignKey("JogosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Avaliacao", b =>
                {
                    b.Navigation("CurtidasDeAvaliacao");

                    b.Navigation("RespostasDeAvaliacao");
                });

            modelBuilder.Entity("GameLog_Backend.Entities.Usuario", b =>
                {
                    b.Navigation("Avaliacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
