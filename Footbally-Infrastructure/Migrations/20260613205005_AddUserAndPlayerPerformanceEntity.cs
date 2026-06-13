using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndPlayerPerformanceEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assist",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "Players");

            migrationBuilder.CreateTable(
                name: "PlayerPerformance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    GoalPlayerId = table.Column<int>(type: "int", nullable: false),
                    AssistPlayerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPerformance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerPerformance_Matchs_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayerPerformance_Players_AssistPlayerId",
                        column: x => x.AssistPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayerPerformance_Players_GoalPlayerId",
                        column: x => x.GoalPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPerformance_AssistPlayerId",
                table: "PlayerPerformance",
                column: "AssistPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPerformance_CreatedAt",
                table: "PlayerPerformance",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPerformance_GoalPlayerId",
                table: "PlayerPerformance",
                column: "GoalPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPerformance_MatchId",
                table: "PlayerPerformance",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedAt",
                table: "User",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerPerformance");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddColumn<int>(
                name: "Assist",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Goals",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 135,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 136,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 137,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 138,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 139,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 140,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 141,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 142,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 143,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 144,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 145,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 146,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 147,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 148,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 149,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 150,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 151,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 152,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 153,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 154,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 155,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 156,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 157,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 158,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 159,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 160,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 161,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 162,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 163,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 164,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 165,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 166,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 167,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 168,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 169,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 170,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 171,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 172,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 173,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 174,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 175,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 176,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 177,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 178,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 179,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 180,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 181,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 182,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 183,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 184,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 185,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 186,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 187,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 188,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 189,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 190,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 191,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 192,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 193,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 194,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 195,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 196,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 197,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 198,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 199,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 200,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 201,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 202,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 203,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 204,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 205,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 206,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 207,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 208,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 209,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 210,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 211,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 212,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 213,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 214,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 215,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 216,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 217,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 218,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 219,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 220,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 221,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 222,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 223,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 224,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 225,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 226,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 227,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 228,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 229,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 230,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 231,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 232,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 233,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 234,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 235,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 236,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 237,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 238,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 239,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 240,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 241,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 242,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 243,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 244,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 245,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 246,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 247,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 248,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 249,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 250,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 251,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 252,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 253,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 254,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 255,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 256,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 257,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 258,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 259,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 260,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 261,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 262,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 263,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 264,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 265,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 266,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 267,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 268,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 269,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 270,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 271,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 272,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 273,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 274,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 275,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 276,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 277,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 278,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 279,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 280,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 281,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 282,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 283,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 284,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 285,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 286,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 287,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 288,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 289,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 290,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 291,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 292,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 293,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 294,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 295,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 296,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 297,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 298,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 299,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 300,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 301,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 302,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 303,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 304,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 305,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 306,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 307,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 308,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 309,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 310,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 311,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 312,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 313,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 314,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 315,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 316,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 317,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 318,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 319,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 320,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 321,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 322,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 323,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 324,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 325,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 326,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 327,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 328,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 329,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 330,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 331,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 332,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 333,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 334,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 335,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 336,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 337,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 338,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 339,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 340,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 341,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 342,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 343,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 344,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 345,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 346,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 347,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 348,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 349,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 350,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 351,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 352,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 353,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 354,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 355,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 356,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 357,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 358,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 359,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 360,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 361,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 362,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 363,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 364,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 365,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 366,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 367,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 368,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 369,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 370,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 371,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 372,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 373,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 374,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 375,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 376,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 377,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 378,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 379,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 380,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 381,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 382,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 383,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 384,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 385,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 386,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 387,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 388,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 389,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 390,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 391,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 392,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 393,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 394,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 395,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 396,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 397,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 398,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 399,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 400,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 401,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 402,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 403,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 404,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 405,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 406,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 407,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 408,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 409,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 410,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 412,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 413,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 414,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 415,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 416,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 417,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 418,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 419,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 420,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 421,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 422,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 423,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 424,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 425,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 426,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 427,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 428,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 429,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 430,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 431,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 432,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 433,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 434,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 435,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 436,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 437,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 438,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 439,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 440,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 441,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 442,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 443,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 444,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 445,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 446,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 447,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 448,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 449,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 450,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 451,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 452,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 453,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 454,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 455,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 456,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 457,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 458,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 459,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 460,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 461,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 462,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 463,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 464,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 465,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 466,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 467,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 468,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 469,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 470,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 471,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 472,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 473,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 474,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 475,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 476,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 477,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 478,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 479,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 480,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 481,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 482,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 483,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 484,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 485,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 486,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 487,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 488,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 489,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 490,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 491,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 492,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 493,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 494,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 495,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 496,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 497,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 498,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 499,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 500,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 501,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 502,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 503,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 504,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 505,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 506,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 507,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 508,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 509,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 510,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 511,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 512,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 513,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 514,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 515,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 516,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 517,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 518,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 519,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 520,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 521,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 522,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 523,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 524,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 525,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 526,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 527,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 528,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 529,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 530,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 531,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 532,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 533,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 534,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 535,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 536,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 537,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 538,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 539,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 540,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 541,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 542,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 543,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 544,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 545,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 546,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 547,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 548,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 549,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 550,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 551,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 552,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 553,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 554,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 555,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 556,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 557,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 558,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 559,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 560,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 561,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 562,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 563,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 564,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 565,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 566,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 567,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 568,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 569,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 570,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 571,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 572,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 573,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 574,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 575,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 576,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 577,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 578,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 579,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 580,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 581,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 582,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 583,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 584,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 585,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 586,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 587,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 588,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 589,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 590,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 591,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 592,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 593,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 594,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 595,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 596,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 597,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 598,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 599,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 600,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 601,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 602,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 603,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 604,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 605,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 606,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 607,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 608,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 609,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 610,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 611,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 612,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 613,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 614,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 615,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 616,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 617,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 618,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 619,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 620,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 621,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 622,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 623,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 624,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 625,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 626,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 627,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 628,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 629,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 630,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 631,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 632,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 633,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 634,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 635,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 636,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 637,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 638,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 639,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 640,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 641,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 642,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 643,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 644,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 645,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 646,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 647,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 648,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 649,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 650,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 651,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 652,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 653,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 654,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 655,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 656,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 657,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 658,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 659,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 660,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 661,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 662,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 663,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 664,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 665,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 666,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 667,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 668,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 669,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 670,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 671,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 672,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 673,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 674,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 675,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 676,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 677,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 678,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 679,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 680,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 681,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 682,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 683,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 684,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 685,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 686,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 687,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 688,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 689,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 690,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 691,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 692,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 693,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 694,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 695,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 696,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 697,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 698,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 699,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 700,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 701,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 702,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 703,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 704,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 705,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 706,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 707,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 708,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 709,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 710,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 711,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 712,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 713,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 714,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 715,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 716,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 717,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 718,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 719,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 720,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 721,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 722,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 723,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 724,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 725,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 726,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 727,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 728,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 729,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 730,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 731,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 732,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 733,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 734,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 735,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 736,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 737,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 738,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 739,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 740,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 741,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 742,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 743,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 744,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 745,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 746,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 747,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 748,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 749,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 750,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 751,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 752,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 753,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 754,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 755,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 756,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 757,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 758,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 759,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 760,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 761,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 762,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 763,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 764,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 765,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 766,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 767,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 768,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 769,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 770,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 771,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 772,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 773,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 774,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 775,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 776,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 777,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 778,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 779,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 780,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 781,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 782,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 783,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 784,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 785,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 786,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 787,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 788,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 789,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 790,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 791,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 792,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 793,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 794,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 795,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 796,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 797,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 798,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 799,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 800,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 801,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 802,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 803,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 804,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 805,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 806,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 807,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 808,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 809,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 810,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 811,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 812,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 813,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 814,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 815,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 816,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 817,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 818,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 819,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 820,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 821,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 822,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 823,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 824,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 825,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 826,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 827,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 828,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 829,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 830,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 831,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 832,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 833,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 834,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 835,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 836,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 837,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 838,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 839,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 840,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 841,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 842,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 843,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 844,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 845,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 846,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 847,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 848,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 849,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 850,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 851,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 852,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 853,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 854,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 855,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 856,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 857,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 858,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 859,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 860,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 861,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 862,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 863,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 864,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 865,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 866,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 867,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 868,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 869,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 870,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 871,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 872,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 873,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 874,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 875,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 876,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 877,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 878,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 879,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 881,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 882,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 883,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 884,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 885,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 886,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 887,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 888,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 889,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 890,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 891,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 892,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 893,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 894,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 895,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 896,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 897,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 898,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 899,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 900,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 901,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 902,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 903,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 904,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 905,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 906,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 907,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 908,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 909,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 910,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 911,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 912,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 913,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 914,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 915,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 916,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 917,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 918,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 919,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 920,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 921,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 922,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 923,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 924,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 925,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 926,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 927,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 928,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 929,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 930,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 931,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 932,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 933,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 934,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 935,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 936,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 937,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 938,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 939,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 940,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 941,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 942,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 943,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 944,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 945,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 946,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 947,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 948,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 949,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 950,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 951,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 952,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 953,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 954,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 955,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 956,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 957,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 958,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 959,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 960,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 961,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 962,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 963,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 964,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 965,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 966,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 967,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 968,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 969,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 970,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 971,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 972,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 973,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 974,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 975,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 976,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 977,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 978,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 979,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 980,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 981,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 982,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 983,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 984,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 985,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 986,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 987,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 988,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 989,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 990,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 991,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 992,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 993,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 994,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 995,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 996,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 997,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 998,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 999,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new string[0],
                values: new object[0]);
        }
    }
}
