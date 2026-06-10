using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 539, 34, null, "Luis", "Mejía", "GoalKeeper", "1", 22, null },
                    { 540, 30, null, "Orlando", "Mosquera", "GoalKeeper", "12", 22, null },
                    { 541, 29, null, "Cesar", "Samudio", "GoalKeeper", "23", 22, null },
                    { 542, 33, null, "Eric", "Davis", "LeftBack", "15", 22, null },
                    { 543, 29, null, "Michael", "Murillo", "RightBAck", "2", 22, null },
                    { 544, 30, null, "Fidel", "Escobar", "CenterBack", "4", 22, null },
                    { 545, 24, null, "Jose", "Cordoba", "CenterBack", "3", 22, null },
                    { 546, 27, null, "Cesar", "Blackman", "RightBAck", "6", 22, null },
                    { 547, 28, null, "Andres", "Andrade", "LeftBack", "13", 22, null },
                    { 548, 26, null, "Edgardo", "Farina", "CenterBack", "5", 22, null },
                    { 549, 25, null, "Jiovany", "Ramos", "RightBAck", "14", 22, null },
                    { 550, 26, null, "Jorge", "Gutiérrez", "CenterBack", "16", 22, null },
                    { 551, 35, null, "Anibal", "Godoy", "DefendCenterMidfilder", "20", 22, null },
                    { 552, 26, null, "Adalberto", "Carrasquilla", "CenterMidfilder", "8", 22, null },
                    { 553, 26, null, "Jose Luis", "Rodriguez", "RightWinger", "7", 22, null },
                    { 554, 30, null, "Yoel", "Barcenas", "LeftWinger", "11", 22, null },
                    { 555, 27, null, "Cesar", "Yanis", "AttackingMidfilder", "19", 22, null },
                    { 556, 26, null, "Cristian", "Martinez", "CenterMidfilder", "17", 22, null },
                    { 557, 26, null, "Carlos", "Harvey", "DefendCenterMidfilder", "18", 22, null },
                    { 558, 37, null, "Alberto", "Quintero", "AttackingMidfilder", "10", 22, null },
                    { 559, 28, null, "Ismael", "Diaz", "CenterForward", "9", 22, null },
                    { 560, 33, null, "Cecilio", "Waterman", "CenterForward", "21", 22, null },
                    { 561, 31, null, "Jose", "Fajardo", "CenterForward", "22", 22, null },
                    { 562, 26, null, "Tomás", "Rodriguez", "CenterForward", "24", 22, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 562);
        }
    }
}
