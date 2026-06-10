using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class G : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 129, 28, null, "Unai", "Simon", "GoalKeeper", "1", 6, null },
                    { 130, 30, null, "David", "Raya", "GoalKeeper", "13", 6, null },
                    { 131, 25, null, "Joan", "Garcia", "GoalKeeper", "23", 6, null },
                    { 132, 26, null, "Pedro", "Porro", "RightBAck", "2", 6, null },
                    { 133, 31, null, "Marcos", "Llorente", "RightBAck", "14", 6, null },
                    { 134, 32, null, "Aymeric", "Laporte", "CenterBack", "4", 6, null },
                    { 135, 19, null, "Pau", "Cubarsi", "CenterBack", "5", 6, null },
                    { 136, 22, null, "Marc", "Pubill", "RightBAck", "15", 6, null },
                    { 137, 25, null, "Eric", "Garcia", "CenterBack", "3", 6, null },
                    { 138, 27, null, "Marc", "Cucurella", "LeftBack", "24", 6, null },
                    { 139, 30, null, "Alex", "Grimaldo", "LeftBack", "18", 6, null },
                    { 140, 29, null, "Rodri", "Hernandez", "DefendCenterMidfilder", "6", 6, null },
                    { 141, 27, null, "Martin", "Zubimendi", "DefendCenterMidfilder", "16", 6, null },
                    { 142, 23, null, "Pedri", "Gonzalez", "CenterMidfilder", "8", 6, null },
                    { 143, 30, null, "Fabian", "Ruiz", "CenterMidfilder", "20", 6, null },
                    { 144, 29, null, "Mikel", "Merino", "CenterMidfilder", "5", 6, null },
                    { 145, 21, null, "Pablo", "Gavi", "AttackingMidfilder", "9", 6, null },
                    { 146, 24, null, "Alex", "Baena", "AttackingMidfilder", "17", 6, null },
                    { 147, 29, null, "Mikel", "Oyarzabal", "CenterForward", "21", 6, null },
                    { 148, 18, null, "Lamine", "Yamal", "RightWinger", "19", 6, null },
                    { 149, 26, null, "Ferran", "Torres", "CenterForward", "11", 6, null },
                    { 150, 33, null, "Borja", "Iglesias", "CenterForward", "22", 6, null },
                    { 151, 28, null, "Dani", "Olmo", "AttackingMidfilder", "10", 6, null },
                    { 152, 22, null, "Victor", "Munoz", "LeftWinger", "25", 6, null },
                    { 153, 23, null, "Nico", "Williams", "LeftWinger", "17", 6, null },
                    { 154, 23, null, "Yeremy", "Pino", "RightWinger", "7", 6, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154);
        }
    }
}
