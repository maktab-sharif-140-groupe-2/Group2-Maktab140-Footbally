using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 308, 27, null, "Viktor", "Johansson", "GoalKeeper", "1", 13, null },
                    { 309, 37, null, "Kristoffer", "Nordfeldt", "GoalKeeper", "12", 13, null },
                    { 310, 28, null, "Jacob", "Zetterstrom", "GoalKeeper", "23", 13, null },
                    { 311, 32, null, "Victor", "Lindelof", "CenterBack", "4", 13, null },
                    { 312, 27, null, "Isak", "Hien", "CenterBack", "3", 13, null },
                    { 313, 31, null, "Carl", "Starfelt", "CenterBack", "5", 13, null },
                    { 314, 28, null, "Hjalmar", "Ekdal", "CenterBack", "2", 13, null },
                    { 315, 27, null, "Gabriel", "Gudmundsson", "LeftBack", "13", 13, null },
                    { 316, 24, null, "Daniel", "Svensson", "LeftBack", "14", 13, null },
                    { 317, 25, null, "Gustaf", "Lagerbielke", "CenterBack", "15", 13, null },
                    { 318, 30, null, "Eric", "Smith", "CenterBack", "6", 13, null },
                    { 319, 20, null, "Lucas", "Bergvall", "CenterMidfilder", "8", 13, null },
                    { 320, 23, null, "Yasin", "Ayari", "CenterMidfilder", "16", 13, null },
                    { 321, 27, null, "Mattias", "Svanberg", "CenterMidfilder", "17", 13, null },
                    { 322, 31, null, "Jesper", "Karlstrom", "DefendCenterMidfilder", "18", 13, null },
                    { 323, 24, null, "Besfort", "Zeneli", "CenterMidfilder", "20", 13, null },
                    { 324, 25, null, "Benjamin", "Nygren", "AttackingMidfilder", "10", 13, null },
                    { 325, 33, null, "Ken", "Sema", "LeftWinger", "11", 13, null },
                    { 326, 27, null, "Alexander", "Isak", "CenterForward", "9", 13, null },
                    { 327, 28, null, "Viktor", "Gyokeres", "CenterForward", "19", 13, null },
                    { 328, 24, null, "Anthony", "Elanga", "RightWinger", "7", 13, null },
                    { 329, 27, null, "Taha", "Ali", "RightWinger", "21", 13, null },
                    { 330, 28, null, "Alexander", "Bernhardsson", "LeftWinger", "22", 13, null },
                    { 331, 29, null, "Gustaf", "Nilsson", "CenterForward", "24", 13, null },
                    { 332, 24, null, "Elliot", "Stroud", "LeftWinger", "25", 13, null },
                    { 333, 26, null, "Emil", "Holm", "RightBAck", "26", 13, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333);
        }
    }
}
