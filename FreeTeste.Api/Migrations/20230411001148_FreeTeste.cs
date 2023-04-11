using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreeTeste.Api.Migrations
{
    /// <inheritdoc />
    public partial class FreeTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "fuchsia" },
                    { 2, "plum" },
                    { 3, "turquoise" },
                    { 4, "white" },
                    { 5, "red" },
                    { 6, "azure" },
                    { 7, "olive" },
                    { 8, "lavender" },
                    { 9, "grey" },
                    { 10, "white" },
                    { 11, "violet" },
                    { 12, "indigo" },
                    { 13, "indigo" },
                    { 14, "plum" },
                    { 15, "salmon" },
                    { 16, "plum" },
                    { 17, "violet" },
                    { 18, "magenta" },
                    { 19, "ivory" },
                    { 20, "orange" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Date", "Email", "FirstName", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 28, 1, 23, 44, 366, DateTimeKind.Local).AddTicks(6945), "Rafael8@hotmail.com", "Rafael", "Reichel", 9886.872036384272000m },
                    { 2, new DateTime(2022, 10, 27, 14, 17, 46, 338, DateTimeKind.Local).AddTicks(1855), "Jackie_Carroll41@yahoo.com", "Jackie", "Carroll", 5079.919581172272000m },
                    { 3, new DateTime(2022, 10, 3, 16, 30, 32, 222, DateTimeKind.Local).AddTicks(9090), "Abel41@yahoo.com", "Abel", "Kertzmann", 9323.274162279648000m },
                    { 4, new DateTime(2022, 8, 20, 6, 29, 52, 547, DateTimeKind.Local).AddTicks(7367), "Leroy_Green10@hotmail.com", "Leroy", "Green", 7158.165116534768000m },
                    { 5, new DateTime(2022, 12, 6, 17, 32, 12, 183, DateTimeKind.Local).AddTicks(2051), "Elena.Strosin@hotmail.com", "Elena", "Strosin", 8856.73051061944000m },
                    { 6, new DateTime(2023, 1, 25, 22, 47, 55, 871, DateTimeKind.Local).AddTicks(8913), "Dianne_Hamill@hotmail.com", "Dianne", "Hamill", 9290.7033985408000m },
                    { 7, new DateTime(2023, 4, 8, 12, 26, 45, 332, DateTimeKind.Local).AddTicks(9492), "Claudia41@gmail.com", "Claudia", "Zemlak", 5851.64898395536000m },
                    { 8, new DateTime(2023, 2, 21, 23, 41, 21, 296, DateTimeKind.Local).AddTicks(249), "Bradford47@gmail.com", "Bradford", "Okuneva", 2381.0427164521128000m },
                    { 9, new DateTime(2022, 4, 12, 7, 24, 2, 665, DateTimeKind.Local).AddTicks(6192), "Saul96@hotmail.com", "Saul", "Koelpin", 4728.231977749224000m },
                    { 10, new DateTime(2023, 3, 25, 3, 41, 31, 84, DateTimeKind.Local).AddTicks(1156), "Amos_OKon@gmail.com", "Amos", "O'Kon", 8710.526821846288000m },
                    { 11, new DateTime(2022, 11, 23, 14, 33, 28, 501, DateTimeKind.Local).AddTicks(2466), "Jermaine_Fritsch44@hotmail.com", "Jermaine", "Fritsch", 4461.847230532136000m },
                    { 12, new DateTime(2022, 9, 22, 2, 59, 32, 760, DateTimeKind.Local).AddTicks(6873), "Otis71@gmail.com", "Otis", "Kling", 9096.838467874024000m },
                    { 13, new DateTime(2022, 10, 18, 21, 24, 47, 570, DateTimeKind.Local).AddTicks(7515), "Lola44@gmail.com", "Lola", "Davis", 3706.689786099160000m },
                    { 14, new DateTime(2023, 3, 12, 0, 45, 54, 884, DateTimeKind.Local).AddTicks(3791), "Jeremy.Rau@yahoo.com", "Jeremy", "Rau", 3307.172019198384000m },
                    { 15, new DateTime(2023, 4, 2, 3, 40, 46, 97, DateTimeKind.Local).AddTicks(5908), "Kent.Stehr27@gmail.com", "Kent", "Stehr", 5829.644678317800000m },
                    { 16, new DateTime(2023, 1, 5, 7, 43, 43, 589, DateTimeKind.Local).AddTicks(5876), "Karl_Witting@yahoo.com", "Karl", "Witting", 5828.558742720048000m },
                    { 17, new DateTime(2023, 3, 4, 13, 3, 29, 655, DateTimeKind.Local).AddTicks(9930), "Rodolfo52@gmail.com", "Rodolfo", "Runte", 2269.2875657039584000m },
                    { 18, new DateTime(2022, 8, 7, 8, 48, 29, 214, DateTimeKind.Local).AddTicks(5752), "Johanna26@yahoo.com", "Johanna", "Goodwin", 4530.740130259744000m },
                    { 19, new DateTime(2023, 2, 5, 14, 45, 4, 919, DateTimeKind.Local).AddTicks(6885), "Jerome40@hotmail.com", "Jerome", "Tromp", 8064.41877138248000m },
                    { 20, new DateTime(2023, 3, 26, 17, 9, 45, 341, DateTimeKind.Local).AddTicks(5977), "Ernestine_Stracke@gmail.com", "Ernestine", "Stracke", 7444.665285665016000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
