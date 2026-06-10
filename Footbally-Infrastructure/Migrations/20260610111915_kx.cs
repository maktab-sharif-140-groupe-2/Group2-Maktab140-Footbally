using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 679, 34, null, "Mathew", "Ryan", "GoalKeeper", "1", 28, null },
                    { 680, 24, null, "Joe", "Gauci", "GoalKeeper", "12", 28, null },
                    { 681, 29, null, "Paul", "Izzo", "GoalKeeper", "23", 28, null },
                    { 682, 33, null, "Aziz", "Behich", "LeftBack", "16", 28, null },
                    { 683, 26, null, "Nathaniel", "Atkinson", "RightBAck", "3", 28, null },
                    { 684, 26, null, "Kye", "Rowles", "CenterBack", "4", 28, null },
                    { 685, 27, null, "Harry", "Souttar", "CenterBack", "5", 28, null },
                    { 686, 24, null, "Joel", "King", "LeftBack", "2", 28, null },
                    { 687, 30, null, "Milos", "Degenek", "CenterBack", "22", 28, null },
                    { 688, 27, null, "Thomas", "Deng", "RightBAck", "6", 28, null },
                    { 689, 34, null, "Aaron", "Mooy", "CenterMidfilder", "10", 28, null },
                    { 690, 32, null, "Jackson", "Irvine", "DefendCenterMidfilder", "13", 28, null },
                    { 691, 29, null, "Ajdin", "Hrustic", "AttackingMidfilder", "17", 28, null },
                    { 692, 27, null, "Keanu", "Baccus", "CenterMidfilder", "8", 28, null },
                    { 693, 25, null, "Connor", "Metcalfe", "CenterMidfilder", "14", 28, null },
                    { 694, 27, null, "Cameron", "Devlin", "DefendCenterMidfilder", "15", 28, null },
                    { 695, 27, null, "Riley", "McGree", "AttackingMidfilder", "7", 28, null },
                    { 696, 34, null, "Mathew", "Leckie", "RightWinger", "9", 28, null },
                    { 697, 33, null, "Craig", "Goodwin", "LeftWinger", "11", 28, null },
                    { 698, 31, null, "Jamie", "Maclaren", "CenterForward", "20", 28, null },
                    { 699, 29, null, "Brandon", "Borrello", "CenterForward", "18", 28, null },
                    { 700, 23, null, "Marco", "Tilio", "LeftWinger", "21", 28, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 700);
        }
    }
}
