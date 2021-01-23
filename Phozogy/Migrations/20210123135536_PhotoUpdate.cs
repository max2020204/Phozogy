using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class PhotoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 923, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(3533), "https://wallpapercave.com/wp/wp3412837.jpg" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                column: "Date",
                value: "23.01.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "MainPhoto" },
                values: new object[] { new DateTime(2021, 1, 23, 15, 55, 35, 925, DateTimeKind.Local).AddTicks(6127), "https://wallpapercave.com/wp/wp3412837.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 748, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 749, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 749, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 749, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 749, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 51, 4, 749, DateTimeKind.Local).AddTicks(9790), "https://sun9-1.userapi.com/impf/ZG2fSFlu3KL4oUz7rXpTqBaI7EPd3o1w0vBn7Q/Us73exmwiTA.jpg?size=537x240&quality=96&sign=d25a4256d00ce63594eed133ded9f0bb&type=share" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                column: "Date",
                value: "22.01.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "MainPhoto" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2458), "https://sun9-1.userapi.com/impf/ZG2fSFlu3KL4oUz7rXpTqBaI7EPd3o1w0vBn7Q/Us73exmwiTA.jpg?size=537x240&quality=96&sign=d25a4256d00ce63594eed133ded9f0bb&type=share" });
        }
    }
}
