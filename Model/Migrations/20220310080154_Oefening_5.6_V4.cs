using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Oefening_56_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr1",
                table: "Rekeningen");

            migrationBuilder.DropIndex(
                name: "IX_Rekeningen_KlantNr1",
                table: "Rekeningen");

            migrationBuilder.DropColumn(
                name: "KlantNr1",
                table: "Rekeningen");

            migrationBuilder.RenameColumn(
                name: "Klant",
                table: "Rekeningen",
                newName: "KlantNr");

            migrationBuilder.CreateIndex(
                name: "IX_Rekeningen_KlantNr",
                table: "Rekeningen",
                column: "KlantNr");

            migrationBuilder.AddForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr",
                table: "Rekeningen",
                column: "KlantNr",
                principalTable: "Klanten",
                principalColumn: "Klantnummer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr",
                table: "Rekeningen");

            migrationBuilder.DropIndex(
                name: "IX_Rekeningen_KlantNr",
                table: "Rekeningen");

            migrationBuilder.RenameColumn(
                name: "KlantNr",
                table: "Rekeningen",
                newName: "Klant");

            migrationBuilder.AddColumn<int>(
                name: "KlantNr1",
                table: "Rekeningen",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rekeningen_KlantNr1",
                table: "Rekeningen",
                column: "KlantNr1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rekeningen_Klanten_KlantNr1",
                table: "Rekeningen",
                column: "KlantNr1",
                principalTable: "Klanten",
                principalColumn: "Klantnummer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
