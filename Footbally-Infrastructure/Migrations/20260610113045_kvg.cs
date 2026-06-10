using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kvg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 881, 33, null, "Ronwen", "Williams", "GoalKeeper", "1", 38, null },
                    { 882, 32, null, "Veli", "Mothwa", "GoalKeeper", "16", 38, null },
                    { 883, 30, null, "Ricardo", "Goss", "GoalKeeper", "23", 38, null },
                    { 884, 29, null, "Thapelo", "Xoki", "CenterBack", "2", 38, null },
                    { 885, 35, null, "Ramahlwe", "Mphahlele", "RightBAck", "3", 38, null },
                    { 886, 29, null, "Nkosinathi", "Sibisi", "CenterBack", "4", 38, null },
                    { 887, 29, null, "Aubrey", "Modiba", "LeftBack", "5", 38, null },
                    { 888, 33, null, "Siyanda", "Xulu", "CenterBack", "6", 38, null },
                    { 889, 31, null, "Thibang", "Phete", "DefendCenterMidfilder", "13", 38, null },
                    { 890, 34, null, "Andile", "Jali", "DefendCenterMidfilder", "8", 38, null },
                    { 891, 28, null, "Teboho", "Mokoena", "CenterMidfilder", "4", 38, null },
                    { 892, 26, null, "Mahlobo", "Sibiya", "AttackingMidfilder", "11", 38, null },
                    { 893, 27, null, "Sipho", "Mbule", "CenterMidfilder", "10", 38, null },
                    { 894, 25, null, "Sphephelo", "Sithole", "DefendCenterMidfilder", "14", 38, null },
                    { 895, 31, null, "Percy", "Tau", "RightWinger", "7", 38, null },
                    { 896, 35, null, "Themba", "Zwane", "AttackingMidfilder", "9", 38, null },
                    { 897, 25, null, "Lyle", "Foster", "CenterForward", "10", 38, null },
                    { 898, 29, null, "Iqraam", "Rayners", "CenterForward", "18", 38, null },
                    { 899, 28, null, "Zakhele", "Lepasa", "CenterForward", "19", 38, null },
                    { 900, 24, null, "Cassius", "Mailula", "LeftWinger", "20", 38, null },
                    { 901, 29, null, "André", "Onana", "GoalKeeper", "1", 39, null },
                    { 902, 28, null, "Lawrence", "Ati-Zigi", "GoalKeeper", "16", 39, null },
                    { 903, 32, null, "Richard", "Ofori", "GoalKeeper", "23", 39, null },
                    { 904, 30, null, "Daniel", "Amartey", "CenterBack", "4", 39, null },
                    { 905, 30, null, "Alexander", "Djiku", "CenterBack", "5", 39, null },
                    { 906, 26, null, "Mohammed", "Salisu", "CenterBack", "3", 39, null },
                    { 907, 25, null, "Alidu", "Seidu", "RightBAck", "2", 39, null },
                    { 908, 31, null, "Baba", "Rahman", "LeftBack", "6", 39, null },
                    { 909, 24, null, "Tariq", "Lamptey", "RightBAck", "13", 39, null },
                    { 910, 32, null, "Thomas", "Partey", "DefendCenterMidfilder", "8", 39, null },
                    { 911, 34, null, "Mubarak", "Wakaso", "CenterMidfilder", "10", 39, null },
                    { 912, 27, null, "Elisha", "Owusu", "CenterMidfilder", "14", 39, null },
                    { 913, 29, null, "Iddrisu", "Baba", "DefendCenterMidfilder", "15", 39, null },
                    { 914, 26, null, "Kamal", "Sowah", "RightWinger", "11", 39, null },
                    { 915, 25, null, "Mohammed", "Kudus", "AttackingMidfilder", "7", 39, null },
                    { 916, 26, null, "Antoine", "Semenyo", "LeftWinger", "17", 39, null },
                    { 917, 31, null, "Inaki", "Williams", "CenterForward", "9", 39, null },
                    { 918, 33, null, "Jordan", "Ayew", "RightWinger", "18", 39, null },
                    { 919, 35, null, "Andre", "Ayew", "LeftWinger", "19", 39, null },
                    { 920, 21, null, "Ernest", "Nuamah", "LeftWinger", "20", 39, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 920);
        }
    }
}
