using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPSHolidayTrackerSystem.Api.Migrations
{
    public partial class EmployessBirthDateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "JoinedDate" },
                values: new object[] { new DateTime(1989, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 4, 15, 40, 56, 42, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "JoinedDate" },
                values: new object[] { new DateTime(1967, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "JoinedDate" },
                values: new object[] { new DateTime(1995, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1261) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 11, 19, 820, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 11, 19, 823, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 11, 19, 823, DateTimeKind.Local).AddTicks(8359));
        }
    }
}
