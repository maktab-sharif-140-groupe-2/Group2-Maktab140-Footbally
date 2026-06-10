using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 205, 23, null, "Bart", "Verbruggen", "GoalKeeper", "1", 9, null },
                    { 206, 32, null, "Mark", "Flekken", "GoalKeeper", "13", 9, null },
                    { 207, 22, null, "Robin", "Roefs", "GoalKeeper", "23", 9, null },
                    { 208, 34, null, "Virgil", "van Dijk", "CenterBack", "4", 9, null },
                    { 209, 31, null, "Nathan", "Ake", "CenterBack", "5", 9, null },
                    { 210, 25, null, "Micky", "van de Ven", "CenterBack", "15", 9, null },
                    { 211, 25, null, "Jan Paul", "van Hecke", "CenterBack", "3", 9, null },
                    { 212, 20, null, "Jorrel", "Hato", "LeftBack", "2", 9, null },
                    { 213, 24, null, "Jurriën", "Timber", "RightBAck", "12", 9, null },
                    { 214, 30, null, "Denzel", "Dumfries", "RightBAck", "22", 9, null },
                    { 215, 29, null, "Frenkie", "de Jong", "CenterMidfilder", "21", 9, null },
                    { 216, 24, null, "Ryan", "Gravenberch", "CenterMidfilder", "8", 9, null },
                    { 217, 27, null, "Tijjani", "Reijnders", "CenterMidfilder", "14", 9, null },
                    { 218, 28, null, "Teun", "Koopmeiners", "CenterMidfilder", "6", 9, null },
                    { 219, 35, null, "Marten", "de Roon", "DefendCenterMidfilder", "18", 9, null },
                    { 220, 24, null, "Quinten", "Timber", "CenterMidfilder", "20", 9, null },
                    { 221, 28, null, "Guus", "Til", "AttackingMidfilder", "16", 9, null },
                    { 222, 26, null, "Mats", "Wieffer", "DefendCenterMidfilder", "17", 9, null },
                    { 223, 32, null, "Memphis", "Depay", "CenterForward", "10", 9, null },
                    { 224, 27, null, "Cody", "Gakpo", "LeftWinger", "11", 9, null },
                    { 225, 27, null, "Donyell", "Malen", "RightWinger", "7", 9, null },
                    { 226, 27, null, "Justin", "Kluivert", "AttackingMidfilder", "19", 9, null },
                    { 227, 26, null, "Noa", "Lang", "LeftWinger", "9", 9, null },
                    { 228, 24, null, "Brian", "Brobbey", "CenterForward", "24", 9, null },
                    { 229, 24, null, "Crysencio", "Summerville", "RightWinger", "25", 9, null },
                    { 230, 33, null, "Wout", "Weghorst", "CenterForward", "26", 9, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230);
        }
    }
}
