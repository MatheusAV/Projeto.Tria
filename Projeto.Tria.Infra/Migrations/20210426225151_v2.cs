using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Tria.Infra.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtAlteracao",
                table: "Cliente",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtAlteracao",
                table: "Cliente");
        }
    }
}
