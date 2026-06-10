using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 180, 34, null, "Thibaut", "Courtois", "GoalKeeper", "1", 8, null },
                    { 181, 23, null, "Senne", "Lammens", "GoalKeeper", "12", 8, null },
                    { 182, 20, null, "Mike", "Penders", "GoalKeeper", "13", 8, null },
                    { 183, 31, null, "Timothy", "Castagne", "RightBAck", "21", 8, null },
                    { 184, 35, null, "Thomas", "Meunier", "RightBAck", "15", 8, null },
                    { 185, 26, null, "Arthur", "Theate", "LeftBack", "3", 8, null },
                    { 186, 25, null, "Maxim", "De Cuyper", "LeftBack", "5", 8, null },
                    { 187, 28, null, "Wout", "Faes", "CenterBack", "4", 8, null },
                    { 188, 23, null, "Zeno", "Debast", "CenterBack", "2", 8, null },
                    { 189, 24, null, "Koni", "De Winter", "CenterBack", "14", 8, null },
                    { 190, 33, null, "Brandon", "Mechele", "CenterBack", "18", 8, null },
                    { 191, 29, null, "Youri", "Tielemans", "CenterMidfilder", "8", 8, null },
                    { 192, 25, null, "Amadou", "Onana", "DefendCenterMidfilder", "24", 8, null },
                    { 193, 28, null, "Orel", "Mangala", "CenterMidfilder", "7", 8, null },
                    { 194, 25, null, "Nicolas", "Raskin", "CenterMidfilder", "6", 8, null },
                    { 195, 35, null, "Kevin", "De Bruyne", "AttackingMidfilder", "10", 8, null },
                    { 196, 24, null, "Jeremy", "Doku", "LeftWinger", "22", 8, null },
                    { 197, 32, null, "Leandro", "Trossard", "LeftWinger", "11", 8, null },
                    { 198, 23, null, "Johan", "Bakayoko", "RightWinger", "19", 8, null },
                    { 199, 21, null, "Malick", "Fofana", "RightWinger", "17", 8, null },
                    { 200, 33, null, "Romelu", "Lukaku", "CenterForward", "9", 8, null },
                    { 201, 26, null, "Lois", "Openda", "CenterForward", "20", 8, null },
                    { 202, 25, null, "Charles", "De Ketelaere", "AttackingMidfilder", "16", 8, null },
                    { 203, 29, null, "Dodi", "Lukebakio", "RightWinger", "25", 8, null },
                    { 204, 33, null, "Michy", "Batshuayi", "CenterForward", "23", 8, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204);
        }
    }
}
