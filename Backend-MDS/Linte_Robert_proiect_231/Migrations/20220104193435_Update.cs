using Microsoft.EntityFrameworkCore.Migrations;

namespace Linte_Robert_proiect_231.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tip",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parola",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "Tip",
                table: "Utilizatori");
        }
    }
}
