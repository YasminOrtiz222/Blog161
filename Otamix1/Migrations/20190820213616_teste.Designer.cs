﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Otamix1.Models;

namespace Otamix1.Migrations
{
    [DbContext(typeof(Otamix1Context))]
    [Migration("20190820213616_teste")]
    partial class teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Otamix1.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCat");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Otamix1.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<int>("DataMensagem");

                    b.Property<int>("DescricaoId");

                    b.Property<int>("MensagemId");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoId");

                    b.HasIndex("MensagemId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("Otamix1.Models.Descricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Descricao");
                });

            modelBuilder.Entity("Otamix1.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<string>("DataMensagem");

                    b.Property<string>("Descricao");

                    b.Property<string>("TItulo");

                    b.HasKey("Id");

                    b.ToTable("Mensagem");
                });

            modelBuilder.Entity("Otamix1.Models.Comentario", b =>
                {
                    b.HasOne("Otamix1.Models.Descricao", "Descricao")
                        .WithMany()
                        .HasForeignKey("DescricaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Otamix1.Models.Mensagem", "Mensagem")
                        .WithMany()
                        .HasForeignKey("MensagemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}