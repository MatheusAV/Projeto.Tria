using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Tria.Infra.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "Cliente");
        }
    }
}
