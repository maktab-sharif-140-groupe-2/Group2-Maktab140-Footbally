using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 490, 30, null, "Maxime", "Crepeau", "GoalKeeper", "16", 20, null },
                    { 491, 28, null, "Dayne", "St. Clair", "GoalKeeper", "1", 20, null },
                    { 492, 24, null, "Owen", "Goodman", "GoalKeeper", "12", 20, null },
                    { 493, 25, null, "Alphonso", "Davies", "LeftBack", "19", 20, null },
                    { 494, 26, null, "Alistair", "Johnston", "RightBAck", "2", 20, null },
                    { 495, 27, null, "Derek", "Cornelius", "CenterBack", "5", 20, null },
                    { 496, 24, null, "Moise", "Bombito", "CenterBack", "4", 20, null },
                    { 497, 30, null, "Richie", "Laryea", "LeftBack", "3", 20, null },
                    { 498, 28, null, "Alfie", "Jones", "CenterBack", "15", 20, null },
                    { 499, 29, null, "Joel", "Waterman", "CenterBack", "6", 20, null },
                    { 500, 19, null, "Luc", "De Fougerolles", "CenterBack", "13", 20, null },
                    { 501, 21, null, "Niko", "Sigur", "RightBAck", "14", 20, null },
                    { 502, 28, null, "Stephen", "Eustaquio", "DefendCenterMidfilder", "7", 20, null },
                    { 503, 22, null, "Ismael", "Kone", "CenterMidfilder", "8", 20, null },
                    { 504, 33, null, "Jonathan", "Osorio", "CenterMidfilder", "21", 20, null },
                    { 505, 26, null, "Tajon", "Buchanan", "RightWinger", "11", 20, null },
                    { 506, 26, null, "Mathieu", "Choiniere", "CenterMidfilder", "17", 20, null },
                    { 507, 23, null, "Ali", "Ahmed", "LeftWinger", "18", 20, null },
                    { 508, 20, null, "Nathan", "Saliba", "DefendCenterMidfilder", "22", 20, null },
                    { 509, 24, null, "Liam", "Millar", "LeftWinger", "20", 20, null },
                    { 510, 25, null, "Jonathan", "David", "CenterForward", "10", 20, null },
                    { 511, 30, null, "Cyle", "Larin", "CenterForward", "9", 20, null },
                    { 512, 25, null, "Jacob", "Shaffelburg", "LeftWinger", "14", 20, null },
                    { 513, 23, null, "Promise", "David", "CenterForward", "23", 20, null },
                    { 514, 25, null, "Tani", "Oluwaseyi", "CenterForward", "24", 20, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 514);
        }
    }
}
