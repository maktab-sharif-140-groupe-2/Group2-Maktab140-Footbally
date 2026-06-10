using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class F : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 103, 40, null, "Manuel", "Neuer", "GoalKeeper", "1", 5, null },
                    { 104, 35, null, "Oliver", "Baumann", "GoalKeeper", "12", 5, null },
                    { 105, 29, null, "Alexander", "Nubel", "GoalKeeper", "23", 5, null },
                    { 106, 33, null, "Antonio", "Rudiger", "CenterBack", "2", 5, null },
                    { 107, 30, null, "Jonathan", "Tah", "CenterBack", "4", 5, null },
                    { 108, 26, null, "Nico", "Schlotterbeck", "CenterBack", "15", 5, null },
                    { 109, 29, null, "Waldemar", "Anton", "CenterBack", "3", 5, null },
                    { 110, 24, null, "Malick", "Thiaw", "CenterBack", "16", 5, null },
                    { 111, 31, null, "Joshua", "Kimmich", "RightBAck", "6", 5, null },
                    { 112, 28, null, "David", "Raum", "LeftBack", "18", 5, null },
                    { 113, 22, null, "Nathaniel", "Brown", "LeftBack", "20", 5, null },
                    { 114, 31, null, "Leon", "Goretzka", "CenterMidfilder", "8", 5, null },
                    { 115, 22, null, "Aleksandar", "Pavlovic", "DefendCenterMidfilder", "5", 5, null },
                    { 116, 25, null, "Angelo", "Stiller", "CenterMidfilder", "17", 5, null },
                    { 117, 34, null, "Pascal", "Gross", "CenterMidfilder", "19", 5, null },
                    { 118, 29, null, "Nadiem", "Amiri", "AttackingMidfilder", "14", 5, null },
                    { 119, 25, null, "Felix", "Nmecha", "CenterMidfilder", "13", 5, null },
                    { 120, 23, null, "Jamal", "Musiala", "AttackingMidfilder", "10", 5, null },
                    { 121, 23, null, "Florian", "Wirtz", "AttackingMidfilder", "7", 5, null },
                    { 122, 25, null, "Jamie", "Leweling", "RightWinger", "9", 5, null },
                    { 123, 30, null, "Leroy", "Sane", "LeftWinger", "11", 5, null },
                    { 124, 18, null, "Lennart", "Karl", "RightWinger", "24", 5, null },
                    { 125, 27, null, "Kai", "Havertz", "CenterForward", "22", 5, null },
                    { 126, 29, null, "Deniz", "Undav", "CenterForward", "26", 5, null },
                    { 127, 24, null, "Nick", "Woltemade", "CenterForward", "25", 5, null },
                    { 128, 24, null, "Maximilian", "Beier", "CenterForward", "21", 5, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128);
        }
    }
}
