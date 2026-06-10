using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 563, 37, null, "Eloy", "Room", "GoalKeeper", "1", 23, null },
                    { 564, 24, null, "Tyrick", "Bodak", "GoalKeeper", "25", 23, null },
                    { 565, 27, null, "Trevor", "Doornbusch", "GoalKeeper", "26", 23, null },
                    { 566, 24, null, "Shurandy", "Sambo", "RightBAck", "2", 23, null },
                    { 567, 32, null, "Jurien", "Gaari", "RightBAck", "3", 23, null },
                    { 568, 27, null, "Roshon", "Van Eijma", "CenterBack", "4", 23, null },
                    { 569, 27, null, "Sherel", "Floranus", "LeftBack", "5", 23, null },
                    { 570, 32, null, "Joshua", "Brenet", "RightBAck", "20", 23, null },
                    { 571, 29, null, "Riechedly", "Bazoer", "CenterBack", "23", 23, null },
                    { 572, 27, null, "Armando", "Obispo", "CenterBack", "18", 23, null },
                    { 573, 23, null, "Deveron", "Fonville", "CenterBack", "24", 23, null },
                    { 574, 28, null, "Juninho", "Bacuna", "CenterMidfilder", "7", 23, null },
                    { 575, 34, null, "Leandro", "Bacuna", "CenterMidfilder", "10", 23, null },
                    { 576, 26, null, "Godfried", "Roemeratoe", "DefendCenterMidfilder", "6", 23, null },
                    { 577, 26, null, "Kevin", "Felida", "DefendCenterMidfilder", "22", 23, null },
                    { 578, 22, null, "Livano", "Comenencia", "CenterMidfilder", "8", 23, null },
                    { 579, 23, null, "Tyrese", "Noslin", "RightWinger", "13", 23, null },
                    { 580, 22, null, "Arjany", "Martha", "RightWinger", "15", 23, null },
                    { 581, 32, null, "Jurgen", "Locadia", "CenterForward", "9", 23, null },
                    { 582, 24, null, "Jeremy", "Antonisse", "LeftWinger", "11", 23, null },
                    { 583, 24, null, "Sontje", "Hansen", "RightWinger", "12", 23, null },
                    { 584, 31, null, "Kenji", "Gorre", "LeftWinger", "14", 23, null },
                    { 585, 25, null, "Jearl", "Margaritha", "LeftWinger", "16", 23, null },
                    { 586, 33, null, "Brandley", "Kuwas", "RightWinger", "17", 23, null },
                    { 587, 29, null, "Gervane", "Kastaneer", "CenterForward", "19", 23, null },
                    { 588, 26, null, "Tahith", "Chong", "AttackingMidfilder", "21", 23, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 588);
        }
    }
}
