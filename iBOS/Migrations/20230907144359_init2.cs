using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iBOS.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSalary = table.Column<double>(type: "float", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployeeAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    IsOffday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployeeAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployeeAttendance_tblEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "tblEmployee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblEmployee",
                columns: new[] { "EmployeeId", "EmployeeCode", "EmployeeName", "EmployeeSalary", "SupervisorId" },
                values: new object[,]
                {
                    { 502030, "EMP320", "Mehedi Hasan", 50000.0, 502036 },
                    { 502031, "EMP321", "Ashikur Rahman", 45000.0, 502036 },
                    { 502032, "EMP322", "Rakibul Islam", 52000.0, 502030 },
                    { 502033, "EMP323", "Hasan Abdullah", 46000.0, 502031 },
                    { 502034, "EMP324", "Akib Khan", 66000.0, 502032 },
                    { 502035, "EMP325", "Rasel Shikder", 53500.0, 502033 },
                    { 502036, "EMP326", "Selim Reja", 59000.0, 502035 }
                });

            migrationBuilder.InsertData(
                table: "tblEmployeeAttendance",
                columns: new[] { "Id", "AttendanceDate", "EmployeeId", "IsOffday", "IsPresent" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 502030, false, true },
                    { 2, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 502030, true, false },
                    { 3, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 502031, false, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeAttendance_EmployeeId",
                table: "tblEmployeeAttendance",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployeeAttendance");

            migrationBuilder.DropTable(
                name: "tblEmployee");
        }
    }
}
