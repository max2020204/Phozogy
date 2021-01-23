using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class BlogImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 21, 20, 46, 34, 975, DateTimeKind.Local).AddTicks(5244), "https://images.stopgame.ru/uploads/users/2021/161162/00056.nQb9mjm.jpg" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1771), "https://media.contentapi.ea.com/content/dam/apex-legends/images/2019/01/apex-featured-image-16x9.jpg.adapt.crop191x100.1200w.jpg" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1797), "https://www.residentevil.com/village/assets/images/common/share.png" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Date", "Image" },
                values: new object[] { new DateTime(2021, 1, 21, 20, 46, 34, 977, DateTimeKind.Local).AddTicks(1801), "https://sun9-16.userapi.com/impf/JqWOcG7lOobM9KFwbU3UQ-9OLy_puFWzOMbO_Q/DUhAaTDGF4Q.jpg?size=537x240&quality=96&sign=215bfbc392566fda75d1f0cb18a6c376&type=share" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 39, 13, 899, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 39, 13, 901, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 39, 13, 901, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 20, 39, 13, 901, DateTimeKind.Local).AddTicks(3812));
        }
    }
}
