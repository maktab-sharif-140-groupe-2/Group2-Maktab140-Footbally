using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 360, 30, null, "Angus", "Gunn", "GoalKeeper", "1", 15, null },
                    { 361, 30, null, "Liam", "Kelly", "GoalKeeper", "12", 15, null },
                    { 362, 43, null, "Craig", "Gordon", "GoalKeeper", "21", 15, null },
                    { 363, 24, null, "Aaron", "Hickey", "RightBAck", "2", 15, null },
                    { 364, 32, null, "Andy", "Robertson", "LeftBack", "3", 15, null },
                    { 365, 34, null, "Grant", "Hanley", "CenterBack", "5", 15, null },
                    { 366, 29, null, "Kieran", "Tierney", "LeftBack", "6", 15, null },
                    { 367, 31, null, "Jack", "Hendry", "CenterBack", "13", 15, null },
                    { 368, 29, null, "John", "Souttar", "CenterBack", "15", 15, null },
                    { 369, 30, null, "Dominic", "Hyam", "CenterBack", "16", 15, null },
                    { 370, 24, null, "Nathan", "Patterson", "RightBAck", "22", 15, null },
                    { 371, 27, null, "Anthony", "Ralston", "RightBAck", "24", 15, null },
                    { 372, 29, null, "Scott", "McKenna", "CenterBack", "26", 15, null },
                    { 373, 29, null, "Scott", "McTominay", "CenterMidfilder", "4", 15, null },
                    { 374, 32, null, "John", "McGinn", "AttackingMidfilder", "7", 15, null },
                    { 375, 19, null, "Tyler", "Fletcher", "CenterMidfilder", "8", 15, null },
                    { 376, 31, null, "Ryan", "Christie", "AttackingMidfilder", "11", 15, null },
                    { 377, 26, null, "Lewis", "Ferguson", "CenterMidfilder", "19", 15, null },
                    { 378, 34, null, "Kenny", "McLean", "CenterMidfilder", "23", 15, null },
                    { 379, 20, null, "Ben", "Doak", "RightWinger", "17", 15, null },
                    { 380, 19, null, "Findlay", "Curtis", "LeftWinger", "25", 15, null },
                    { 381, 30, null, "Lyndon", "Dykes", "CenterForward", "9", 15, null },
                    { 382, 30, null, "Che", "Adams", "CenterForward", "10", 15, null },
                    { 383, 29, null, "Ross", "Stewart", "CenterForward", "14", 15, null },
                    { 384, 26, null, "George", "Hirst", "CenterForward", "18", 15, null },
                    { 385, 31, null, "Lawrence", "Shankland", "CenterForward", "20", 15, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385);
        }
    }
}
