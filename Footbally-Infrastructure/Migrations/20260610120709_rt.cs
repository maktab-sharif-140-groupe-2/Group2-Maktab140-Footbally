using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class rt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1077, 32, null, "Max", "Crocombe", "GoalKeeper", "1", 44, null },
                    { 1078, 29, null, "Oliver", "Sail", "GoalKeeper", "12", 44, null },
                    { 1079, 22, null, "Alex", "Paulsen", "GoalKeeper", "23", 44, null },
                    { 1080, 37, null, "Winston", "Reid", "CenterBack", "4", 44, null },
                    { 1081, 36, null, "Michael", "Boxall", "CenterBack", "5", 44, null },
                    { 1082, 33, null, "Tommy", "Smith", "CenterBack", "3", 44, null },
                    { 1083, 24, null, "Liberato", "Cacace", "LeftBack", "2", 44, null },
                    { 1084, 31, null, "Tim", "Payne", "RightBAck", "13", 44, null },
                    { 1085, 25, null, "Joe", "Bell", "DefendCenterMidfilder", "6", 44, null },
                    { 1086, 23, null, "Marko", "Stamenic", "CenterMidfilder", "8", 44, null },
                    { 1087, 29, null, "Alex", "Rufer", "AttackingMidfilder", "10", 44, null },
                    { 1088, 23, null, "Matthew", "Garbett", "RightWinger", "11", 44, null },
                    { 1089, 26, null, "Callum", "McCowatt", "LeftWinger", "7", 44, null },
                    { 1090, 27, null, "Clayton", "Lewis", "CenterMidfilder", "14", 44, null },
                    { 1091, 28, null, "Joe", "Champness", "AttackingMidfilder", "15", 44, null },
                    { 1092, 34, null, "Chris", "Wood", "CenterForward", "9", 44, null },
                    { 1093, 24, null, "Ben", "Waine", "CenterForward", "18", 44, null },
                    { 1094, 35, null, "Kosta", "Barbarouses", "RightWinger", "19", 44, null },
                    { 1095, 26, null, "Logan", "Rogerson", "LeftWinger", "20", 44, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1095);
        }
    }
}
