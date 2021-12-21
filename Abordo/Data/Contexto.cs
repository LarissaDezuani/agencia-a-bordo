using Abordo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abordo.Data
{
    public class Contexto : DbContext
    //esta classe vai herdar DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opitionsBuilder)
        {
            opitionsBuilder.UseSqlServer("Data Source=LAPTOP-DU1D5PMO\\MSSQLSERVER01;Initial Catalog=Abordo;Integrated Security=True");
        }
        public DbSet<Cadastrar> Cadastrars { get; set; }
        //vai setar a class Cliente e vai chamar a propiedade de Clientes

        //este medoto e para a string de conecção com o bd
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Contato> Contatos { get; set; }


        //este metodo OnModelCreateing() recebe um obj da classe ModelBuilder chamada 
        //modelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cadastrar>(table => {
                table.ToTable("Cadastrars");
                table.HasKey(prop => prop.IdCli);
                table.Property(prop => prop.NomeCli).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPFCli).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.NasCli).HasColumnType("date");
                table.Property(prop => prop.CEPCli).HasColumnType("char(9)");
                table.Property(prop => prop.BairroCli).HasColumnType("char(25)");
                table.Property(prop => prop.EnderecoCli).HasColumnType("char(25)");
                table.Property(prop => prop.NumeroCli).HasColumnType("char(7)");
                table.Property(prop => prop.TelefoneCli).HasColumnType("char(13)");
                table.Property(prop => prop.EmailCli).HasColumnType("char(30)");

                table.Property(prop => prop.Situacao).HasConversion<String>().HasMaxLength(9);
                //IsRequired = para n deixar o valor nulo

            });


            modelBuilder.Entity<Destino>(table => {
                table.ToTable("Destinos");
                table.HasKey(prop => prop.IdDestino);
                table.Property(prop => prop.NomeDestino).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPFCli).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.PartidaDestino).HasColumnType("char(25)");
                table.Property(prop => prop.HoraDestino).HasColumnType("char(25)");
                table.Property(prop => prop.DataDestina).HasColumnType("char(25)");

            });
            modelBuilder.Entity<Contato>(table => {
                table.ToTable("Contatos");
                table.HasKey(prop => prop.IdContato);
                table.Property(prop => prop.NomeContato).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.EmailContato).HasColumnType("char(20)").IsRequired();
                table.Property(prop => prop.MsgContato).HasColumnType("char(25)");

            });


        }
        //modelBuilder =obj   
        // e acessa metodo=Entity
        //Cliente mapear o modelo Cliente
        // o nome vai ser Clientes
        ////////////////////////destino/////////////////////////////
        

    }

}
