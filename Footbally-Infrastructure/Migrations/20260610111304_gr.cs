using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 589, 38, null, "Johny", "Placide", "GoalKeeper", "1", 24, null },
                    { 590, 24, null, "Alexandre", "Pierre", "GoalKeeper", "12", 24, null },
                    { 591, 25, null, "Josue", "Duverger", "GoalKeeper", "23", 24, null },
                    { 592, 29, null, "Carlens", "Arcus", "RightBAck", "2", 24, null },
                    { 593, 35, null, "Ricardo", "Ade", "CenterBack", "4", 24, null },
                    { 594, 29, null, "Jean-Kevin", "Duverne", "CenterBack", "5", 24, null },
                    { 595, 27, null, "Hannes", "Delcroix", "CenterBack", "3", 24, null },
                    { 596, 25, null, "Martin", "Experience", "LeftBack", "13", 24, null },
                    { 597, 31, null, "Duke", "Lacroix", "LeftBack", "14", 24, null },
                    { 598, 24, null, "Wilguens", "Paugain", "CenterBack", "15", 24, null },
                    { 599, 22, null, "Keeto", "Thermoncy", "CenterBack", "16", 24, null },
                    { 600, 28, null, "Jean-Ricner", "Bellegarde", "CenterMidfilder", "6", 24, null },
                    { 601, 25, null, "Danley", "Jean Jacques", "DefendCenterMidfilder", "8", 24, null },
                    { 602, 27, null, "Leverton", "Pierre", "CenterMidfilder", "10", 24, null },
                    { 603, 23, null, "Carl Fred", "Sainte", "CenterMidfilder", "17", 24, null },
                    { 604, 25, null, "Woodensky", "Pierre", "AttackingMidfilder", "18", 24, null },
                    { 605, 24, null, "Dominique", "Simon", "AttackingMidfilder", "20", 24, null },
                    { 606, 32, null, "Duckens", "Nazon", "CenterForward", "9", 24, null },
                    { 607, 31, null, "Frantzdy", "Pierrot", "CenterForward", "11", 24, null },
                    { 608, 25, null, "Wilson", "Isidor", "CenterForward", "7", 24, null },
                    { 609, 24, null, "Josue", "Casimir", "RightWinger", "19", 24, null },
                    { 610, 24, null, "Louicius", "Deedson", "LeftWinger", "21", 24, null },
                    { 611, 29, null, "Derrick", "Etienne Jr", "RightWinger", "22", 24, null },
                    { 612, 26, null, "Yassin", "Fortune", "LeftWinger", "24", 24, null },
                    { 613, 24, null, "Lenny", "Joseph", "CenterForward", "25", 24, null },
                    { 614, 24, null, "Ruben", "Providence", "LeftWinger", "26", 24, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 614);
        }
    }
}
