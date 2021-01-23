using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 872, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "Comment", "Date", "Email", "Name", "PostId", "WebSite" },
                values: new object[,]
                {
                    { 1, "Да твою ж ты мать как же задрали с этим открытым миром! Чтобы сделать нормальный открытый мир нужна толпа народу уровня Rockstar, а не 50 задохликов. Ну никак они не научатся", "22.01.2021", "kirril2004@gmail.com", "Urell", 1, null },
                    { 22, "Это тот стардок который не дает владельцам базовой игры (или стартер пака) купить Ультимейт бандл (хоть со скидкой хоть без) — то есть приходится каждое длц по отдельности покупать. Даже Парадоксы не настолько наглы.При возможности теперь ставлю на свою лицензию пиратские длц.", "22.01.2021", null, "Hev", 4, null },
                    { 21, "Кто знает как установить русский язык?", "22.01.2021", null, "Gnas", 4, null },
                    { 20, "Русский язык есть?", "22.01.2021", null, "Ulfesi", 4, null },
                    { 19, "Вторая часть была лучше базовой третей. Покатаю из ностальжи. Но она сырая, что Ппц. ", "22.01.2021", null, "Emoreyabo", 4, null },
                    { 18, "а что по русскому языку слышно? как включить то?)", "22.01.2021", null, "Vikilitok", 4, null },
                    { 17, "Люди, как поменять в ней язык? В Эпике написано, что есть русский текст — по факту нету. ", "22.01.2021", null, "Fianhinay", 4, null },
                    { 16, "Кто знает как русский язык включить в Galactic Civilizations III?", "22.01.2021", null, "Rengr", 4, null },
                    { 14, "Судя по тизеру, в Reverse будут локации из Remake 2 и 3. Переделанный участок однако.", "22.01.2021", null, "Eeligane", 3, null },
                    { 15, "Флэшбеки о Resistance...", "22.01.2021", null, "Janci", 3, null },
                    { 12, "Значит не просто оба ремейка вышли после 7 ну перед 8. Скорее всего они будут связанный", "22.01.2021", null, "Giai", 3, null },
                    { 11, "там ноунейм индюшатина NOWAA пытается пропиариться, утверждая что Respawn у них персонажа украли. Но не учитывая, что данному образу наемника уже тьма лет с хвостиком.", "22.01.2021", null, "Def", 2, null },
                    { 10, "Привет, я подсяду?", "22.01.2021", null, "Glane", 2, null },
                    { 9, "ГГ трейлера будто прямиком из borderlands ", "22.01.2021", null, "Salasheng", 2, null },
                    { 8, "Ну ёк-макарёк, как так то? Весь Каньон Кингс уничтожили? За что? Мне теперь новую зону быстрого проигрыша и Potato Aim искать?", "22.01.2021", null, "Fenor", 2, null },
                    { 7, "Почему на фото я вижу Кенни?", "22.01.2021", null, "Егор", 2, null },
                    { 6, "Красивый трейлер)", "22.01.2021", null, "Anen", 2, null },
                    { 5, "Визуал просто фантастика! После Inside, жду новую игру от них, прям с нетерпением.", "22.01.2021", null, "Sastaipra", 1, null },
                    { 4, "Ого, прикольно, жду игру", "22.01.2021", null, "Prdinda", 1, null },
                    { 3, "открытый мир это не всегда тысячи вышек, сотни километров и десятки квестов.надоели задохлики которые не знают, что бывают разные игры", "22.01.2021", null, "Jela", 1, null },
                    { 2, "Это может быть открытый мир в стиле Outer Wilds, например.", "22.01.2021", null, "Maned", 1, null },
                    { 13, "А можно не надо?", "22.01.2021", null, "Zeenatiny", 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(8914));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 113, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 21, 22, 48, 44, 115, DateTimeKind.Local).AddTicks(7402));
        }
    }
}
