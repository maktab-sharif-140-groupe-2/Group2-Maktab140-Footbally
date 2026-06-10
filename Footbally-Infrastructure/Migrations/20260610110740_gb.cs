using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 515, 31, null, "Matt", "Turner", "GoalKeeper", "1", 21, null },
                    { 516, 30, null, "Ethan", "Horvath", "GoalKeeper", "12", 21, null },
                    { 517, 24, null, "Chris", "Brady", "GoalKeeper", "23", 21, null },
                    { 518, 25, null, "Sergino", "Dest", "RightBAck", "2", 21, null },
                    { 519, 28, null, "Antonee", "Robinson", "LeftBack", "3", 21, null },
                    { 520, 37, null, "Tim", "Ream", "CenterBack", "13", 21, null },
                    { 521, 25, null, "Chris", "Richards", "CenterBack", "4", 21, null },
                    { 522, 28, null, "Miles", "Robinson", "CenterBack", "5", 21, null },
                    { 523, 22, null, "Joe", "Scally", "RightBAck", "18", 21, null },
                    { 524, 27, null, "Cameron", "Carter-Vickers", "CenterBack", "6", 21, null },
                    { 525, 26, null, "Tyler", "Adams", "DefendCenterMidfilder", "8", 21, null },
                    { 526, 27, null, "Weston", "McKennie", "CenterMidfilder", "7", 21, null },
                    { 527, 23, null, "Yunus", "Musah", "CenterMidfilder", "11", 21, null },
                    { 528, 23, null, "Giovanni", "Reyna", "AttackingMidfilder", "10", 21, null },
                    { 529, 27, null, "Luca", "de la Torre", "CenterMidfilder", "14", 21, null },
                    { 530, 25, null, "Brenden", "Aaronson", "AttackingMidfilder", "19", 21, null },
                    { 531, 23, null, "Malik", "Tillman", "AttackingMidfilder", "17", 21, null },
                    { 532, 23, null, "Johnny", "Cardoso", "DefendCenterMidfilder", "15", 21, null },
                    { 533, 27, null, "Christian", "Pulisic", "LeftWinger", "10", 21, null },
                    { 534, 25, null, "Timothy", "Weah", "RightWinger", "21", 21, null },
                    { 535, 24, null, "Folarin", "Balogun", "CenterForward", "9", 21, null },
                    { 536, 23, null, "Ricardo", "Pepi", "CenterForward", "20", 21, null },
                    { 537, 25, null, "Josh", "Sargent", "CenterForward", "11", 21, null },
                    { 538, 27, null, "Haji", "Wright", "CenterForward", "16", 21, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 538);
        }
    }
}
