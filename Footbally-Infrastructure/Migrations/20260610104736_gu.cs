using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 283, 30, null, "Alexander", "Schlager", "GoalKeeper", "1", 12, null },
                    { 284, 29, null, "Patrick", "Pentz", "GoalKeeper", "13", 12, null },
                    { 285, 24, null, "Florian", "Wiegele", "GoalKeeper", "23", 12, null },
                    { 286, 34, null, "David", "Alaba", "CenterBack", "4", 12, null },
                    { 287, 28, null, "Kevin", "Danso", "CenterBack", "3", 12, null },
                    { 288, 30, null, "Philipp", "Lienhart", "CenterBack", "15", 12, null },
                    { 289, 28, null, "Marco", "Friedl", "CenterBack", "5", 12, null },
                    { 290, 25, null, "David", "Affengruber", "CenterBack", "22", 12, null },
                    { 291, 28, null, "Michael", "Svoboda", "CenterBack", "21", 12, null },
                    { 292, 29, null, "Stefan", "Posch", "RightBAck", "2", 12, null },
                    { 293, 32, null, "Phillipp", "Mwene", "LeftBack", "16", 12, null },
                    { 294, 25, null, "Alexander", "Prass", "LeftBack", "17", 12, null },
                    { 295, 29, null, "Konrad", "Laimer", "CenterMidfilder", "20", 12, null },
                    { 296, 32, null, "Marcel", "Sabitzer", "AttackingMidfilder", "9", 12, null },
                    { 297, 25, null, "Nicolas", "Seiwald", "DefendCenterMidfilder", "6", 12, null },
                    { 298, 29, null, "Xaver", "Schlager", "DefendCenterMidfilder", "8", 12, null },
                    { 299, 26, null, "Romano", "Schmid", "AttackingMidfilder", "18", 12, null },
                    { 300, 25, null, "Patrick", "Wimmer", "RightWinger", "11", 12, null },
                    { 301, 20, null, "Paul", "Wanner", "AttackingMidfilder", "14", 12, null },
                    { 302, 22, null, "Carney", "Chukwuemeka", "CenterMidfilder", "19", 12, null },
                    { 303, 31, null, "Florian", "Grillitsch", "CenterMidfilder", "7", 12, null },
                    { 304, 32, null, "Alessandro", "Schopf", "CenterMidfilder", "24", 12, null },
                    { 305, 37, null, "Marko", "Arnautovic", "CenterForward", "10", 12, null },
                    { 306, 32, null, "Michael", "Gregoritsch", "CenterForward", "25", 12, null },
                    { 307, 29, null, "Sasa", "Kalajdzic", "CenterForward", "26", 12, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307);
        }
    }
}
