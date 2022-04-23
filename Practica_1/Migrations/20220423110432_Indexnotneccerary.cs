using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica_1.Migrations
{
    public partial class Indexnotneccerary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Tickets_Document",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "Entrances_Description",
                table: "Entrances");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
               name: "Tickets_Document",
               table: "Tickets",
               column: "Document",
               unique: true,
               filter: "[Document] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "Entrances_Description",
                table: "Entrances",
                column: "Description",
                unique: true,
                filter: "[Description] IS NOT NULL");

        }
    }
}
