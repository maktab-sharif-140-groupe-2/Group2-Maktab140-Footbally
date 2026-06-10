using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 26, 33, null, "Alisson", "Becker", "GoalKeeper", "1", 2, null },
                    { 27, 32, null, "Ederson", "Moraes", "GoalKeeper", "23", 2, null },
                    { 28, 38, null, "Weverton", "Pereira", "GoalKeeper", "12", 2, null },
                    { 29, 32, null, "Marcos", "Correa", "CenterBack", "4", 2, null },
                    { 30, 28, null, "Gabriel", "Magalhaes", "CenterBack", "3", 2, null },
                    { 31, 29, null, "Gleison", "Bremer", "CenterBack", "14", 2, null },
                    { 32, 27, null, "Roger", "Ibanez", "CenterBack", "15", 2, null },
                    { 33, 35, null, "Alex", "Sandro", "LeftBack", "6", 2, null },
                    { 34, 31, null, "Douglas", "Santos", "LeftBack", "16", 2, null },
                    { 35, 34, null, "Danilo", "Luiz", "RightBAck", "2", 2, null },
                    { 36, 22, null, "Wesley", "Franca", "RightBAck", "13", 2, null },
                    { 37, 34, null, "Casemiro", "Santos", "DefendCenterMidfilder", "5", 2, null },
                    { 38, 28, null, "Bruno", "Guimaraes", "CenterMidfilder", "8", 2, null },
                    { 39, 32, null, "Fabinho", "Tavares", "DefendCenterMidfilder", "15", 2, null },
                    { 40, 28, null, "Lucas", "Paqueta", "AttackingMidfilder", "10", 2, null },
                    { 41, 24, null, "Danilo", "Santos", "CenterMidfilder", "17", 2, null },
                    { 42, 25, null, "Vinicius", "Junior", "LeftWinger", "7", 2, null },
                    { 43, 29, null, "Raphinha", "Belloli", "RightWinger", "11", 2, null },
                    { 44, 34, null, "Neymar", "Junior", "AttackingMidfilder", "10", 2, null },
                    { 45, 25, null, "Gabriel", "Martinelli", "LeftWinger", "20", 2, null },
                    { 46, 27, null, "Matheus", "Cunha", "CenterForward", "21", 2, null },
                    { 47, 19, null, "Endrick", "Felipe", "CenterForward", "9", 2, null },
                    { 48, 24, null, "Igor", "Thiago", "CenterForward", "19", 2, null },
                    { 49, 25, null, "Luiz", "Henrique", "RightWinger", "22", 2, null },
                    { 50, 19, null, "Rayan", "Vitor", "RightWinger", "24", 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
