using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kvb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 841, 36, null, "Mohamed", "El-Shenawy", "GoalKeeper", "1", 36, null },
                    { 842, 25, null, "Mohamed", "Sobhi", "GoalKeeper", "16", 36, null },
                    { 843, 25, null, "Mostafa", "Shobeir", "GoalKeeper", "23", 36, null },
                    { 844, 34, null, "Ahmed", "Hegazi", "CenterBack", "5", 36, null },
                    { 845, 26, null, "Mohamed", "Abdelmonem", "CenterBack", "4", 36, null },
                    { 846, 28, null, "Omar", "Kamal", "RightBAck", "2", 36, null },
                    { 847, 27, null, "Ahmed", "Fatouh", "LeftBack", "3", 36, null },
                    { 848, 32, null, "Rami", "Rabia", "CenterBack", "6", 36, null },
                    { 849, 29, null, "Mohamed", "Hany", "RightBAck", "13", 36, null },
                    { 850, 33, null, "Mohamed", "Elneny", "DefendCenterMidfilder", "17", 36, null },
                    { 851, 34, null, "Tarek", "Hamed", "DefendCenterMidfilder", "8", 36, null },
                    { 852, 30, null, "Hamdy", "Fathi", "CenterMidfilder", "14", 36, null },
                    { 853, 26, null, "Emam", "Ashour", "AttackingMidfilder", "10", 36, null },
                    { 854, 26, null, "Marwan", "Attia", "CenterMidfilder", "11", 36, null },
                    { 855, 29, null, "Ahmed", "Sayed Zizo", "RightWinger", "7", 36, null },
                    { 856, 30, null, "Mahmoud", "Hassan Trezeguet", "LeftWinger", "9", 36, null },
                    { 857, 33, null, "Mohamed", "Salah", "RightWinger", "10", 36, null },
                    { 858, 27, null, "Mostafa", "Mohamed", "CenterForward", "18", 36, null },
                    { 859, 32, null, "Ahmed", "Kouka", "CenterForward", "19", 36, null },
                    { 860, 25, null, "Osama", "Faisal", "LeftWinger", "20", 36, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 860);
        }
    }
}
