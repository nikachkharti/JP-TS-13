using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees.API.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 26, 15, 4, 58, 511, DateTimeKind.Local).AddTicks(3543), "Microsoft company", "Microsoft" },
                    { 2, new DateTime(2023, 11, 26, 15, 4, 58, 511, DateTimeKind.Local).AddTicks(3552), "Apple company", "Apple" },
                    { 3, new DateTime(2023, 11, 26, 15, 4, 58, 511, DateTimeKind.Local).AddTicks(3553), "Intel company", "Intel" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Irakli", "Rogava" },
                    { 2, "Giorgi", "Omanadze" },
                    { 3, "Giorgi", "Jibladze" },
                    { 4, "Lizi", "Nemsiwverdize" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
