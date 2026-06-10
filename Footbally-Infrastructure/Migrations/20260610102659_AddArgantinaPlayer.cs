using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddArgantinaPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 33, null, "Emiliano", "Martinez", "GoalKeeper", "23", 1, null },
                    { 2, 34, null, "Geronimo", "Rulli", "GoalKeeper", "12", 1, null },
                    { 3, 32, null, "Juan", "Musso", "GoalKeeper", "1", 1, null },
                    { 4, 28, null, "Cristian", "Romero", "CenterBack", "13", 1, null },
                    { 5, 38, null, "Nicolas", "Otamendi", "CenterBack", "19", 1, null },
                    { 6, 28, null, "Lisandro", "Martinez", "CenterBack", "25", 1, null },
                    { 7, 27, null, "Facundo", "Medina", "LeftBack", "6", 1, null },
                    { 8, 33, null, "Nicolas", "Tagliafico", "LeftBack", "3", 1, null },
                    { 9, 29, null, "Gonzalo", "Montiel", "RightBAck", "4", 1, null },
                    { 10, 28, null, "Nahuel", "Molina", "RightBAck", "16", 1, null },
                    { 11, 32, null, "Rodrigo", "De Paul", "CenterMidfilder", "7", 1, null },
                    { 12, 25, null, "Enzo", "Fernandez", "CenterMidfilder", "8", 1, null },
                    { 13, 27, null, "Alexis", "Mac Allister", "CenterMidfilder", "20", 1, null },
                    { 14, 32, null, "Leandro", "Paredes", "DefendCenterMidfilder", "5", 1, null },
                    { 15, 30, null, "Giovani", "Lo Celso", "AttackingMidfilder", "18", 1, null },
                    { 16, 28, null, "Exequiel", "Palacios", "CenterMidfilder", "14", 1, null },
                    { 17, 22, null, "Valentin", "Barco", "LeftWinger", "21", 1, null },
                    { 18, 39, null, "Lionel", "Messi", "RightWinger", "10", 1, null },
                    { 19, 26, null, "Julian", "Alvarez", "CenterForward", "9", 1, null },
                    { 20, 29, null, "Lautaro", "Martinez", "CenterForward", "22", 1, null },
                    { 21, 25, null, "Thiago", "Almada", "AttackingMidfilder", "11", 1, null },
                    { 22, 28, null, "Nico", "Gonzalez", "LeftWinger", "15", 1, null },
                    { 23, 21, null, "Nico", "Paz", "AttackingMidfilder", "17", 1, null },
                    { 24, 24, null, "Giuliano", "Simeone", "RightWinger", "24", 1, null },
                    { 25, 25, null, "Jose Manuel", "Lopez", "CenterForward", "26", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
