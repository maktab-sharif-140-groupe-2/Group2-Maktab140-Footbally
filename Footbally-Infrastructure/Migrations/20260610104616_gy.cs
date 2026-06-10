using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 257, 28, null, "Gregor", "Kobel", "GoalKeeper", "1", 11, null },
                    { 258, 23, null, "Marvin", "Keller", "GoalKeeper", "12", 11, null },
                    { 259, 32, null, "Yvon", "Mvogo", "GoalKeeper", "21", 11, null },
                    { 260, 31, null, "Manuel", "Akanji", "CenterBack", "5", 11, null },
                    { 261, 30, null, "Nico", "Elvedi", "CenterBack", "4", 11, null },
                    { 262, 34, null, "Ricardo", "Rodriguez", "LeftBack", "13", 11, null },
                    { 263, 33, null, "Silvan", "Widmer", "RightBAck", "3", 11, null },
                    { 264, 28, null, "Miro", "Muheim", "LeftBack", "17", 11, null },
                    { 265, 23, null, "Aurele", "Amenda", "CenterBack", "15", 11, null },
                    { 266, 28, null, "Eray", "Comert", "CenterBack", "18", 11, null },
                    { 267, 22, null, "Luca", "Jaquez", "CenterBack", "22", 11, null },
                    { 268, 34, null, "Granit", "Xhaka", "CenterMidfilder", "10", 11, null },
                    { 269, 30, null, "Denis", "Zakaria", "DefendCenterMidfilder", "6", 11, null },
                    { 270, 34, null, "Remo", "Freuler", "CenterMidfilder", "8", 11, null },
                    { 271, 29, null, "Djibril", "Sow", "CenterMidfilder", "20", 11, null },
                    { 272, 24, null, "Ardon", "Jashari", "CenterMidfilder", "14", 11, null },
                    { 273, 24, null, "Fabian", "Rieder", "AttackingMidfilder", "11", 11, null },
                    { 274, 29, null, "Michel", "Aebischer", "CenterMidfilder", "16", 11, null },
                    { 275, 33, null, "Christian", "Fassnacht", "RightWinger", "19", 11, null },
                    { 276, 20, null, "Johan", "Manzambi", "AttackingMidfilder", "24", 11, null },
                    { 277, 29, null, "Breel", "Embolo", "CenterForward", "7", 11, null },
                    { 278, 26, null, "Zeki", "Amdouni", "CenterForward", "9", 11, null },
                    { 279, 26, null, "Dan", "Ndoye", "RightWinger", "23", 11, null },
                    { 280, 26, null, "Noah", "Okafor", "LeftWinger", "25", 11, null },
                    { 281, 28, null, "Ruben", "Vargas", "LeftWinger", "17", 11, null },
                    { 282, 29, null, "Cedric", "Itten", "CenterForward", "26", 11, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282);
        }
    }
}
