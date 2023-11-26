using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees.API.Data.Migrations
{
    public partial class CompanySeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 26, 14, 29, 20, 523, DateTimeKind.Local).AddTicks(9365), "Microsoft company", "Microsoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 2, new DateTime(2023, 11, 26, 14, 29, 20, 523, DateTimeKind.Local).AddTicks(9375), "Apple company", "Apple" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreateDate", "Description", "Name" },
                values: new object[] { 3, new DateTime(2023, 11, 26, 14, 29, 20, 523, DateTimeKind.Local).AddTicks(9377), "Intel company", "Intel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
