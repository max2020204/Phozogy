using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64045cd6-ad72-4f86-9e7d-6d6a5cc9fd93",
                column: "ConcurrencyStamp",
                value: "b941e0f2-b083-436d-a7de-f73148c815ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1aed698-8ad8-4ed6-ab93-c6c71c90e803",
                column: "ConcurrencyStamp",
                value: "582ae784-410e-4ac5-b362-2445f6c00e3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccefb91e-3f23-40b5-a376-53436f2786ae", "5bd83b78-880e-4706-a2b9-154c8468d9fd", "moderator", "MODERATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44b4e4c5-445e-41c5-acef-2066d5669501",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6384a952-c388-4c05-9868-5f59c90344e1", "AQAAAAEAACcQAAAAEJqKypOi9AN0IjZkkWBji10Zbv8yncmIYMQf+sK4hmkFo+wOWOesOaCmg7axGKBFGg==", "d58b0820-4bb8-45fe-9fe2-abc59c11c849" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: "8/31/2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: "8/31/2021");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccefb91e-3f23-40b5-a376-53436f2786ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64045cd6-ad72-4f86-9e7d-6d6a5cc9fd93",
                column: "ConcurrencyStamp",
                value: "2c10c045-1e36-48a3-9932-00074ecc9d5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1aed698-8ad8-4ed6-ab93-c6c71c90e803",
                column: "ConcurrencyStamp",
                value: "579b0641-548d-4e93-88fc-774480d24338");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44b4e4c5-445e-41c5-acef-2066d5669501",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed7e8262-d2da-4068-9873-a2dc77e0e997", "AQAAAAEAACcQAAAAEGW9dQZEp/Uf5hDxd0JaX5yUTDDtdGK+jui4OE/K0rXnsT5C3MyeUPZaBe/ZCDTBTA==", "abb10fc5-3363-490f-9c3e-fc494c1520a5" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: "02.02.2021");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: "02.02.2021");
        }
    }
}