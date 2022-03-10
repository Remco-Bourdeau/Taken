using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Oefening_56_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr",
                table: "Rekeningen");

            migrationBuilder.RenameColumn(
                name: "KlantNr",
                table: "Rekeningen",
                newName: "Klant");

            migrationBuilder.RenameIndex(
                name: "IX_Rekeningen_KlantNr",
                table: "Rekeningen",
                newName: "IX_Rekeningen_Klant");

            migrationBuilder.AddForeignKey(
                name: "FK_Rekeningen_Klanten_Klant",
                table: "Rekeningen",
                column: "Klant",
                principalTable: "Klanten",
                principalColumn: "Klantnummer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rekeningen_Klanten_Klant",
                table: "Rekeningen");

            migrationBuilder.RenameColumn(
                name: "Klant",
                table: "Rekeningen",
                newName: "KlantNr");

            migrationBuilder.RenameIndex(
                name: "IX_Rekeningen_Klant",
                table: "Rekeningen",
                newName: "IX_Rekeningen_KlantNr");

            migrationBuilder.AddForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr",
                table: "Rekeningen",
                column: "KlantNr",
                principalTable: "Klanten",
                principalColumn: "Klantnummer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
