using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 386, 30, null, "Nikola", "Vasilj", "GoalKeeper", "1", 16, null },
                    { 387, 31, null, "Kenan", "Piric", "GoalKeeper", "12", 16, null },
                    { 388, 29, null, "Osman", "Hadzikic", "GoalKeeper", "23", 16, null },
                    { 389, 24, null, "Amar", "Dedic", "RightBAck", "2", 16, null },
                    { 390, 33, null, "Sead", "Kolasinac", "LeftBack", "5", 16, null },
                    { 391, 24, null, "Adrian", "Leon Barisic", "CenterBack", "3", 16, null },
                    { 392, 27, null, "Anel", "Ahmedhodzic", "CenterBack", "4", 16, null },
                    { 393, 28, null, "Dennis", "Hadzikadunic", "CenterBack", "15", 16, null },
                    { 394, 23, null, "Tarik", "Muharemovic", "CenterBack", "16", 16, null },
                    { 395, 30, null, "Eldar", "Civic", "LeftBack", "18", 16, null },
                    { 396, 27, null, "Nihad", "Mujakic", "CenterBack", "22", 16, null },
                    { 397, 23, null, "Benjamin", "Tahirovic", "DefendCenterMidfilder", "6", 16, null },
                    { 398, 29, null, "Amir", "Hadziahmetovic", "CenterMidfilder", "8", 16, null },
                    { 399, 24, null, "Ivan", "Basic", "CenterMidfilder", "10", 16, null },
                    { 400, 24, null, "Armin", "Gigovic", "CenterMidfilder", "14", 16, null },
                    { 401, 28, null, "Dario", "Saric", "CenterMidfilder", "17", 16, null },
                    { 402, 32, null, "Haris", "Hajradinovic", "AttackingMidfilder", "20", 16, null },
                    { 403, 21, null, "Esmir", "Bajraktarevic", "RightWinger", "7", 16, null },
                    { 404, 28, null, "Ermedin", "Demirovic", "AttackingMidfilder", "11", 16, null },
                    { 405, 40, null, "Edin", "Dzeko", "CenterForward", "9", 16, null },
                    { 406, 22, null, "Samed", "Bazdar", "CenterForward", "19", 16, null },
                    { 407, 26, null, "Luka", "Kulenovic", "CenterForward", "21", 16, null },
                    { 408, 32, null, "Armin", "Tabakovic", "CenterForward", "24", 16, null },
                    { 409, 23, null, "Nail", "Omerovic", "LeftWinger", "25", 16, null },
                    { 410, 28, null, "Dzenis", "Burnic", "CenterMidfilder", "26", 16, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410);
        }
    }
}
