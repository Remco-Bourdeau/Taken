using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Oefening_56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    Klantnummer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.Klantnummer);
                });

            migrationBuilder.CreateTable(
                name: "Rekeningen",
                columns: table => new
                {
                    Rekeningnummer = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    KlantNr = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Soort = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    KlantNr1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rekeningen", x => x.Rekeningnummer);
                    table.ForeignKey(
                        name: "FK_Rekeningen_Klanten_KlantNr1",
                        column: x => x.KlantNr1,
                        principalTable: "Klanten",
                        principalColumn: "Klantnummer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rekeningen_KlantNr1",
                table: "Rekeningen",
                column: "KlantNr1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rekeningen");

            migrationBuilder.DropTable(
                name: "Klanten");
        }
    }
}
