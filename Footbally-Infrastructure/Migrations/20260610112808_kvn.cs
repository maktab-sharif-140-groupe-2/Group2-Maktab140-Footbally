using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kvn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 861, 28, null, "Anthony", "Mandrea", "GoalKeeper", "16", 37, null },
                    { 862, 29, null, "Alexis", "Guendouz", "GoalKeeper", "23", 37, null },
                    { 863, 30, null, "Oussama", "Benbot", "GoalKeeper", "1", 37, null },
                    { 864, 27, null, "Luca", "Zidane", "GoalKeeper", "12", 37, null },
                    { 865, 30, null, "Ramy", "Bensebaini", "LeftBack", "2", 37, null },
                    { 866, 33, null, "Aïssa", "Mandi", "CenterBack", "3", 37, null },
                    { 867, 25, null, "Mohamed", "Tougaï", "CenterBack", "4", 37, null },
                    { 868, 29, null, "Kevin", "Guitoun", "RightBAck", "6", 37, null },
                    { 869, 21, null, "Farès", "Chaïbi", "CenterMidfilder", "13", 37, null },
                    { 870, 27, null, "Ismaël", "Bennacer", "CenterMidfilder", "8", 37, null },
                    { 871, 35, null, "Sofiane", "Feghouli", "AttackingMidfilder", "10", 37, null },
                    { 872, 27, null, "Ramiz", "Zerrouki", "DefendCenterMidfilder", "14", 37, null },
                    { 873, 27, null, "Houssem", "Aouar", "AttackingMidfilder", "11", 37, null },
                    { 874, 28, null, "Adam", "Ounas", "RightWinger", "17", 37, null },
                    { 875, 32, null, "Youcef", "Belaili", "LeftWinger", "15", 37, null },
                    { 876, 34, null, "Riyad", "Mahrez", "RightWinger", "7", 37, null },
                    { 877, 37, null, "Islam", "Slimani", "CenterForward", "9", 37, null },
                    { 878, 25, null, "Mohamed", "Amoura", "CenterForward", "18", 37, null },
                    { 879, 30, null, "Said", "Benrahma", "LeftWinger", "19", 37, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 879);
        }
    }
}
