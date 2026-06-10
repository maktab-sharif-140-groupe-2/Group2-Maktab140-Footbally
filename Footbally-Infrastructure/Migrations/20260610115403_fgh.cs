using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fgh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1001, 32, null, "Sergio", "Rochet", "GoalKeeper", "1", 45, null },
                    { 1002, 27, null, "Santiago", "Mele", "GoalKeeper", "16", 45, null },
                    { 1003, 24, null, "Franco", "Israel", "GoalKeeper", "23", 45, null },
                    { 1004, 30, null, "José", "Giménez", "CenterBack", "2", 45, null },
                    { 1005, 26, null, "Ronald", "Araújo", "CenterBack", "4", 45, null },
                    { 1006, 27, null, "Matías", "Viña", "LeftBack", "3", 45, null },
                    { 1007, 29, null, "Nahitan", "Nández", "RightBAck", "8", 45, null },
                    { 1008, 34, null, "Sebastián", "Coates", "CenterBack", "6", 45, null },
                    { 1009, 32, null, "Guillermo", "Varela", "RightBAck", "13", 45, null },
                    { 1010, 27, null, "Federico", "Valverde", "CenterMidfilder", "10", 45, null },
                    { 1011, 28, null, "Rodrigo", "Bentancur", "CenterMidfilder", "14", 45, null },
                    { 1012, 24, null, "Manuel", "Ugarte", "DefendCenterMidfilder", "5", 45, null },
                    { 1013, 28, null, "Nicolás", "De la Cruz", "AttackingMidfilder", "7", 45, null },
                    { 1014, 31, null, "Giorgian", "De Arrascaeta", "AttackingMidfilder", "11", 45, null },
                    { 1015, 29, null, "Lucas", "Torreira", "DefendCenterMidfilder", "15", 45, null },
                    { 1016, 24, null, "Facundo", "Pellistri", "RightWinger", "17", 45, null },
                    { 1017, 26, null, "Darwin", "Núñez", "CenterForward", "9", 45, null },
                    { 1018, 39, null, "Luis", "Suárez", "CenterForward", "18", 45, null },
                    { 1019, 29, null, "Maximiliano", "Gómez", "CenterForward", "19", 45, null },
                    { 1020, 25, null, "Brian", "Rodríguez", "LeftWinger", "20", 45, null },
                    { 1021, 37, null, "David", "Ospina", "GoalKeeper", "1", 46, null },
                    { 1022, 36, null, "Camilo", "Vargas", "GoalKeeper", "12", 46, null },
                    { 1023, 25, null, "Kevin", "Mier", "GoalKeeper", "23", 46, null },
                    { 1024, 29, null, "Davinson", "Sánchez", "CenterBack", "4", 46, null },
                    { 1025, 31, null, "Yerry", "Mina", "CenterBack", "13", 46, null },
                    { 1026, 27, null, "Jhon", "Lucumí", "CenterBack", "3", 46, null },
                    { 1027, 29, null, "Daniel", "Muñoz", "RightBAck", "2", 46, null },
                    { 1028, 33, null, "Santiago", "Arias", "RightBAck", "6", 46, null },
                    { 1029, 34, null, "Frank", "Fabra", "LeftBack", "17", 46, null },
                    { 1030, 30, null, "Jefferson", "Lerma", "DefendCenterMidfilder", "8", 46, null },
                    { 1031, 34, null, "Mateus", "Uribe", "CenterMidfilder", "15", 46, null },
                    { 1032, 31, null, "Wilmar", "Barrios", "DefendCenterMidfilder", "5", 46, null },
                    { 1033, 34, null, "James", "Rodríguez", "AttackingMidfilder", "10", 46, null },
                    { 1034, 28, null, "Jhon", "Arias", "RightWinger", "11", 46, null },
                    { 1035, 28, null, "Luis", "Díaz", "LeftWinger", "7", 46, null },
                    { 1036, 25, null, "Richard", "Ríos", "CenterMidfilder", "16", 46, null },
                    { 1037, 30, null, "Rafael", "Borré", "CenterForward", "9", 46, null },
                    { 1038, 31, null, "Jhon", "Córdoba", "CenterForward", "19", 46, null },
                    { 1039, 28, null, "Julián", "Quiñones", "LeftWinger", "20", 46, null },
                    { 1040, 34, null, "Duván", "Zapata", "CenterForward", "18", 46, null },
                    { 1041, 38, null, "Hernán", "Galíndez", "GoalKeeper", "1", 47, null },
                    { 1042, 38, null, "Alexander", "Domínguez", "GoalKeeper", "12", 47, null },
                    { 1043, 25, null, "Moises", "Ramírez", "GoalKeeper", "23", 47, null },
                    { 1044, 23, null, "Piero", "Hincapié", "CenterBack", "3", 47, null },
                    { 1045, 28, null, "Félix", "Torres", "CenterBack", "2", 47, null },
                    { 1046, 33, null, "Robert", "Arboleda", "CenterBack", "4", 47, null },
                    { 1047, 27, null, "Pervis", "Estupiñán", "LeftBack", "7", 47, null },
                    { 1048, 27, null, "Ángelo", "Preciado", "RightBAck", "17", 47, null },
                    { 1049, 24, null, "Moisés", "Caicedo", "DefendCenterMidfilder", "8", 47, null },
                    { 1050, 30, null, "Carlos", "Gruezo", "CenterMidfilder", "14", 47, null },
                    { 1051, 26, null, "José", "Cifuentes", "CenterMidfilder", "16", 47, null },
                    { 1052, 27, null, "Alan", "Franco", "AttackingMidfilder", "15", 47, null },
                    { 1053, 23, null, "Jeremy", "Sarmiento", "LeftWinger", "11", 47, null },
                    { 1054, 25, null, "Gonzalo", "Plata", "RightWinger", "19", 47, null },
                    { 1055, 22, null, "Nilson", "Angulo", "LeftWinger", "20", 47, null },
                    { 1056, 36, null, "Enner", "Valencia", "CenterForward", "9", 47, null },
                    { 1057, 29, null, "Michael", "Estrada", "CenterForward", "18", 47, null },
                    { 1058, 24, null, "Kevin", "Rodríguez", "CenterForward", "21", 47, null },
                    { 1059, 37, null, "Carlos", "Gorosoito", "GoalKeeper", "1", 48, null },
                    { 1060, 31, null, "Juan", "Espínola", "GoalKeeper", "12", 48, null },
                    { 1061, 26, null, "Santiago", "Rojas", "GoalKeeper", "23", 48, null },
                    { 1062, 32, null, "Gustavo", "Gómez", "CenterBack", "4", 48, null },
                    { 1063, 34, null, "Fabián", "Balbuena", "CenterBack", "2", 48, null },
                    { 1064, 32, null, "Junior", "Alonso", "CenterBack", "3", 48, null },
                    { 1065, 30, null, "Iván", "Ramírez", "RightBAck", "13", 48, null },
                    { 1066, 27, null, "Júnior", "Rojas", "LeftBack", "6", 48, null },
                    { 1067, 28, null, "Andrés", "Cubas", "DefendCenterMidfilder", "14", 48, null },
                    { 1068, 28, null, "Mathías", "Villasanti", "CenterMidfilder", "8", 48, null },
                    { 1069, 34, null, "Richard", "Ortiz", "CenterMidfilder", "15", 48, null },
                    { 1070, 22, null, "Diego", "Gómez", "AttackingMidfilder", "16", 48, null },
                    { 1071, 31, null, "Miguel", "Almirón", "AttackingMidfilder", "10", 48, null },
                    { 1072, 25, null, "Ramón", "Sosa", "LeftWinger", "11", 48, null },
                    { 1073, 29, null, "Matías", "Rojas", "RightWinger", "17", 48, null },
                    { 1074, 29, null, "Antonio", "Sanabria", "CenterForward", "9", 48, null },
                    { 1075, 28, null, "Adam", "Bareiro", "CenterForward", "18", 48, null },
                    { 1076, 34, null, "Gabriel", "Ávalos", "CenterForward", "19", 48, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachName", "Country", "DeletedAt", "GroupNumber", "UpdatedAt" },
                values: new object[] { 49, "Darren Bazeley", "New Zealand", null, 7, null });
        }
    }
}
