﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_Gamer2.Infra;

#nullable disable

namespace Projeto_Gamer2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230530114434_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projeto_Gamer2.Models.Equipes", b =>
                {
                    b.Property<int>("IdEquipe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipe"));

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEquipe");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("Projeto_Gamer2.Models.Jogador", b =>
                {
                    b.Property<int>("IdJogador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJogador"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEquipe")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJogador");

                    b.HasIndex("IdEquipe");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("Projeto_Gamer2.Models.Jogador", b =>
                {
                    b.HasOne("Projeto_Gamer2.Models.Equipes", "Equipe")
                        .WithMany("Jogador")
                        .HasForeignKey("IdEquipe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("Projeto_Gamer2.Models.Equipes", b =>
                {
                    b.Navigation("Jogador");
                });
#pragma warning restore 612, 618
        }
    }
}
