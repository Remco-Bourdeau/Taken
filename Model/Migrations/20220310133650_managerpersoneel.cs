using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class managerpersoneel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeel",
                columns: table => new
                {
                    PersoneelsNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerNr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeel", x => x.PersoneelsNr);
                    table.ForeignKey(
                        name: "FK_Personeel_Personeel_ManagerNr",
                        column: x => x.ManagerNr,
                        principalTable: "Personeel",
                        principalColumn: "PersoneelsNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[] { 1, null, "Diane" });

            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[] { 2, 1, "Mary" });

            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[] { 3, 1, "Jeff" });

            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[,]
                {
                    { 4, 2, "William" },
                    { 5, 2, "Gerard" },
                    { 6, 2, "Anthony" },
                    { 19, 2, "Mami" }
                });

            migrationBuilder.InsertData(
                table: "Personeel",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[,]
                {
                    { 16, 4, "Andy" },
                    { 17, 4, "Peter" },
                    { 18, 4, "Tom" },
                    { 12, 5, "Loui" },
                    { 13, 5, "Pamela" },
                    { 14, 5, "Larry" },
                    { 15, 5, "Barry" },
                    { 21, 5, "Martin" },
                    { 7, 6, "Leslie" },
                    { 8, 6, "July" },
                    { 9, 6, "Steve" },
                    { 10, 6, "Foon Yue" },
                    { 11, 6, "George" },
                    { 20, 19, "Yoshimi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personeel_ManagerNr",
                table: "Personeel",
                column: "ManagerNr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeel");
        }
    }
}
