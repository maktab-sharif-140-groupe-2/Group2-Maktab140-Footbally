using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 615, 23, null, "Zion", "Suzuki", "GoalKeeper", "1", 25, null },
                    { 616, 24, null, "Kosei", "Tani", "GoalKeeper", "12", 25, null },
                    { 617, 33, null, "Daniel", "Schmidt", "GoalKeeper", "23", 25, null },
                    { 618, 26, null, "Takehiro", "Tomiyasu", "CenterBack", "2", 25, null },
                    { 619, 28, null, "Ko", "Itakura", "CenterBack", "4", 25, null },
                    { 620, 36, null, "Maya", "Yoshida", "CenterBack", "3", 25, null },
                    { 621, 35, null, "Hiroki", "Sakai", "RightBAck", "5", 25, null },
                    { 622, 25, null, "Yukinari", "Sugawara", "RightBAck", "6", 25, null },
                    { 623, 39, null, "Yuto", "Nagatomo", "LeftBack", "16", 25, null },
                    { 624, 24, null, "Ayumu", "Seko", "CenterBack", "15", 25, null },
                    { 625, 32, null, "Wataru", "Endo", "DefendCenterMidfilder", "8", 25, null },
                    { 626, 29, null, "Hidemasa", "Morita", "CenterMidfilder", "15", 25, null },
                    { 627, 29, null, "Daichi", "Kamada", "AttackingMidfilder", "10", 25, null },
                    { 628, 27, null, "Ao", "Tanaka", "CenterMidfilder", "17", 25, null },
                    { 629, 30, null, "Takumi", "Minamino", "AttackingMidfilder", "11", 25, null },
                    { 630, 28, null, "Kaoru", "Mitoma", "LeftWinger", "20", 25, null },
                    { 631, 32, null, "Junya", "Ito", "RightWinger", "14", 25, null },
                    { 632, 28, null, "Yuki", "Soma", "LeftWinger", "19", 25, null },
                    { 633, 27, null, "Ayase", "Ueda", "CenterForward", "9", 25, null },
                    { 634, 28, null, "Daizen", "Maeda", "CenterForward", "18", 25, null },
                    { 635, 26, null, "Shuto", "Machino", "CenterForward", "21", 25, null },
                    { 636, 30, null, "Kyogo", "Furuhashi", "CenterForward", "13", 25, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 636);
        }
    }
}
