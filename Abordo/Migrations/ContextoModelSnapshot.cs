﻿// <auto-generated />
using System;
using Abordo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Abordo.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abordo.Models.Cadastrar", b =>
                {
                    b.Property<int>("IdCli")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BairroCli")
                        .HasColumnType("char(25)");

                    b.Property<string>("CEPCli")
                        .HasColumnType("char(9)");

                    b.Property<string>("CPFCli")
                        .IsRequired()
                        .HasColumnType("char(11)");

                    b.Property<string>("EmailCli")
                        .HasColumnType("char(30)");

                    b.Property<string>("EnderecoCli")
                        .HasColumnType("char(25)");

                    b.Property<DateTime>("NasCli")
                        .HasColumnType("date");

                    b.Property<string>("NomeCli")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NumeroCli")
                        .IsRequired()
                        .HasColumnType("char(7)");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("TelefoneCli")
                        .IsRequired()
                        .HasColumnType("char(13)");

                    b.HasKey("IdCli");

                    b.ToTable("Cadastrars");
                });

            modelBuilder.Entity("Abordo.Models.Contato", b =>
                {
                    b.Property<int>("IdContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailContato")
                        .IsRequired()
                        .HasColumnType("char(20)");

                    b.Property<string>("MsgContato")
                        .HasColumnType("char(25)");

                    b.Property<string>("NomeContato")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdContato");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Abordo.Models.Destino", b =>
                {
                    b.Property<int>("IdDestino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPFCli")
                        .IsRequired()
                        .HasColumnType("char(11)");

                    b.Property<string>("DataDestina")
                        .IsRequired()
                        .HasColumnType("char(25)");

                    b.Property<string>("HoraDestino")
                        .HasColumnType("char(25)");

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PartidaDestino")
                        .HasColumnType("char(25)");

                    b.HasKey("IdDestino");

                    b.ToTable("Destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
