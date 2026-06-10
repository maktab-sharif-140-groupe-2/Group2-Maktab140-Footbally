using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 464, 30, null, "Carlos", "Acevedo", "GoalKeeper", "12", 19, null },
                    { 465, 40, null, "Guillermo", "Ochoa", "GoalKeeper", "13", 19, null },
                    { 466, 26, null, "Raul", "Rangel", "GoalKeeper", "1", 19, null },
                    { 467, 28, null, "Edson", "Alvarez", "CenterBack", "4", 19, null },
                    { 468, 21, null, "Mateo", "Chavez", "LeftBack", "20", 19, null },
                    { 469, 31, null, "Jesus", "Gallardo", "LeftBack", "23", 19, null },
                    { 470, 29, null, "Cesar", "Montes", "CenterBack", "3", 19, null },
                    { 471, 25, null, "Israel", "Reyes", "RightBAck", "15", 19, null },
                    { 472, 28, null, "Jorge", "Sanchez", "RightBAck", "2", 19, null },
                    { 473, 27, null, "Johan", "Vasquez", "CenterBack", "5", 19, null },
                    { 474, 30, null, "Luis", "Chavez", "CenterMidfilder", "24", 19, null },
                    { 475, 29, null, "Alvaro", "Fidalgo", "CenterMidfilder", "8", 19, null },
                    { 476, 23, null, "Brian", "Gutierrez", "AttackingMidfilder", "26", 19, null },
                    { 477, 26, null, "Erik", "Lira", "DefendCenterMidfilder", "6", 19, null },
                    { 478, 17, null, "Gilberto", "Mora", "AttackingMidfilder", "19", 19, null },
                    { 479, 31, null, "Luis", "Romo", "CenterMidfilder", "7", 19, null },
                    { 480, 30, null, "Orbelin", "Pineda", "AttackingMidfilder", "17", 19, null },
                    { 481, 20, null, "Obed", "Vargas", "CenterMidfilder", "18", 19, null },
                    { 482, 27, null, "Roberto", "Alvarado", "RightWinger", "25", 19, null },
                    { 483, 22, null, "Armando", "Gonzalez", "CenterForward", "14", 19, null },
                    { 484, 25, null, "Cesar", "Huerta", "LeftWinger", "21", 19, null },
                    { 485, 35, null, "Raul", "Jimenez", "CenterForward", "9", 19, null },
                    { 486, 30, null, "Guillermo", "Martinez", "CenterForward", "22", 19, null },
                    { 487, 29, null, "Julian", "Quinones", "LeftWinger", "16", 19, null },
                    { 488, 25, null, "Santiago", "Gimenez", "CenterForward", "11", 19, null },
                    { 489, 28, null, "Alexis", "Vega", "LeftWinger", "10", 19, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489);
        }
    }
}
