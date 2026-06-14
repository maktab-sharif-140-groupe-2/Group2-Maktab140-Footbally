using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedStandings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Standings",
                columns: new[] { "Id", "DeletedAt", "Draw", "GoalsAgainst", "GoalsFor", "Lost", "Played", "Points", "TeamId", "UpdatedAt", "Won" },
                values: new object[,]
                {
                    { 1, null, 0, 0, 0, 0, 0, 0, 1, null, 0 },
                    { 2, null, 0, 0, 0, 0, 0, 0, 2, null, 0 },
                    { 3, null, 0, 0, 0, 0, 0, 0, 3, null, 0 },
                    { 4, null, 0, 0, 0, 0, 0, 0, 4, null, 0 },
                    { 5, null, 0, 0, 0, 0, 0, 0, 5, null, 0 },
                    { 6, null, 0, 0, 0, 0, 0, 0, 6, null, 0 },
                    { 7, null, 0, 0, 0, 0, 0, 0, 7, null, 0 },
                    { 8, null, 0, 0, 0, 0, 0, 0, 8, null, 0 },
                    { 9, null, 0, 0, 0, 0, 0, 0, 9, null, 0 },
                    { 10, null, 0, 0, 0, 0, 0, 0, 10, null, 0 },
                    { 11, null, 0, 0, 0, 0, 0, 0, 11, null, 0 },
                    { 12, null, 0, 0, 0, 0, 0, 0, 12, null, 0 },
                    { 13, null, 0, 0, 0, 0, 0, 0, 13, null, 0 },
                    { 14, null, 0, 0, 0, 0, 0, 0, 14, null, 0 },
                    { 15, null, 0, 0, 0, 0, 0, 0, 15, null, 0 },
                    { 16, null, 0, 0, 0, 0, 0, 0, 16, null, 0 },
                    { 17, null, 0, 0, 0, 0, 0, 0, 17, null, 0 },
                    { 18, null, 0, 0, 0, 0, 0, 0, 18, null, 0 },
                    { 19, null, 0, 0, 0, 0, 0, 0, 19, null, 0 },
                    { 20, null, 0, 0, 0, 0, 0, 0, 20, null, 0 },
                    { 21, null, 0, 0, 0, 0, 0, 0, 21, null, 0 },
                    { 22, null, 0, 0, 0, 0, 0, 0, 22, null, 0 },
                    { 23, null, 0, 0, 0, 0, 0, 0, 23, null, 0 },
                    { 24, null, 0, 0, 0, 0, 0, 0, 24, null, 0 },
                    { 25, null, 0, 0, 0, 0, 0, 0, 25, null, 0 },
                    { 26, null, 0, 0, 0, 0, 0, 0, 26, null, 0 },
                    { 27, null, 0, 0, 0, 0, 0, 0, 27, null, 0 },
                    { 28, null, 0, 0, 0, 0, 0, 0, 28, null, 0 },
                    { 29, null, 0, 0, 0, 0, 0, 0, 29, null, 0 },
                    { 30, null, 0, 0, 0, 0, 0, 0, 30, null, 0 },
                    { 31, null, 0, 0, 0, 0, 0, 0, 31, null, 0 },
                    { 32, null, 0, 0, 0, 0, 0, 0, 32, null, 0 },
                    { 33, null, 0, 0, 0, 0, 0, 0, 33, null, 0 },
                    { 34, null, 0, 0, 0, 0, 0, 0, 34, null, 0 },
                    { 35, null, 0, 0, 0, 0, 0, 0, 35, null, 0 },
                    { 36, null, 0, 0, 0, 0, 0, 0, 36, null, 0 },
                    { 37, null, 0, 0, 0, 0, 0, 0, 37, null, 0 },
                    { 38, null, 0, 0, 0, 0, 0, 0, 38, null, 0 },
                    { 39, null, 0, 0, 0, 0, 0, 0, 39, null, 0 },
                    { 40, null, 0, 0, 0, 0, 0, 0, 40, null, 0 },
                    { 41, null, 0, 0, 0, 0, 0, 0, 41, null, 0 },
                    { 42, null, 0, 0, 0, 0, 0, 0, 42, null, 0 },
                    { 43, null, 0, 0, 0, 0, 0, 0, 43, null, 0 },
                    { 44, null, 0, 0, 0, 0, 0, 0, 44, null, 0 },
                    { 45, null, 0, 0, 0, 0, 0, 0, 45, null, 0 },
                    { 46, null, 0, 0, 0, 0, 0, 0, 46, null, 0 },
                    { 47, null, 0, 0, 0, 0, 0, 0, 47, null, 0 },
                    { 48, null, 0, 0, 0, 0, 0, 0, 48, null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Standings",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
