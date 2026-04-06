using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Umi_Library.Migrations
{
    /// <inheritdoc />
    public partial class novoQuarto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quarto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    NumSolt = table.Column<int>(type: "int", nullable: false),
                    NumCasal = table.Column<int>(type: "int", nullable: false),
                    PrecoBase = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrecoAtual = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quarto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quarto");
        }
    }
}
