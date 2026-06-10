using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CoachName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    GroupNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeGoals = table.Column<int>(type: "int", nullable: false),
                    AwayGoals = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matchs_Teams_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Matchs_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShirtNumber = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false, defaultValue: 14),
                    Goals = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Assist = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Standings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Played = table.Column<int>(type: "int", nullable: false),
                    Won = table.Column<int>(type: "int", nullable: false),
                    Lost = table.Column<int>(type: "int", nullable: false),
                    Draw = table.Column<int>(type: "int", nullable: false),
                    GoalsFor = table.Column<int>(type: "int", nullable: false),
                    GoalsAgainst = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Standings_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachName", "Country", "DeletedAt", "GroupNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Lionel Scaloni", "Argentina", null, 10, null },
                    { 2, "Carlo Ancelotti", "Brazil", null, 3, null },
                    { 3, "Thomas Tuchel", "England", null, 12, null },
                    { 4, "Didier Deschamps", "France", null, 9, null },
                    { 5, "Julian Nagelsmann", "Germany", null, 5, null },
                    { 6, "Luis de la Fuente", "Spain", null, 8, null },
                    { 7, "Roberto Martinez", "Portugal", null, 11, null },
                    { 8, "Rudi Garcia", "Belgium", null, 7, null },
                    { 9, "Ronald Koeman", "Netherlands", null, 6, null },
                    { 10, "Zlatko Dalic", "Croatia", null, 12, null },
                    { 11, "Murat Yakin", "Switzerland", null, 2, null },
                    { 12, "Ralf Rangnick", "Austria", null, 10, null },
                    { 13, "Graham Potter", "Sweden", null, 6, null },
                    { 14, "Stale Solbakken", "Norway", null, 9, null },
                    { 15, "Steve Clarke", "Scotland", null, 3, null },
                    { 16, "Sergej Barbarez", "Bosnia and Herzegovina", null, 2, null },
                    { 17, "Miroslav Koubek", "Czechia", null, 1, null },
                    { 18, "Vincenzo Montella", "Turkey", null, 4, null },
                    { 19, "Javier Aguirre", "Mexico", null, 1, null },
                    { 20, "Jesse Marsch", "Canada", null, 2, null },
                    { 21, "Mauricio Pochettino", "USA", null, 4, null },
                    { 22, "Thomas Christiansen", "Panama", null, 12, null },
                    { 23, "Dick Advocaat", "Curacao", null, 5, null },
                    { 24, "Sebastien Migne", "Haiti", null, 3, null },
                    { 25, "Hajime Moriyasu", "Japan", null, 6, null },
                    { 26, "Hong Myung-bo", "South Korea", null, 1, null },
                    { 27, "Amir Ghalenoei", "Iran", null, 7, null },
                    { 28, "Tony Popovic", "Australia", null, 4, null },
                    { 29, "Georgios Donis", "Saudi Arabia", null, 8, null },
                    { 30, "Julen Lopetegui", "Qatar", null, 2, null },
                    { 31, "Fabio Cannavaro", "Uzbekistan", null, 11, null },
                    { 32, "Jamal Sellami", "Jordan", null, 10, null },
                    { 33, "Graham Arnold", "Iraq", null, 9, null },
                    { 34, "Mohamed Ouahbi", "Morocco", null, 3, null },
                    { 35, "Pape Thiaw", "Senegal", null, 9, null },
                    { 36, "Hossam Hassan", "Egypt", null, 7, null },
                    { 37, "Vladimir Petkovic", "Algeria", null, 10, null },
                    { 38, "Hugo Broos", "South Africa", null, 1, null },
                    { 39, "Carlos Queiroz", "Ghana", null, 12, null },
                    { 40, "Sabri Lamouchi", "Tunisia", null, 6, null },
                    { 41, "Emerse Fae", "Ivory Coast", null, 5, null },
                    { 42, "Sebastien Desabre", "DR Congo", null, 11, null },
                    { 43, "Bubista", "Cape Verde", null, 8, null },
                    { 44, "Lionel Scaloni", "Argentina", null, 10, null },
                    { 45, "Marcelo Bielsa", "Uruguay", null, 8, null },
                    { 46, "Nestor Lorenzo", "Colombia", null, 11, null },
                    { 47, "Sebastian Beccacece", "Ecuador", null, 5, null },
                    { 48, "Gustavo Alfaro", "Paraguay", null, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_AwayTeamId",
                table: "Matchs",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_CreatedAt",
                table: "Matchs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Matchs_HomeTeamId",
                table: "Matchs",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CreatedAt",
                table: "Players",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_CreatedAt",
                table: "Standings",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_TeamId",
                table: "Standings",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CreatedAt",
                table: "Teams",
                column: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matchs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Standings");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
