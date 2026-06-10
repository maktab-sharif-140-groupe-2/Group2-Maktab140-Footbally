using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Footbally_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kvc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "DeletedAt", "FirstName", "LastName", "Position", "ShirtNumber", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 761, 32, null, "Yazeed", "Abulaila", "GoalKeeper", "1", 32, null },
                    { 762, 29, null, "Malek", "Shaboul", "GoalKeeper", "12", 32, null },
                    { 763, 27, null, "Rami", "Hamadeh", "GoalKeeper", "23", 32, null },
                    { 764, 30, null, "Ahmad", "Erdem", "RightBAck", "2", 32, null },
                    { 765, 28, null, "Yazan", "Al-Arab", "CenterBack", "3", 32, null },
                    { 766, 30, null, "Abdallah", "Nasib", "CenterBack", "4", 32, null },
                    { 767, 27, null, "Mohannad", "Abu Taha", "LeftBack", "5", 32, null },
                    { 768, 31, null, "Salem", "Al-Ajalin", "RightBAck", "6", 32, null },
                    { 769, 29, null, "Shadi", "Abu Hashish", "CenterBack", "13", 32, null },
                    { 770, 32, null, "Baha", "Seif", "AttackingMidfilder", "7", 32, null },
                    { 771, 28, null, "Nizar", "Al-Rashdan", "DefendCenterMidfilder", "8", 32, null },
                    { 772, 30, null, "Ehsan", "Haddad", "CenterMidfilder", "14", 32, null },
                    { 773, 29, null, "Yousef", "Rawshdeh", "AttackingMidfilder", "10", 32, null },
                    { 774, 28, null, "Abdulrahman", "Al-Mardi", "LeftWinger", "11", 32, null },
                    { 775, 27, null, "Musa", "Al-Taamari", "RightWinger", "9", 32, null },
                    { 776, 26, null, "Ali", "Olwan", "CenterForward", "15", 32, null },
                    { 777, 25, null, "Yazan", "Al-Naimat", "CenterForward", "16", 32, null },
                    { 778, 26, null, "Omar", "Hani", "LeftWinger", "17", 32, null },
                    { 779, 27, null, "Ibrahim", "Sadeh", "RightWinger", "18", 32, null },
                    { 780, 28, null, "Mohammad", "Abu Zraiq", "CenterForward", "20", 32, null },
                    { 781, 33, null, "Jalal", "Hassan", "GoalKeeper", "1", 33, null },
                    { 782, 28, null, "Faris", "Nadhim", "GoalKeeper", "12", 33, null },
                    { 783, 31, null, "Mohammed", "Hameed", "GoalKeeper", "23", 33, null },
                    { 784, 31, null, "Ali", "Adnan", "LeftBack", "3", 33, null },
                    { 785, 32, null, "Rebin", "Sulaqa", "CenterBack", "4", 33, null },
                    { 786, 30, null, "Ahmed", "Ibrahim", "CenterBack", "5", 33, null },
                    { 787, 27, null, "Zaid", "Tahseen", "RightBAck", "6", 33, null },
                    { 788, 31, null, "Frans", "Dhia Putros", "CenterBack", "13", 33, null },
                    { 789, 28, null, "Ali", "Faez", "RightBAck", "2", 33, null },
                    { 790, 29, null, "Aymen", "Hussein", "AttackingMidfilder", "10", 33, null },
                    { 791, 26, null, "Mohannad", "Ali", "CenterForward", "9", 33, null },
                    { 792, 28, null, "Amir", "Al-Ammari", "CenterMidfilder", "8", 33, null },
                    { 793, 31, null, "Osama", "Rasheed", "CenterMidfilder", "14", 33, null },
                    { 794, 30, null, "Mahmoud", "Al-Mawas", "LeftWinger", "11", 33, null },
                    { 795, 33, null, "Justin", "Meram", "RightWinger", "7", 33, null },
                    { 796, 22, null, "Zidane", "Iqbal", "CenterMidfilder", "15", 33, null },
                    { 797, 22, null, "Youssef", "Amyn", "LeftWinger", "16", 33, null },
                    { 798, 28, null, "Bashar", "Resan", "AttackingMidfilder", "17", 33, null },
                    { 799, 26, null, "Mohammed", "Qasim", "RightWinger", "18", 33, null },
                    { 800, 23, null, "Ali", "Al-Hamadi", "CenterForward", "19", 33, null },
                    { 801, 34, null, "Yassine", "Bounou", "GoalKeeper", "1", 34, null },
                    { 802, 36, null, "Munir", "El Kajoui", "GoalKeeper", "12", 34, null },
                    { 803, 35, null, "Anas", "Zniti", "GoalKeeper", "23", 34, null },
                    { 804, 27, null, "Achraf", "Hakimi", "RightBAck", "2", 34, null },
                    { 805, 27, null, "Noussair", "Mazraoui", "RightBAck", "3", 34, null },
                    { 806, 35, null, "Romain", "Saïss", "CenterBack", "4", 34, null },
                    { 807, 29, null, "Nayef", "Aguerd", "CenterBack", "5", 34, null },
                    { 808, 32, null, "Jawad", "El Yamiq", "CenterBack", "6", 34, null },
                    { 809, 31, null, "Adam", "Masina", "LeftBack", "13", 34, null },
                    { 810, 29, null, "Sofyan", "Amrabat", "DefendCenterMidfilder", "8", 34, null },
                    { 811, 25, null, "Azzedine", "Ounahi", "CenterMidfilder", "10", 34, null },
                    { 812, 21, null, "Bilal", "El Khannouss", "AttackingMidfilder", "11", 34, null },
                    { 813, 28, null, "Selim", "Amallah", "CenterMidfilder", "14", 34, null },
                    { 814, 27, null, "Amine", "Harit", "LeftWinger", "7", 34, null },
                    { 815, 25, null, "Zakaria", "Aboukhlal", "RightWinger", "15", 34, null },
                    { 816, 23, null, "Abde", "Ezzalzouli", "LeftWinger", "16", 34, null },
                    { 817, 28, null, "Youssef", "En-Nesyri", "CenterForward", "9", 34, null },
                    { 818, 30, null, "Sofiane", "Boufal", "RightWinger", "17", 34, null },
                    { 819, 27, null, "Walid", "Cheddira", "CenterForward", "18", 34, null },
                    { 820, 21, null, "Ilias", "Akhomach", "LeftWinger", "20", 34, null },
                    { 821, 33, null, "Edouard", "Mendy", "GoalKeeper", "1", 35, null },
                    { 822, 30, null, "Alfred", "Gomis", "GoalKeeper", "16", 35, null },
                    { 823, 29, null, "Seny", "Dieng", "GoalKeeper", "23", 35, null },
                    { 824, 34, null, "Kalidou", "Koulibaly", "CenterBack", "3", 35, null },
                    { 825, 29, null, "Abdou", "Diallo", "CenterBack", "4", 35, null },
                    { 826, 23, null, "Moussa", "Ndiaye", "LeftBack", "5", 35, null },
                    { 827, 31, null, "Youssouf", "Sabaly", "RightBAck", "2", 35, null },
                    { 828, 30, null, "Pape", "Abou Cisse", "CenterBack", "6", 35, null },
                    { 829, 24, null, "Formose", "Mendy", "CenterBack", "13", 35, null },
                    { 830, 35, null, "Idrissa", "Gueye", "DefendCenterMidfilder", "8", 35, null },
                    { 831, 32, null, "Nampalys", "Mendy", "CenterMidfilder", "14", 35, null },
                    { 832, 26, null, "Pape", "Gueye", "CenterMidfilder", "17", 35, null },
                    { 833, 26, null, "Krepin", "Diatta", "RightWinger", "11", 35, null },
                    { 834, 27, null, "Ismaila", "Sarr", "LeftWinger", "10", 35, null },
                    { 835, 29, null, "Habib", "Diallo", "CenterForward", "15", 35, null },
                    { 836, 22, null, "Pape Matar", "Sarr", "AttackingMidfilder", "7", 35, null },
                    { 837, 33, null, "Sadio", "Mane", "LeftWinger", "9", 35, null },
                    { 838, 28, null, "Boulaye", "Dia", "CenterForward", "18", 35, null },
                    { 839, 25, null, "Iliman", "Ndiaye", "RightWinger", "19", 35, null },
                    { 840, 27, null, "Cheikh", "Sabaly", "LeftWinger", "20", 35, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 840);
        }
    }
}
