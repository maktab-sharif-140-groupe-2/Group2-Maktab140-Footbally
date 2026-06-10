using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kvh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 921, 28, null, "Aymen", "Dahmen", "GoalKeeper", "16", 40, null },
                    { 922, 30, null, "Béchir", "Ben Said", "GoalKeeper", "1", 40, null },
                    { 923, 35, null, "Farouk", "Ben Mustapha", "GoalKeeper", "23", 40, null },
                    { 924, 29, null, "Dylan", "Bronn", "CenterBack", "2", 40, null },
                    { 925, 30, null, "Nader", "Ghandri", "CenterBack", "3", 40, null },
                    { 926, 26, null, "Montassar", "Talbi", "CenterBack", "4", 40, null },
                    { 927, 31, null, "Ali", "Abdi", "LeftBack", "5", 40, null },
                    { 928, 32, null, "Hamza", "Mathlouthi", "RightBAck", "6", 40, null },
                    { 929, 28, null, "Mortadha", "Ben Ouanes", "LeftBack", "13", 40, null },
                    { 930, 28, null, "Aïssa", "Laïdouni", "DefendCenterMidfilder", "8", 40, null },
                    { 931, 30, null, "Ellyes", "Skhiri", "CenterMidfilder", "10", 40, null },
                    { 932, 26, null, "Mohamed", "Ali Ben Romdhane", "AttackingMidfilder", "14", 40, null },
                    { 933, 32, null, "Ferjani", "Sassi", "CenterMidfilder", "7", 40, null },
                    { 934, 32, null, "Issam", "Jebali", "RightWinger", "11", 40, null },
                    { 935, 24, null, "Anis", "Ben Slimane", "LeftWinger", "15", 40, null },
                    { 936, 33, null, "Oussama", "Haddadi", "DefendCenterMidfilder", "17", 40, null },
                    { 937, 33, null, "Wahbi", "Khazri", "CenterForward", "9", 40, null },
                    { 938, 30, null, "Seifeddine", "Jaziri", "CenterForward", "18", 40, null },
                    { 939, 34, null, "Youssef", "Msakni", "RightWinger", "19", 40, null },
                    { 940, 32, null, "Naim", "Sliti", "LeftWinger", "20", 40, null },
                    { 941, 24, null, "Yahia", "Fofana", "GoalKeeper", "1", 41, null },
                    { 942, 36, null, "Sylvain", "Gbohouo", "GoalKeeper", "16", 41, null },
                    { 943, 32, null, "Badra", "Ali Sangaré", "GoalKeeper", "23", 41, null },
                    { 944, 32, null, "Serges", "Aurier", "RightBAck", "2", 41, null },
                    { 945, 29, null, "Ghislain", "Konan", "LeftBack", "3", 41, null },
                    { 946, 31, null, "Eric", "Bailly", "CenterBack", "4", 41, null },
                    { 947, 30, null, "Wilfried", "Kanon", "CenterBack", "5", 41, null },
                    { 948, 24, null, "Odilon", "Kossounou", "CenterBack", "6", 41, null },
                    { 949, 29, null, "Jean-Philippe", "Gbamin", "DefendCenterMidfilder", "13", 41, null },
                    { 950, 29, null, "Franck", "Kessié", "CenterMidfilder", "8", 41, null },
                    { 951, 30, null, "Seko", "Fofana", "AttackingMidfilder", "10", 41, null },
                    { 952, 26, null, "Cheick", "Doucouré", "DefendCenterMidfilder", "14", 41, null },
                    { 953, 25, null, "Hamed", "Traoré", "CenterMidfilder", "11", 41, null },
                    { 954, 28, null, "Maxwel", "Cornet", "LeftWinger", "7", 41, null },
                    { 955, 29, null, "Nicolas", "Pépé", "RightWinger", "17", 41, null },
                    { 956, 23, null, "Simon", "Adingra", "LeftWinger", "15", 41, null },
                    { 957, 31, null, "Sebastien", "Haller", "CenterForward", "9", 41, null },
                    { 958, 27, null, "Jean-Philippe", "Krasso", "CenterForward", "18", 41, null },
                    { 959, 23, null, "Arnaud", "Kalimuendo", "CenterForward", "19", 41, null },
                    { 960, 23, null, "Amad", "Diallo", "RightWinger", "20", 41, null },
                    { 961, 29, null, "Lionel", "Mpasi", "GoalKeeper", "16", 42, null },
                    { 962, 28, null, "Hervé", "Koffi", "GoalKeeper", "1", 42, null },
                    { 963, 20, null, "Matthieu", "Epolo", "GoalKeeper", "23", 42, null },
                    { 964, 30, null, "Chancel", "Mbemba", "CenterBack", "4", 42, null },
                    { 965, 31, null, "Arthur", "Masuaku", "LeftBack", "3", 42, null },
                    { 966, 33, null, "Gédéon", "Kakuta", "CenterBack", "5", 42, null },
                    { 967, 23, null, "Ilaix", "Moriba", "CenterMidfilder", "6", 42, null },
                    { 968, 30, null, "Glody", "Ngonda", "RightBAck", "2", 42, null },
                    { 969, 31, null, "Jordan", "Ikoko", "RightBAck", "13", 42, null },
                    { 970, 28, null, "Samuel", "Moutoussamy", "CenterMidfilder", "8", 42, null },
                    { 971, 27, null, "Charles", "Pickel", "DefendCenterMidfilder", "10", 42, null },
                    { 972, 28, null, "Yoane", "Wissa", "LeftWinger", "11", 42, null },
                    { 973, 28, null, "Théo", "Bongonda", "RightWinger", "14", 42, null },
                    { 974, 27, null, "Meschack", "Elia", "LeftWinger", "7", 42, null },
                    { 975, 28, null, "Dylan", "Batubinsika", "CenterMidfilder", "15", 42, null },
                    { 976, 34, null, "Cédric", "Bakambu", "CenterForward", "9", 42, null },
                    { 977, 28, null, "Simon", "Banza", "CenterForward", "18", 42, null },
                    { 978, 25, null, "Jackson", "Muleka", "CenterForward", "19", 42, null },
                    { 979, 28, null, "Theo", "Bongonda", "AttackingMidfilder", "20", 42, null },
                    { 980, 25, null, "Afimico", "Pululu", "CenterForward", "21", 42, null },
                    { 981, 38, null, "Vozinha", "da Luz", "GoalKeeper", "1", 43, null },
                    { 982, 30, null, "Marcos", "Roberto", "GoalKeeper", "16", 43, null },
                    { 983, 28, null, "Jandrei", "Oliveira", "GoalKeeper", "23", 43, null },
                    { 984, 36, null, "Stopira", "Gonçalves", "LeftBack", "2", 43, null },
                    { 985, 30, null, "Steven", "Fortes", "CenterBack", "3", 43, null },
                    { 986, 25, null, "Logan", "Costa", "CenterBack", "4", 43, null },
                    { 987, 29, null, "Diney", "Pinto", "RightBAck", "5", 43, null },
                    { 988, 25, null, "Nuno", "Tavares", "LeftBack", "6", 43, null },
                    { 989, 31, null, "João", "Paulo", "CenterBack", "13", 43, null },
                    { 990, 31, null, "Rúben", "Semedo", "CenterMidfilder", "8", 43, null },
                    { 991, 28, null, "Kevin", "Pina", "DefendCenterMidfilder", "10", 43, null },
                    { 992, 33, null, "Ryan", "Mendes", "LeftWinger", "11", 43, null },
                    { 993, 30, null, "Jamiro", "Monteiro", "AttackingMidfilder", "14", 43, null },
                    { 994, 33, null, "Garry", "Rodrigues", "RightWinger", "7", 43, null },
                    { 995, 32, null, "Patrick", "Andrade", "CenterMidfilder", "15", 43, null },
                    { 996, 27, null, "Lisandro", "Semedo", "LeftWinger", "17", 43, null },
                    { 997, 34, null, "Bebé", "Ramos", "CenterForward", "9", 43, null },
                    { 998, 28, null, "Henrique", "Tavares", "CenterForward", "18", 43, null },
                    { 999, 29, null, "Elton", "Monteiro", "RightWinger", "19", 43, null },
                    { 1000, 26, null, "Jovane", "Cabral", "LeftWinger", "20", 43, null }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoachName", "Country", "GroupNumber" },
                values: new object[] { "Darren Bazeley", "New Zealand", 7 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoachName", "Country", "GroupNumber" },
                values: new object[] { "Lionel Scaloni", "Argentina", 10 });
        }
    }
}
