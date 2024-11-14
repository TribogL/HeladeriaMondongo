using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeladeriaMondongo.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersWithAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "is_admin", "last_name", "name", "password" },
                values: new object[,]
                {
                    { 1, "Elfrieda_Wiza75@gmail.com", false, "Cummerata", "Dangelo", "heeeoaea" },
                    { 2, "Meagan.Jones@gmail.com", false, "Lang", "Burdette", "neuiiiee" },
                    { 3, "Keegan.Walker17@hotmail.com", false, "Leuschke", "Michael", "bueeaoie" },
                    { 4, "Alberta.Franecki@yahoo.com", false, "Senger", "Justen", "suueeieo" },
                    { 5, "Theron47@gmail.com", false, "Kohler", "Ulises", "haaooaoi" },
                    { 6, "Benny.Becker@yahoo.com", false, "Stokes", "Dawn", "wuoueeia" },
                    { 7, "Zaria.Runolfsdottir27@yahoo.com", false, "Hamill", "Monte", "jioauaia" },
                    { 8, "Brayan11@gmail.com", false, "Murphy", "Rosamond", "soiooaeu" },
                    { 9, "Stuart35@yahoo.com", false, "Romaguera", "Melba", "xooioaee" },
                    { 10, "Ocie.Rath@gmail.com", false, "Schaefer", "Hallie", "teaauoai" },
                    { 100, "admin@example.com", true, "User", "Admin", "AdminPassword123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 100);
        }
    }
}
