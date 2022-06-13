using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity_Auctions.Migrations
{
    public partial class AddedPosterCharity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Charity_name",
                table: "Produse",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Poster_name",
                table: "Produse",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Charity_name",
                table: "Produse");

            migrationBuilder.DropColumn(
                name: "Poster_name",
                table: "Produse");
        }
    }
}
