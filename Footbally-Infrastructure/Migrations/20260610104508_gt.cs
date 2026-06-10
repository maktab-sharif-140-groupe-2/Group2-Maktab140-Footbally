using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 231, 31, null, "Dominik", "Livakovic", "GoalKeeper", "1", 10, null },
                    { 232, 26, null, "Ivor", "Pandur", "GoalKeeper", "12", 10, null },
                    { 233, 26, null, "Dominik", "Kotarski", "GoalKeeper", "23", 10, null },
                    { 234, 26, null, "Josip", "Stanisic", "RightBAck", "2", 10, null },
                    { 235, 29, null, "Marin", "Pongracic", "CenterBack", "3", 10, null },
                    { 236, 25, null, "Josko", "Gvardiol", "CenterBack", "4", 10, null },
                    { 237, 30, null, "Duje", "Caleta-Car", "CenterBack", "5", 10, null },
                    { 238, 26, null, "Josip", "Sutalo", "CenterBack", "6", 10, null },
                    { 239, 28, null, "Martin", "Erlic", "CenterBack", "25", 10, null },
                    { 240, 19, null, "Luka", "Vuskovic", "CenterBack", "22", 10, null },
                    { 241, 28, null, "Nikola", "Moro", "DefendCenterMidfilder", "7", 10, null },
                    { 242, 32, null, "Mateo", "Kovacic", "CenterMidfilder", "8", 10, null },
                    { 243, 40, null, "Luka", "Modric", "AttackingMidfilder", "10", 10, null },
                    { 244, 29, null, "Nikola", "Vlasic", "AttackingMidfilder", "13", 10, null },
                    { 245, 31, null, "Mario", "Pasalic", "CenterMidfilder", "15", 10, null },
                    { 246, 23, null, "Martin", "Baturina", "AttackingMidfilder", "16", 10, null },
                    { 247, 22, null, "Petar", "Sucic", "CenterMidfilder", "17", 10, null },
                    { 248, 29, null, "Kristijan", "Jakic", "DefendCenterMidfilder", "18", 10, null },
                    { 249, 25, null, "Toni", "Fruk", "AttackingMidfilder", "19", 10, null },
                    { 250, 24, null, "Luka", "Sucic", "CenterMidfilder", "21", 10, null },
                    { 251, 35, null, "Andrej", "Kramaric", "CenterForward", "9", 10, null },
                    { 252, 35, null, "Ante", "Budimir", "CenterForward", "11", 10, null },
                    { 253, 37, null, "Ivan", "Perisic", "LeftWinger", "14", 10, null },
                    { 254, 23, null, "Igor", "Matanovic", "CenterForward", "20", 10, null },
                    { 255, 26, null, "Marco", "Pasalic", "RightWinger", "24", 10, null },
                    { 256, 28, null, "Petar", "Musa", "CenterForward", "26", 10, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256);
        }
    }
}
