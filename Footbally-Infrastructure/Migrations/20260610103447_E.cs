using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class E : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 77, 30, null, "Mike", "Maignan", "GoalKeeper", "1", 4, null },
                    { 78, 32, null, "Brice", "Samba", "GoalKeeper", "16", 4, null },
                    { 79, 21, null, "Robin", "Risser", "GoalKeeper", "23", 4, null },
                    { 80, 23, null, "Malo", "Gusto", "RightBAck", "2", 4, null },
                    { 81, 27, null, "Jules", "Kounde", "RightBAck", "5", 4, null },
                    { 82, 32, null, "Lucas", "Digne", "LeftBack", "3", 4, null },
                    { 83, 28, null, "Theo", "Hernandez", "LeftBack", "22", 4, null },
                    { 84, 30, null, "Lucas", "Hernandez", "LeftBack", "21", 4, null },
                    { 85, 25, null, "William", "Saliba", "CenterBack", "17", 4, null },
                    { 86, 27, null, "Dayot", "Upamecano", "CenterBack", "4", 4, null },
                    { 87, 27, null, "Ibrahima", "Konate", "CenterBack", "15", 4, null },
                    { 88, 26, null, "Maxence", "Lacroix", "CenterBack", "24", 4, null },
                    { 89, 26, null, "Aurelien", "Tchouameni", "DefendCenterMidfilder", "8", 4, null },
                    { 90, 31, null, "Adrien", "Rabiot", "CenterMidfilder", "14", 4, null },
                    { 91, 35, null, "NGolo", "Kante", "DefendCenterMidfilder", "13", 4, null },
                    { 92, 25, null, "Manu", "Kone", "CenterMidfilder", "6", 4, null },
                    { 93, 20, null, "Warren", "Zaire-Emery", "CenterMidfilder", "18", 4, null },
                    { 94, 27, null, "Kylian", "Mbappe", "CenterForward", "10", 4, null },
                    { 95, 29, null, "Ousmane", "Dembele", "RightWinger", "7", 4, null },
                    { 96, 24, null, "Michael", "Olise", "RightWinger", "11", 4, null },
                    { 97, 23, null, "Bradley", "Barcola", "LeftWinger", "20", 4, null },
                    { 98, 21, null, "Desire", "Doue", "LeftWinger", "12", 4, null },
                    { 99, 23, null, "Rayan", "Cherki", "AttackingMidfilder", "19", 4, null },
                    { 100, 24, null, "Maghnes", "Akliouche", "AttackingMidfilder", "25", 4, null },
                    { 101, 29, null, "Marcus", "Thuram", "CenterForward", "9", 4, null },
                    { 102, 29, null, "Jean-Philippe", "Mateta", "CenterForward", "26", 4, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
