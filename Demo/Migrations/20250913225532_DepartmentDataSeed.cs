using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Sales",
                table: "Departments",
                columns: new[] { "DeptId", "DateOfCreation", "DeptManagerId", "DepartmentName" },
                values: new object[,]
                {
                    { 20, new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HR" },
                    { 50, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Sales",
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 50);
        }
    }
}
