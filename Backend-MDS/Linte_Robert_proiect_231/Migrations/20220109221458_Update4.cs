using Microsoft.EntityFrameworkCore.Migrations;

namespace Linte_Robert_proiect_231.Migrations
{
    public partial class Update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cos_Produse_Cos_cumparaturi_Cos_CumparaturiId",
                table: "Cos_Produse");

            migrationBuilder.DropForeignKey(
                name: "FK_Cos_Produse_Produse_ProdusId",
                table: "Cos_Produse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cos_Produse",
                table: "Cos_Produse");

            migrationBuilder.RenameTable(
                name: "Cos_Produse",
                newName: "Cos_Produs");

            migrationBuilder.RenameIndex(
                name: "IX_Cos_Produse_ProdusId",
                table: "Cos_Produs",
                newName: "IX_Cos_Produs_ProdusId");

            migrationBuilder.RenameIndex(
                name: "IX_Cos_Produse_Cos_CumparaturiId",
                table: "Cos_Produs",
                newName: "IX_Cos_Produs_Cos_CumparaturiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cos_Produs",
                table: "Cos_Produs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cosproduse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    Cantitate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cosproduse", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cos_Produs_Cos_cumparaturi_Cos_CumparaturiId",
                table: "Cos_Produs",
                column: "Cos_CumparaturiId",
                principalTable: "Cos_cumparaturi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cos_Produs_Produse_ProdusId",
                table: "Cos_Produs",
                column: "ProdusId",
                principalTable: "Produse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cos_Produs_Cos_cumparaturi_Cos_CumparaturiId",
                table: "Cos_Produs");

            migrationBuilder.DropForeignKey(
                name: "FK_Cos_Produs_Produse_ProdusId",
                table: "Cos_Produs");

            migrationBuilder.DropTable(
                name: "Cosproduse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cos_Produs",
                table: "Cos_Produs");

            migrationBuilder.RenameTable(
                name: "Cos_Produs",
                newName: "Cos_Produse");

            migrationBuilder.RenameIndex(
                name: "IX_Cos_Produs_ProdusId",
                table: "Cos_Produse",
                newName: "IX_Cos_Produse_ProdusId");

            migrationBuilder.RenameIndex(
                name: "IX_Cos_Produs_Cos_CumparaturiId",
                table: "Cos_Produse",
                newName: "IX_Cos_Produse_Cos_CumparaturiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cos_Produse",
                table: "Cos_Produse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cos_Produse_Cos_cumparaturi_Cos_CumparaturiId",
                table: "Cos_Produse",
                column: "Cos_CumparaturiId",
                principalTable: "Cos_cumparaturi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cos_Produse_Produse_ProdusId",
                table: "Cos_Produse",
                column: "ProdusId",
                principalTable: "Produse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
