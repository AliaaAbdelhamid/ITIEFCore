using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDeleteBehaviorOfWorkRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesTable_Departments_DepartmentId",
                table: "EmployeesTable");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesTable_Departments_DepartmentId",
                table: "EmployeesTable",
                column: "DepartmentId",
                principalSchema: "Sales",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesTable_Departments_DepartmentId",
                table: "EmployeesTable");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesTable_Departments_DepartmentId",
                table: "EmployeesTable",
                column: "DepartmentId",
                principalSchema: "Sales",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
