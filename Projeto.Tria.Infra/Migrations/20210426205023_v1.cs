using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Tria.Infra.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeDoCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtAtendimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HrAtendimento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosSrvico",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmProduto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosSrvico", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProdutosSrvico",
                columns: table => new
                {
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: false),
                    ProdutosIdProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProdutosSrvico", x => new { x.ClienteIdCliente, x.ProdutosIdProduto });
                    table.ForeignKey(
                        name: "FK_ClienteProdutosSrvico_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteProdutosSrvico_ProdutosSrvico_ProdutosIdProduto",
                        column: x => x.ProdutosIdProduto,
                        principalTable: "ProdutosSrvico",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProdutosSrvico_ProdutosIdProduto",
                table: "ClienteProdutosSrvico",
                column: "ProdutosIdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteProdutosSrvico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ProdutosSrvico");
        }
    }
}
