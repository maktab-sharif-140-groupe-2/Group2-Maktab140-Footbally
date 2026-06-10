using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 412, 23, null, "Lukas", "Hornicek", "GoalKeeper", "1", 17, null },
                    { 413, 26, null, "Matej", "Kovar", "GoalKeeper", "12", 17, null },
                    { 414, 30, null, "Jindrich", "Stanek", "GoalKeeper", "23", 17, null },
                    { 415, 33, null, "Vladimir", "Coufal", "RightBAck", "2", 17, null },
                    { 416, 28, null, "David", "Doudera", "RightBAck", "3", 17, null },
                    { 417, 33, null, "Tomas", "Holes", "CenterBack", "4", 17, null },
                    { 418, 26, null, "Robin", "Hranac", "CenterBack", "5", 17, null },
                    { 419, 23, null, "Stepan", "Chaloupek", "CenterBack", "6", 17, null },
                    { 420, 25, null, "David", "Jurasek", "LeftBack", "13", 17, null },
                    { 421, 27, null, "Ladislav", "Krejci", "CenterBack", "7", 17, null },
                    { 422, 33, null, "Jaroslav", "Zeleny", "LeftBack", "18", 17, null },
                    { 423, 25, null, "David", "Zima", "CenterBack", "15", 17, null },
                    { 424, 25, null, "Lukas", "Cerv", "CenterMidfilder", "8", 17, null },
                    { 425, 35, null, "Vladimir", "Darida", "CenterMidfilder", "10", 17, null },
                    { 426, 29, null, "Lukas", "Provod", "AttackingMidfilder", "14", 17, null },
                    { 427, 27, null, "Michal", "Sadilek", "DefendCenterMidfilder", "22", 17, null },
                    { 428, 17, null, "Hugo", "Sochurek", "CenterMidfilder", "24", 17, null },
                    { 429, 23, null, "Alexandr", "Sojka", "CenterMidfilder", "16", 17, null },
                    { 430, 31, null, "Tomas", "Soucek", "DefendCenterMidfilder", "21", 17, null },
                    { 431, 25, null, "Pavel", "Sulc", "AttackingMidfilder", "11", 17, null },
                    { 432, 23, null, "Denis", "Visinsky", "RightWinger", "19", 17, null },
                    { 433, 23, null, "Adam", "Hlozek", "CenterForward", "9", 17, null },
                    { 434, 31, null, "Tomas", "Chory", "CenterForward", "20", 17, null },
                    { 435, 27, null, "Mojmir", "Chytil", "CenterForward", "17", 17, null },
                    { 436, 29, null, "Jan", "Kuchta", "CenterForward", "25", 17, null },
                    { 437, 30, null, "Patrik", "Schick", "CenterForward", "10", 17, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437);
        }
    }
}
