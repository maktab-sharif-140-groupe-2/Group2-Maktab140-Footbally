using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 659, 33, null, "Alireza", "Beiranvand", "GoalKeeper", "1", 27, null },
                    { 660, 32, null, "Seyed Hossein", "Hosseini", "GoalKeeper", "22", 27, null },
                    { 661, 29, null, "Payam", "Niazmand", "GoalKeeper", "12", 27, null },
                    { 662, 33, null, "Morteza", "Pouraliganji", "CenterBack", "8", 27, null },
                    { 663, 31, null, "Hossein", "Kanaani", "CenterBack", "4", 27, null },
                    { 664, 35, null, "Shoja", "Khalilzadeh", "CenterBack", "5", 27, null },
                    { 665, 34, null, "Ramin", "Rezaeian", "RightBAck", "2", 27, null },
                    { 666, 31, null, "Milad", "Mohammadi", "LeftBack", "3", 27, null },
                    { 667, 30, null, "Saeid", "Moharrami", "RightBAck", "19", 27, null },
                    { 668, 35, null, "Ehsan", "Hajsafi", "CenterMidfilder", "10", 27, null },
                    { 669, 31, null, "Saman", "Ghoddos", "AttackingMidfilder", "14", 27, null },
                    { 670, 31, null, "Alireza", "Jahanbakhsh", "RightWinger", "7", 27, null },
                    { 671, 33, null, "Mehdi", "Taremi", "CenterForward", "9", 27, null },
                    { 672, 30, null, "Sardar", "Azmoun", "CenterForward", "20", 27, null },
                    { 673, 26, null, "Mehdi", "Ghayedi", "LeftWinger", "11", 27, null },
                    { 674, 26, null, "Mohammad", "Mohebi", "RightWinger", "17", 27, null },
                    { 675, 28, null, "Ali", "Gholizadeh", "AttackingMidfilder", "18", 27, null },
                    { 676, 32, null, "Kaveh", "Rezaei", "CenterForward", "16", 27, null },
                    { 677, 30, null, "Shahriar", "Moghanlou", "CenterForward", "21", 27, null },
                    { 678, 22, null, "Amirhossein", "Hossein-Zadeh", "LeftWinger", "23", 27, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 678);
        }
    }
}
