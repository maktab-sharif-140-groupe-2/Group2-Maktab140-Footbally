using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 438, 28, null, "Altay", "Bayindir", "GoalKeeper", "12", 18, null },
                    { 439, 37, null, "Mert", "Gunok", "GoalKeeper", "1", 18, null },
                    { 440, 30, null, "Ugurcan", "Cakir", "GoalKeeper", "23", 18, null },
                    { 441, 31, null, "Abdulkerim", "Bardakci", "CenterBack", "14", 18, null },
                    { 442, 30, null, "Caglar", "Soyuncu", "CenterBack", "4", 18, null },
                    { 443, 25, null, "Eren", "Elmali", "LeftBack", "13", 18, null },
                    { 444, 26, null, "Ferdi", "Kadioglu", "LeftBack", "20", 18, null },
                    { 445, 28, null, "Merih", "Demiral", "CenterBack", "3", 18, null },
                    { 446, 27, null, "Mert", "Muldur", "RightBAck", "18", 18, null },
                    { 447, 25, null, "Ozan", "Kabak", "CenterBack", "15", 18, null },
                    { 448, 31, null, "Samet", "Akaydin", "CenterBack", "25", 18, null },
                    { 449, 29, null, "Zeki", "Celik", "RightBAck", "2", 18, null },
                    { 450, 32, null, "Hakan", "Calhanoglu", "AttackingMidfilder", "10", 18, null },
                    { 451, 27, null, "Ismail", "Yuksek", "DefendCenterMidfilder", "16", 18, null },
                    { 452, 31, null, "Kaan", "Ayhan", "DefendCenterMidfilder", "22", 18, null },
                    { 453, 25, null, "Orkun", "Kokcu", "CenterMidfilder", "8", 18, null },
                    { 454, 28, null, "Salih", "Ozcan", "DefendCenterMidfilder", "6", 18, null },
                    { 455, 21, null, "Arda", "Guler", "AttackingMidfilder", "7", 18, null },
                    { 456, 31, null, "Irfan Can", "Kahveci", "RightWinger", "17", 18, null },
                    { 457, 25, null, "Oguz", "Aydin", "RightWinger", "24", 18, null },
                    { 458, 26, null, "Yunus", "Akgun", "RightWinger", "19", 18, null },
                    { 459, 26, null, "Baris Alper", "Yilmaz", "CenterForward", "21", 18, null },
                    { 460, 20, null, "Can", "Uzun", "CenterForward", "26", 18, null },
                    { 461, 22, null, "Deniz", "Gul", "CenterForward", "9", 18, null },
                    { 462, 21, null, "Kenan", "Yildiz", "LeftWinger", "11", 18, null },
                    { 463, 27, null, "Kerem", "Akturkoglu", "LeftWinger", "10", 18, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463);
        }
    }
}
