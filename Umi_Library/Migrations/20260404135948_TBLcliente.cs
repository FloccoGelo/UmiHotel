using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umi_Library.Migrations
{
    /// <inheritdoc />
    public partial class TBLcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCli = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(120)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(25)", nullable: true),
                    CPF = table.Column<string>(type: "varchar(16)", nullable: false),
                    RG = table.Column<string>(type: "varchar(16)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Telefone1 = table.Column<string>(type: "varchar(20)", nullable: true),
                    Telefone2 = table.Column<string>(type: "varchar(20)", nullable: true),
                    Email = table.Column<string>(type: "varchar(120)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
