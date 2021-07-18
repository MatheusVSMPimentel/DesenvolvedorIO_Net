using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMVC.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProdutora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFundador = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Oscars = table.Column<int>(type: "int", nullable: false),
                    ValorPatrimonial = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diretores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDiretor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OscarFilmesDirigidos = table.Column<int>(type: "int", nullable: false),
                    ProdutoraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diretores_Produtoras_ProdutoraId",
                        column: x => x.ProdutoraId,
                        principalTable: "Produtoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IdProdutora = table.Column<int>(type: "int", nullable: false),
                    Oscar = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoraResponsavelId = table.Column<int>(type: "int", nullable: true),
                    DiretorGeralId = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AluguelSemana = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Avaliacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_Diretores_DiretorGeralId",
                        column: x => x.DiretorGeralId,
                        principalTable: "Diretores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Filmes_Produtoras_ProdutoraResponsavelId",
                        column: x => x.ProdutoraResponsavelId,
                        principalTable: "Produtoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diretores_ProdutoraId",
                table: "Diretores",
                column: "ProdutoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_DiretorGeralId",
                table: "Filmes",
                column: "DiretorGeralId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_ProdutoraResponsavelId",
                table: "Filmes",
                column: "ProdutoraResponsavelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Diretores");

            migrationBuilder.DropTable(
                name: "Produtoras");
        }
    }
}
