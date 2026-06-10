using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hgf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachName", "Country", "DeletedAt", "GroupNumber", "UpdatedAt" },
                values: new object[] { 44, "Darren Bazeley", "New Zealand", null, 7, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CoachName", "Country", "DeletedAt", "GroupNumber", "UpdatedAt" },
                values: new object[] { 44, "Darren Bazeley", "New Zealand", null, 7, null });
        }
    }
}
