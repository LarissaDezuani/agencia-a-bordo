using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abordo.Migrations
{
    public partial class FistMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastrars",
                columns: table => new
                {
                    IdCli = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCli = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CPFCli = table.Column<string>(type: "char(11)", nullable: false),
                    NasCli = table.Column<DateTime>(type: "date", nullable: false),
                    CEPCli = table.Column<string>(type: "char(9)", nullable: true),
                    BairroCli = table.Column<string>(type: "char(25)", nullable: true),
                    EnderecoCli = table.Column<string>(type: "char(25)", nullable: true),
                    NumeroCli = table.Column<string>(type: "char(7)", nullable: false),
                    TelefoneCli = table.Column<string>(type: "char(13)", nullable: false),
                    EmailCli = table.Column<string>(type: "char(30)", nullable: true),
                    Situacao = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastrars", x => x.IdCli);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    IdContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeContato = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EmailContato = table.Column<string>(type: "char(20)", nullable: false),
                    MsgContato = table.Column<string>(type: "char(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.IdContato);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    IdDestino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPFCli = table.Column<string>(type: "char(11)", nullable: false),
                    PartidaDestino = table.Column<string>(type: "char(25)", nullable: true),
                    NomeDestino = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    HoraDestino = table.Column<string>(type: "char(25)", nullable: true),
                    DataDestina = table.Column<string>(type: "char(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.IdDestino);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastrars");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
