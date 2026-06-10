using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 334, 35, null, "Orjan", "Nyland", "GoalKeeper", "1", 14, null },
                    { 335, 28, null, "Egil", "Selvik", "GoalKeeper", "12", 14, null },
                    { 336, 23, null, "Sander", "Tangvik", "GoalKeeper", "23", 14, null },
                    { 337, 28, null, "Kristoffer", "Ajer", "CenterBack", "3", 14, null },
                    { 338, 26, null, "Leo", "Ostigard", "CenterBack", "4", 14, null },
                    { 339, 28, null, "Julian", "Ryerson", "RightBAck", "2", 14, null },
                    { 340, 25, null, "Marcus", "Pedersen", "RightBAck", "14", 14, null },
                    { 341, 27, null, "Fredrik", "Bjorkan", "LeftBack", "5", 14, null },
                    { 342, 24, null, "David", "Wolfe", "LeftBack", "13", 14, null },
                    { 343, 27, null, "Torbjorn", "Heggem", "CenterBack", "15", 14, null },
                    { 344, 25, null, "Sondre", "Langas", "CenterBack", "16", 14, null },
                    { 345, 23, null, "Henrik", "Falchener", "CenterBack", "22", 14, null },
                    { 346, 27, null, "Martin", "Odegaard", "AttackingMidfilder", "10", 14, null },
                    { 347, 28, null, "Sander", "Berge", "DefendCenterMidfilder", "8", 14, null },
                    { 348, 28, null, "Patrick", "Berg", "DefendCenterMidfilder", "6", 14, null },
                    { 349, 30, null, "Fredrik", "Aursnes", "CenterMidfilder", "18", 14, null },
                    { 350, 27, null, "Kristian", "Thorstvedt", "CenterMidfilder", "20", 14, null },
                    { 351, 30, null, "Morten", "Thorsby", "CenterMidfilder", "19", 14, null },
                    { 352, 22, null, "Oscar", "Bobb", "RightWinger", "11", 14, null },
                    { 353, 24, null, "Thelo", "Aasgaard", "AttackingMidfilder", "21", 14, null },
                    { 354, 22, null, "Andreas", "Schjelderup", "LeftWinger", "17", 14, null },
                    { 355, 26, null, "Jens", "Hauge", "LeftWinger", "7", 14, null },
                    { 356, 25, null, "Erling", "Haaland", "CenterForward", "9", 14, null },
                    { 357, 30, null, "Alexander", "Sorloth", "CenterForward", "18", 14, null },
                    { 358, 26, null, "Jorgen", "Strand Larsen", "CenterForward", "24", 14, null },
                    { 359, 21, null, "Antonio", "Nusa", "LeftWinger", "14", 14, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359);
        }
    }
}
