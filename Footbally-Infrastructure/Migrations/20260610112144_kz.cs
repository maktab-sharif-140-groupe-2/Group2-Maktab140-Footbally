using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 701, 33, null, "Mohammed", "Al-Owais", "GoalKeeper", "21", 29, null },
                    { 702, 24, null, "Nawaf", "Al-Aqidi", "GoalKeeper", "1", 29, null },
                    { 703, 28, null, "Raghed", "Al-Najjar", "GoalKeeper", "22", 29, null },
                    { 704, 30, null, "Sultan", "Al-Ghannam", "RightBAck", "2", 29, null },
                    { 705, 33, null, "Yasser", "Al-Shahrani", "LeftBack", "13", 29, null },
                    { 706, 27, null, "Abdulelah", "Al-Amri", "CenterBack", "4", 29, null },
                    { 707, 26, null, "Hassan", "Tambakti", "CenterBack", "5", 29, null },
                    { 708, 35, null, "Ali", "Al-Bulaihi", "CenterBack", "17", 29, null },
                    { 709, 31, null, "Mohammed", "Al-Breik", "RightBAck", "6", 29, null },
                    { 710, 35, null, "Salman", "Al-Faraj", "CenterMidfilder", "7", 29, null },
                    { 711, 31, null, "Abdullah", "Otayf", "DefendCenterMidfilder", "14", 29, null },
                    { 712, 31, null, "Mohamed", "Kanno", "CenterMidfilder", "8", 29, null },
                    { 713, 26, null, "Nasser", "Al-Dawsari", "LeftWinger", "16", 29, null },
                    { 714, 30, null, "Fahad", "Al-Muwallad", "RightWinger", "9", 29, null },
                    { 715, 28, null, "Sami", "Al-Najei", "AttackingMidfilder", "15", 29, null },
                    { 716, 29, null, "Abdulrahman", "Al-Aboud", "LeftWinger", "19", 29, null },
                    { 717, 31, null, "Saleh", "Al-Shehri", "CenterForward", "11", 29, null },
                    { 718, 25, null, "Firas", "Al-Buraikan", "CenterForward", "10", 29, null },
                    { 719, 28, null, "Abdulaziz", "Al-Bishi", "RightWinger", "20", 29, null },
                    { 720, 27, null, "Hussain", "Al-Qahtani", "LeftWinger", "23", 29, null },
                    { 721, 34, null, "Saad", "Al-Sheeb", "GoalKeeper", "1", 30, null },
                    { 722, 26, null, "Meshaal", "Barsham", "GoalKeeper", "22", 30, null },
                    { 723, 28, null, "Yousef", "Hassan", "GoalKeeper", "21", 30, null },
                    { 724, 33, null, "Pedro", "Miguel", "CenterBack", "2", 30, null },
                    { 725, 35, null, "Boualem", "Khoukhi", "CenterBack", "3", 30, null },
                    { 726, 27, null, "Bassam", "Al-Rawi", "CenterBack", "5", 30, null },
                    { 727, 28, null, "Tarek", "Salman", "DefendCenterMidfilder", "6", 30, null },
                    { 728, 31, null, "Abdelkarim", "Hassan", "LeftBack", "13", 30, null },
                    { 729, 30, null, "Hamid", "Ismaeil", "RightBAck", "15", 30, null },
                    { 730, 34, null, "Hassan", "Al-Haydos", "AttackingMidfilder", "10", 30, null },
                    { 731, 33, null, "Abdulaziz", "Hatem", "CenterMidfilder", "8", 30, null },
                    { 732, 33, null, "Karim", "Boudiaf", "DefendCenterMidfilder", "12", 30, null },
                    { 733, 28, null, "Assim", "Madibo", "CenterMidfilder", "11", 30, null },
                    { 734, 31, null, "Ahmed", "Fathy", "RightWinger", "16", 30, null },
                    { 735, 26, null, "Mohammed", "Waad", "LeftWinger", "14", 30, null },
                    { 736, 25, null, "Yusuf", "Abdurisag", "RightWinger", "17", 30, null },
                    { 737, 28, null, "Almoez", "Ali", "CenterForward", "9", 30, null },
                    { 738, 28, null, "Akram", "Afif", "LeftWinger", "7", 30, null },
                    { 739, 30, null, "Mohammed", "Muntari", "CenterForward", "20", 30, null },
                    { 740, 29, null, "Ahmed", "Alaaeldin", "RightWinger", "23", 30, null },
                    { 741, 33, null, "Utkir", "Yusupov", "GoalKeeper", "1", 31, null },
                    { 742, 24, null, "Abduvohid", "Nematov", "GoalKeeper", "12", 31, null },
                    { 743, 27, null, "Rustam", "Yatimov", "GoalKeeper", "23", 31, null },
                    { 744, 29, null, "Eldor", "Shomurodov", "CenterForward", "9", 31, null },
                    { 745, 20, null, "Abdukodir", "Khusanov", "CenterBack", "4", 31, null },
                    { 746, 28, null, "Rustamjon", "Ashurmatov", "CenterBack", "5", 31, null },
                    { 747, 27, null, "Oybek", "Bozorov", "RightBAck", "6", 31, null },
                    { 748, 29, null, "Dostonbek", "Tursunov", "LeftBack", "3", 31, null },
                    { 749, 23, null, "Khojimat", "Erkinov", "RightWinger", "2", 31, null },
                    { 750, 28, null, "Odiljon", "Xamrobekov", "CenterMidfilder", "8", 31, null },
                    { 751, 26, null, "Ibrokhim", "Halilov", "AttackingMidfilder", "10", 31, null },
                    { 752, 30, null, "Jaloliddin", "Masharipov", "LeftWinger", "7", 31, null },
                    { 753, 29, null, "Otabek", "Shukurov", "DefendCenterMidfilder", "11", 31, null },
                    { 754, 27, null, "Sardor", "Rakhmonov", "CenterMidfilder", "14", 31, null },
                    { 755, 28, null, "Bobur", "Abdukholikov", "CenterMidfilder", "15", 31, null },
                    { 756, 25, null, "Khoja", "Matyokubov", "RightWinger", "16", 31, null },
                    { 757, 29, null, "Eldor", "Shomurodov", "CenterForward", "9", 31, null },
                    { 758, 31, null, "Igor", "Sergeev", "CenterForward", "18", 31, null },
                    { 759, 27, null, "Javokhir", "Siddikov", "LeftWinger", "19", 31, null },
                    { 760, 28, null, "Azizbek", "Turgunboev", "RightWinger", "20", 31, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 760);
        }
    }
}
