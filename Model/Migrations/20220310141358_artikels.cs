using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class artikels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeelsleden");

            migrationBuilder.DropTable(
                name: "Rekeningen");

            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.CreateTable(
                name: "Artikels",
                columns: table => new
                {
                    ArtikelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artikelgroep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Houdbaarheid = table.Column<int>(type: "int", nullable: true),
                    Garantie = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikels", x => x.ArtikelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikels");

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
                name: "Personeelsleden",
                columns: table => new
                {
                    PersoneelsNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerNr = table.Column<int>(type: "int", nullable: true),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeelsleden", x => x.PersoneelsNr);
                    table.ForeignKey(
                        name: "FK_ManagerNr",
                        column: x => x.ManagerNr,
                        principalTable: "Personeelsleden",
                        principalColumn: "PersoneelsNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rekeningen",
                columns: table => new
                {
                    Rekeningnummer = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Klant = table.Column<int>(type: "int", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Soort = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rekeningen", x => x.Rekeningnummer);
                    table.ForeignKey(
                        name: "FK_Rekeningen_Klanten_Klant",
                        column: x => x.Klant,
                        principalTable: "Klanten",
                        principalColumn: "Klantnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Klanten",
                columns: new[] { "Klantnummer", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Marge" },
                    { 2, "Homer" },
                    { 3, "Lisa" },
                    { 4, "Maggie" },
                    { 5, "Bart" }
                });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[] { 1, null, "Diane" });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[,]
                {
                    { 2, 1, "Mary" },
                    { 3, 1, "Jeff" }
                });

            migrationBuilder.InsertData(
                table: "Rekeningen",
                columns: new[] { "Rekeningnummer", "Klant", "Saldo", "Soort" },
                values: new object[,]
                {
                    { "123-4567890-02", 1, 1000m, "Z" },
                    { "234-5678901-69", 1, 2000m, "S" },
                    { "345-6789012-12", 2, 500m, "S" }
                });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
                columns: new[] { "PersoneelsNr", "ManagerNr", "Voornaam" },
                values: new object[,]
                {
                    { 4, 2, "William" },
                    { 5, 2, "Gerard" },
                    { 6, 2, "Anthony" },
                    { 19, 2, "Mami" }
                });

            migrationBuilder.InsertData(
                table: "Personeelsleden",
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
                name: "IX_Personeelsleden_ManagerNr",
                table: "Personeelsleden",
                column: "ManagerNr");

            migrationBuilder.CreateIndex(
                name: "IX_Rekeningen_Klant",
                table: "Rekeningen",
                column: "Klant");
        }
    }
}
