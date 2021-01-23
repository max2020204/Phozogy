using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class PostDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 224, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 28, 18, 226, DateTimeKind.Local).AddTicks(5961));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 46, 34, 975, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1801));
        }
    }
}
