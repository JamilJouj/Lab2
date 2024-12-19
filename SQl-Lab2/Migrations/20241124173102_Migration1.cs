using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQl_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Butikers",
                columns: table => new
                {
                    ButikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ButiksNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GatuNummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butikers", x => x.ButikId);
                });

            migrationBuilder.CreateTable(
                name: "Författares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FörNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfterNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FödelseDatum = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Författares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Förlags",
                columns: table => new
                {
                    FörlagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Förlags", x => x.FörlagId);
                });

            migrationBuilder.CreateTable(
                name: "Kunders",
                columns: table => new
                {
                    KundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FörNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfterNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunders", x => x.KundId);
                });

            migrationBuilder.CreateTable(
                name: "Böckers",
                columns: table => new
                {
                    Isbn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Språk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UtgivningsDatum = table.Column<DateOnly>(type: "date", nullable: true),
                    FörfattareId = table.Column<int>(type: "int", nullable: false),
                    FörlagId = table.Column<int>(type: "int", nullable: false),
                    Kategori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Böckers", x => x.Isbn);
                    table.ForeignKey(
                        name: "FK_Böckers_Författares_FörfattareId",
                        column: x => x.FörfattareId,
                        principalTable: "Författares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Böckers_Förlags_FörlagId",
                        column: x => x.FörlagId,
                        principalTable: "Förlags",
                        principalColumn: "FörlagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LagerSaldos",
                columns: table => new
                {
                    LagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ButikId = table.Column<int>(type: "int", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Antal = table.Column<int>(type: "int", nullable: false),
                    BokIsbn = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LagerSaldos", x => x.LagerId);
                    table.ForeignKey(
                        name: "FK_LagerSaldos_Butikers_ButikId",
                        column: x => x.ButikId,
                        principalTable: "Butikers",
                        principalColumn: "ButikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LagerSaldos_Böckers_BokIsbn",
                        column: x => x.BokIsbn,
                        principalTable: "Böckers",
                        principalColumn: "Isbn");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Böckers_FörfattareId",
                table: "Böckers",
                column: "FörfattareId");

            migrationBuilder.CreateIndex(
                name: "IX_Böckers_FörlagId",
                table: "Böckers",
                column: "FörlagId");

            migrationBuilder.CreateIndex(
                name: "IX_LagerSaldos_BokIsbn",
                table: "LagerSaldos",
                column: "BokIsbn");

            migrationBuilder.CreateIndex(
                name: "IX_LagerSaldos_ButikId",
                table: "LagerSaldos",
                column: "ButikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunders");

            migrationBuilder.DropTable(
                name: "LagerSaldos");

            migrationBuilder.DropTable(
                name: "Butikers");

            migrationBuilder.DropTable(
                name: "Böckers");

            migrationBuilder.DropTable(
                name: "Författares");

            migrationBuilder.DropTable(
                name: "Förlags");
        }
    }
}
