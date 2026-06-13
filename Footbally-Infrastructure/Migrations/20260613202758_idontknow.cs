using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class idontknow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformance_Matchs_MatchId",
                table: "PlayerPerformance");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformance_Players_AssistPlayerId",
                table: "PlayerPerformance");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformance_Players_GoalPlayerId",
                table: "PlayerPerformance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerPerformance",
                table: "PlayerPerformance");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "PlayerPerformance",
                newName: "PlayerPerformances");

            migrationBuilder.RenameIndex(
                name: "IX_User_PhoneNumber",
                table: "Users",
                newName: "IX_Users_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_User_CreatedAt",
                table: "Users",
                newName: "IX_Users_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformance_MatchId",
                table: "PlayerPerformances",
                newName: "IX_PlayerPerformances_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformance_GoalPlayerId",
                table: "PlayerPerformances",
                newName: "IX_PlayerPerformances_GoalPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformance_CreatedAt",
                table: "PlayerPerformances",
                newName: "IX_PlayerPerformances_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformance_AssistPlayerId",
                table: "PlayerPerformances",
                newName: "IX_PlayerPerformances_AssistPlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerPerformances",
                table: "PlayerPerformances",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformances_Matchs_MatchId",
                table: "PlayerPerformances",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformances_Players_AssistPlayerId",
                table: "PlayerPerformances",
                column: "AssistPlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformances_Players_GoalPlayerId",
                table: "PlayerPerformances",
                column: "GoalPlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformances_Matchs_MatchId",
                table: "PlayerPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformances_Players_AssistPlayerId",
                table: "PlayerPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformances_Players_GoalPlayerId",
                table: "PlayerPerformances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerPerformances",
                table: "PlayerPerformances");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "PlayerPerformances",
                newName: "PlayerPerformance");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PhoneNumber",
                table: "User",
                newName: "IX_User_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatedAt",
                table: "User",
                newName: "IX_User_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformances_MatchId",
                table: "PlayerPerformance",
                newName: "IX_PlayerPerformance_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformances_GoalPlayerId",
                table: "PlayerPerformance",
                newName: "IX_PlayerPerformance_GoalPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformances_CreatedAt",
                table: "PlayerPerformance",
                newName: "IX_PlayerPerformance_CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerPerformances_AssistPlayerId",
                table: "PlayerPerformance",
                newName: "IX_PlayerPerformance_AssistPlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerPerformance",
                table: "PlayerPerformance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformance_Matchs_MatchId",
                table: "PlayerPerformance",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformance_Players_AssistPlayerId",
                table: "PlayerPerformance",
                column: "AssistPlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformance_Players_GoalPlayerId",
                table: "PlayerPerformance",
                column: "GoalPlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
