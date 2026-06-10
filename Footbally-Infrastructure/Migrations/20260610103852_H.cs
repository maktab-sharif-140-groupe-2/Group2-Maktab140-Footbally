using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class H : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 155, 27, null, "Diogo", "Costa", "GoalKeeper", "1", 7, null },
                    { 156, 32, null, "Rui", "Silva", "GoalKeeper", "12", 7, null },
                    { 157, 33, null, "Jose", "Sa", "GoalKeeper", "22", 7, null },
                    { 158, 27, null, "Diogo", "Dalot", "RightBAck", "2", 7, null },
                    { 159, 32, null, "Joao", "Cancelo", "RightBAck", "20", 7, null },
                    { 160, 24, null, "Nuno", "Mendes", "LeftBack", "19", 7, null },
                    { 161, 29, null, "Ruben", "Dias", "CenterBack", "4", 7, null },
                    { 162, 25, null, "Goncalo", "Inacio", "CenterBack", "15", 7, null },
                    { 163, 24, null, "Tomas", "Araujo", "CenterBack", "3", 7, null },
                    { 164, 23, null, "Renato", "Veiga", "CenterBack", "5", 7, null },
                    { 165, 33, null, "Nelson", "Semedo", "RightBAck", "16", 7, null },
                    { 166, 32, null, "Bruno", "Fernandes", "AttackingMidfilder", "8", 7, null },
                    { 167, 32, null, "Bernardo", "Silva", "AttackingMidfilder", "10", 7, null },
                    { 168, 26, null, "Vitinha", "Ferreira", "CenterMidfilder", "23", 7, null },
                    { 169, 22, null, "Joao", "Neves", "CenterMidfilder", "14", 7, null },
                    { 170, 29, null, "Ruben", "Neves", "DefendCenterMidfilder", "18", 7, null },
                    { 171, 31, null, "Joao", "Palhinha", "DefendCenterMidfilder", "6", 7, null },
                    { 172, 41, null, "Cristiano", "Ronaldo", "CenterForward", "7", 7, null },
                    { 173, 27, null, "Rafael", "Leao", "LeftWinger", "17", 7, null },
                    { 174, 26, null, "Pedro", "Neto", "RightWinger", "11", 7, null },
                    { 175, 24, null, "Francisco", "Conceicao", "RightWinger", "21", 7, null },
                    { 176, 27, null, "Joao", "Felix", "CenterForward", "9", 7, null },
                    { 177, 25, null, "Goncalo", "Ramos", "CenterForward", "13", 7, null },
                    { 178, 26, null, "Francisco", "Trincao", "LeftWinger", "24", 7, null },
                    { 179, 30, null, "Goncalo", "Guedes", "LeftWinger", "25", 7, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179);
        }
    }
}
