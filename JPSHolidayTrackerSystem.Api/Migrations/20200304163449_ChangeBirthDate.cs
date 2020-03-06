using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPSHolidayTrackerSystem.Api.Migrations
{
    public partial class ChangeBirthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 16, 34, 49, 492, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 16, 34, 49, 496, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 16, 34, 49, 496, DateTimeKind.Local).AddTicks(4658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 40, 56, 42, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "JoinedDate",
                value: new DateTime(2020, 3, 4, 15, 40, 56, 46, DateTimeKind.Local).AddTicks(1261));
        }
    }
}
