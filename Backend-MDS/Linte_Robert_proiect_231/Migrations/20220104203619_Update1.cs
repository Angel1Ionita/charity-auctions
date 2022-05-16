using Microsoft.EntityFrameworkCore.Migrations;

namespace Linte_Robert_proiect_231.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cos_cumparaturi_UserId",
                table: "Cos_cumparaturi");

            migrationBuilder.CreateIndex(
                name: "IX_Cos_cumparaturi_UserId",
                table: "Cos_cumparaturi",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cos_cumparaturi_UserId",
                table: "Cos_cumparaturi");

            migrationBuilder.CreateIndex(
                name: "IX_Cos_cumparaturi_UserId",
                table: "Cos_cumparaturi",
                column: "UserId");
        }
    }
}
