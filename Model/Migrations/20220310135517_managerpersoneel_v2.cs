using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class managerpersoneel_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personeel_Personeel_ManagerNr",
                table: "Personeel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personeel",
                table: "Personeel");

            migrationBuilder.RenameTable(
                name: "Personeel",
                newName: "Personeelsleden");

            migrationBuilder.RenameIndex(
                name: "IX_Personeel_ManagerNr",
                table: "Personeelsleden",
                newName: "IX_Personeelsleden_ManagerNr");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personeelsleden",
                table: "Personeelsleden",
                column: "PersoneelsNr");

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerNr",
                table: "Personeelsleden",
                column: "ManagerNr",
                principalTable: "Personeelsleden",
                principalColumn: "PersoneelsNr",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerNr",
                table: "Personeelsleden");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personeelsleden",
                table: "Personeelsleden");

            migrationBuilder.RenameTable(
                name: "Personeelsleden",
                newName: "Personeel");

            migrationBuilder.RenameIndex(
                name: "IX_Personeelsleden_ManagerNr",
                table: "Personeel",
                newName: "IX_Personeel_ManagerNr");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personeel",
                table: "Personeel",
                column: "PersoneelsNr");

            migrationBuilder.AddForeignKey(
                name: "FK_Personeel_Personeel_ManagerNr",
                table: "Personeel",
                column: "ManagerNr",
                principalTable: "Personeel",
                principalColumn: "PersoneelsNr",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
