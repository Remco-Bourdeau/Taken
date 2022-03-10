using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Oefening_56_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantNr",
                table: "Rekeningen",
                newName: "Klant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Klant",
                table: "Rekeningen",
                newName: "KlantNr");
        }
    }
}
