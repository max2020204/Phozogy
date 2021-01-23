using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class ChangedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 51, 4, 750, DateTimeKind.Local).AddTicks(2458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 350, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8491), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJWGg8cLB4DoXsna_gdu6oXil-StdGBznrkw&usqp=CAU" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1072));
        }
    }
}
