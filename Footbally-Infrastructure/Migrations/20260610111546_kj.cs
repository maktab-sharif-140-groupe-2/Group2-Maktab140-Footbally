using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 637, 33, null, "Jo", "Hyeon-woo", "GoalKeeper", "1", 26, null },
                    { 638, 34, null, "Kim", "Seung-gyu", "GoalKeeper", "21", 26, null },
                    { 639, 31, null, "Lee", "Chang-geun", "GoalKeeper", "12", 26, null },
                    { 640, 29, null, "Kim", "Min-jae", "CenterBack", "4", 26, null },
                    { 641, 35, null, "Kim", "Young-gwon", "CenterBack", "19", 26, null },
                    { 642, 30, null, "Jung", "Seung-hyun", "CenterBack", "15", 26, null },
                    { 643, 33, null, "Kim", "Jin-su", "LeftBack", "3", 26, null },
                    { 644, 33, null, "Lee", "Ki-je", "LeftBack", "2", 26, null },
                    { 645, 35, null, "Kim", "Tae-hwan", "RightBAck", "23", 26, null },
                    { 646, 26, null, "Seol", "Young-woo", "RightBAck", "22", 26, null },
                    { 647, 24, null, "Lee", "Kang-in", "AttackingMidfilder", "10", 26, null },
                    { 648, 29, null, "Hwang", "In-beom", "DefendCenterMidfilder", "6", 26, null },
                    { 649, 28, null, "Paik", "Seung-ho", "CenterMidfilder", "8", 26, null },
                    { 650, 26, null, "Jeong", "Woo-yeong", "CenterMidfilder", "14", 26, null },
                    { 651, 26, null, "Hong", "Hyun-seok", "AttackingMidfilder", "17", 26, null },
                    { 652, 32, null, "Lee", "Jae-sung", "CenterMidfilder", "7", 26, null },
                    { 653, 29, null, "Hwang", "Hee-chan", "LeftWinger", "11", 26, null },
                    { 654, 24, null, "Kim", "Jin-kyu", "RightWinger", "18", 26, null },
                    { 655, 33, null, "Son", "Heung-min", "LeftWinger", "7", 26, null },
                    { 656, 27, null, "Cho", "Gue-sung", "CenterForward", "9", 26, null },
                    { 657, 32, null, "Hwang", "Ui-jo", "CenterForward", "16", 26, null },
                    { 658, 26, null, "Oh", "Se-hun", "CenterForward", "20", 26, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 658);
        }
    }
}
