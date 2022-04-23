using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica_1.Migrations
{
    public partial class addedIndextoEntranceAndEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
               name: "IX_Tickets_Document",
               table: "Tickets",
               column: "Document",
               unique: true,
               filter: "[Document] IS NOT NULL");
            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Description",
                table: "Entrances",
                column: "Description",
                unique: true,
                filter: "[Description] IS NOT NULL");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
               name: "IX_Tickets_Document",
               table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_Description",
                table: "Entrances");

        }
    }
}
