using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Linte_Robert_proiect_231.Migrations
{
    public partial class Migratii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabel_Marimi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S = table.Column<int>(type: "int", nullable: false),
                    M = table.Column<int>(type: "int", nullable: false),
                    L = table.Column<int>(type: "int", nullable: false),
                    XL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabel_Marimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizatori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cos_cumparaturi_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizatori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pret = table.Column<float>(type: "real", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url_poza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabel_MarimiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produse_Tabel_Marimi_Tabel_MarimiId",
                        column: x => x.Tabel_MarimiId,
                        principalTable: "Tabel_Marimi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comenzi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa_livrare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_comanda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenzi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comenzi_Utilizatori_Userid",
                        column: x => x.Userid,
                        principalTable: "Utilizatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cos_cumparaturi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cos_cumparaturi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cos_cumparaturi_Utilizatori_UserId",
                        column: x => x.UserId,
                        principalTable: "Utilizatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produs_Comanda",
                columns: table => new
                {
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cantitate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produs_Comanda", x => new { x.ComandaId, x.ProdusId });
                    table.ForeignKey(
                        name: "FK_Produs_Comanda_Comenzi_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comenzi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produs_Comanda_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cos_Produs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    Cantitate = table.Column<int>(type: "int", nullable: false),
                    Cos_cumparaturi_Id = table.Column<int>(type: "int", nullable: false),
                    Cos_CumparaturiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cos_Produs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cos_Produs_Cos_cumparaturi_Cos_CumparaturiId",
                        column: x => x.Cos_CumparaturiId,
                        principalTable: "Cos_cumparaturi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cos_Produs_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_Userid",
                table: "Comenzi",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Cos_cumparaturi_UserId",
                table: "Cos_cumparaturi",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cos_Produs_Cos_CumparaturiId",
                table: "Cos_Produs",
                column: "Cos_CumparaturiId");

            migrationBuilder.CreateIndex(
                name: "IX_Cos_Produs_ProdusId",
                table: "Cos_Produs",
                column: "ProdusId");

            migrationBuilder.CreateIndex(
                name: "IX_Produs_Comanda_ProdusId",
                table: "Produs_Comanda",
                column: "ProdusId");

            migrationBuilder.CreateIndex(
                name: "IX_Produse_Tabel_MarimiId",
                table: "Produse",
                column: "Tabel_MarimiId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cos_Produs");

            migrationBuilder.DropTable(
                name: "Produs_Comanda");

            migrationBuilder.DropTable(
                name: "Cos_cumparaturi");

            migrationBuilder.DropTable(
                name: "Comenzi");

            migrationBuilder.DropTable(
                name: "Produse");

            migrationBuilder.DropTable(
                name: "Utilizatori");

            migrationBuilder.DropTable(
                name: "Tabel_Marimi");
        }
    }
}
