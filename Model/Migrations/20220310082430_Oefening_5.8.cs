using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Oefening_58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Rekeningen",
                columns: new[] { "Rekeningnummer", "Klant", "Saldo", "Soort" },
                values: new object[] { "123-4567890-02", 1, 1000m, "Z" });

            migrationBuilder.InsertData(
                table: "Rekeningen",
                columns: new[] { "Rekeningnummer", "Klant", "Saldo", "Soort" },
                values: new object[] { "234-5678901-69", 1, 2000m, "S" });

            migrationBuilder.InsertData(
                table: "Rekeningen",
                columns: new[] { "Rekeningnummer", "Klant", "Saldo", "Soort" },
                values: new object[] { "345-6789012-12", 2, 500m, "S" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Klantnummer",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Klantnummer",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Klantnummer",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rekeningen",
                keyColumn: "Rekeningnummer",
                keyValue: "123-4567890-02");

            migrationBuilder.DeleteData(
                table: "Rekeningen",
                keyColumn: "Rekeningnummer",
                keyValue: "234-5678901-69");

            migrationBuilder.DeleteData(
                table: "Rekeningen",
                keyColumn: "Rekeningnummer",
                keyValue: "345-6789012-12");

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Klantnummer",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Klantnummer",
                keyValue: 2);
        }
    }
}
