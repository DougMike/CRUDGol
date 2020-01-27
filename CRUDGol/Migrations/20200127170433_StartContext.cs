using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDGol.Migrations
{
    public partial class StartContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronave",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(nullable: true),
                    QtdPassageiros = table.Column<int>(nullable: false),
                    DataRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeronave");
        }
    }
}
