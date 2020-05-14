using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lot.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    nazwaLiniLotniczej = table.Column<string>(nullable: true),
                    nazwaSamolotu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CeleLotow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kraj = table.Column<string>(nullable: true),
                    Miasto = table.Column<string>(nullable: true),
                    Lotnisko = table.Column<string>(nullable: true),
                    LotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CeleLotow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CeleLotow_Loty_LotId",
                        column: x => x.LotId,
                        principalTable: "Loty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piloci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    KrajPochodzenia = table.Column<string>(nullable: true),
                    LotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piloci_Loty_LotId",
                        column: x => x.LotId,
                        principalTable: "Loty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CeleLotow_LotId",
                table: "CeleLotow",
                column: "LotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Piloci_LotId",
                table: "Piloci",
                column: "LotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CeleLotow");

            migrationBuilder.DropTable(
                name: "Piloci");

            migrationBuilder.DropTable(
                name: "Loty");
        }
    }
}
