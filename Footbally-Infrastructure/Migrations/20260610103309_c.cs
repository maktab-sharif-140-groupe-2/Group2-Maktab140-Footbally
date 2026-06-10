using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 51, 32, null, "Jordan", "Pickford", "GoalKeeper", "1", 3, null },
                    { 52, 29, null, "Dean", "Henderson", "GoalKeeper", "13", 3, null },
                    { 53, 23, null, "James", "Trafford", "GoalKeeper", "23", 3, null },
                    { 54, 34, null, "Dan", "Burn", "CenterBack", "14", 3, null },
                    { 55, 26, null, "Marc", "Guehi", "CenterBack", "6", 3, null },
                    { 56, 26, null, "Reece", "James", "RightBAck", "2", 3, null },
                    { 57, 29, null, "Ezri", "Konsa", "CenterBack", "5", 3, null },
                    { 58, 24, null, "Tino", "Livramento", "RightBAck", "21", 3, null },
                    { 59, 21, null, "Nico", "OReilly", "LeftBack", "3", 3, null },
                    { 60, 23, null, "Jarell", "Quansah", "CenterBack", "15", 3, null },
                    { 61, 26, null, "Djed", "Spence", "RightBAck", "12", 3, null },
                    { 62, 32, null, "John", "Stones", "CenterBack", "4", 3, null },
                    { 63, 23, null, "Elliot", "Anderson", "CenterMidfilder", "16", 3, null },
                    { 64, 23, null, "Jude", "Bellingham", "AttackingMidfilder", "10", 3, null },
                    { 65, 28, null, "Eberechi", "Eze", "AttackingMidfilder", "18", 3, null },
                    { 66, 36, null, "Jordan", "Henderson", "DefendCenterMidfilder", "8", 3, null },
                    { 67, 21, null, "Kobbie", "Mainoo", "CenterMidfilder", "26", 3, null },
                    { 68, 27, null, "Declan", "Rice", "DefendCenterMidfilder", "7", 3, null },
                    { 69, 24, null, "Morgan", "Rogers", "AttackingMidfilder", "17", 3, null },
                    { 70, 25, null, "Anthony", "Gordon", "LeftWinger", "11", 3, null },
                    { 71, 33, null, "Harry", "Kane", "CenterForward", "9", 3, null },
                    { 72, 24, null, "Noni", "Madueke", "RightWinger", "20", 3, null },
                    { 73, 28, null, "Marcus", "Rashford", "LeftWinger", "19", 3, null },
                    { 74, 25, null, "Bukayo", "Saka", "RightWinger", "25", 3, null },
                    { 75, 30, null, "Ivan", "Toney", "CenterForward", "22", 3, null },
                    { 76, 31, null, "Ollie", "Watkins", "CenterForward", "24", 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);
        }
    }
}
