using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phozogy.Migrations
{
    public partial class AddedBlogAndPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Short_Description",
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
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 41, 48, 350, DateTimeKind.Local).AddTicks(2564), "News" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8457), "News" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8482), "News" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8486), "Freebie" });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "id", "Date", "Image", "Short_Description", "Title", "Type" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8489), "https://3dnews.ru/assets/external/illustrations/2021/01/20/1030596/Hitman3.jpg", "Доля цифровых продаж в игровой индустрии увеличивается с каждым годом, а пандемия только ускорила рост. Вот и серия HITMAN побила личный рекорд в этой сфере — IO Interactive сообщает, что у третьей части случился самый успешный цифровой релиз за всю историю франшизы.", "HITMAN 3 ПОКАЗАЛА КРУПНЕЙШИЙ ЦИФРОВОЙ ЗАПУСК В ИСТОРИИ СЕРИИ", "News" },
                    { 6, new DateTime(2021, 1, 22, 21, 41, 48, 351, DateTimeKind.Local).AddTicks(8491), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJWGg8cLB4DoXsna_gdu6oXil-StdGBznrkw&usqp=CAU", "Microsoft поделилась сразу двумя новостями. Прежде всего, компания огласила список бесплатных игр для подписчиков Xbox Live Gold в феврале. Вторая весть не столь приятная — Gold-подписка подорожает в ряде регионов.", "XBOX LIVE GOLD В ФЕВРАЛЕ: GEARS 5, RESIDENT EVIL И НЕ ТОЛЬКО. ПОДПИСКА ПОДОРОЖАЕТ — НО НЕ В РОССИИ", "News" }
                });

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

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Date", "Description", "MainPhoto", "Tags", "Title" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1069), "<p>Доля цифровых продаж в игровой индустрии увеличивается с каждым годом, а пандемия только ускорила рост. Вот и серия <strong>HITMAN</strong> побила личный рекорд в этой сфере — <strong>IO Interactive</strong> сообщает, что у третьей части случился самый успешный цифровой релиз за всю историю франшизы.</p><p>Точных цифр <strong>IOI</strong> не назвала, поэтому прикинуть, насколько хорошо идут дела у <strong>HITMAN 3</strong>, пока не удастся. Зато разработчики похвастали высокими оценками триквела. Игру и правда приняли очень тепло: рейтинг на <a target=\"_blank\" href=\"/to/?https://opencritic.com/game/10039/hitman-3\">OpenCritic</a> — 86/100. Пресса пишет, что новинка блестяще завершает трилогию «Мир заказных убийств» и таит немало сюрпризов для фанатов предыдущих частей.</p><p>К сожалению, на старте <strong>HITMAN 3</strong> разделить восторг журналистов смогли не все пользователи. Первое время у игроков <a href=\"https://stopgame.ru/newsdata/46441\">не получалось перенести</a> в триквел свой прогресс из <strong>H2</strong>. К настоящему времени <strong>IOI</strong> вроде бы привела свой сервис в чувство, но в комментариях к свежему твиту до сих пор встречаются жалобы на ошибки.</p><p><strong>HITMAN 3</strong> продаётся на PC, PlayStation, Xbox, Stadia и Nintendo Switch.</p><div class=\"twitter-tweet twitter-tweet-rendered\" style=\"display: flex; max-width: 550px; width: 100%; margin-top: 10px; margin-bottom: 10px;\"><iframe id=\"twitter-widget-0\" scrolling=\"no\" frameborder=\"0\" allowtransparency=\"true\" allowfullscreen=\"true\" class=\"\" style=\"position: static; visibility: visible; width: 550px; height: 520px; display: block; flex-grow: 1;\" title=\"Twitter Tweet\" src=\"https://platform.twitter.com/embed/index.html?dnt=false&amp;embedId=twitter-widget-0&amp;frame=false&amp;hideCard=false&amp;hideThread=false&amp;id=1352585318072020997&amp;lang=ru&amp;origin=https%3A%2F%2Fstopgame.ru%2Fnewsdata%2F46472&amp;siteScreenName=stopgameru&amp;theme=light&amp;widgetsVersion=ed20a2b%3A1601588405575&amp;width=550px\" data-tweet-id=\"1352585318072020997\"></iframe></div>", "https://cdn.igromania.ru/mnt/games/b/1/3/8/b/9/381700/f4ca270d5cb79d5c_1200xH.jpg", "Epic Games|Hitman 3", "HITMAN 3 ПОКАЗАЛА КРУПНЕЙШИЙ ЦИФРОВОЙ ЗАПУСК В ИСТОРИИ СЕРИИ" },
                    { 6, new DateTime(2021, 1, 22, 21, 41, 48, 352, DateTimeKind.Local).AddTicks(1072), "<p><strong>Microsoft</strong> поделилась сразу двумя новостями. Прежде всего, компания огласила <a target=\"_blank\" href=\"/to/?https://news.xbox.com/ru-ru/2021/01/22/new-games-gold-feb-2021/\">список бесплатных игр</a> для подписчиков Xbox Live Gold в феврале. Вторая весть не столь приятная — Gold-подписка <a target=\"_blank\" href=\"/to/?https://news.xbox.com/en-us/2021/01/22/update-on-xbox-live-gold-pricing/\">подорожает</a> в ряде регионов.</p><h3>Игры для подписчиков</h3><ul><li><strong>Gears 5</strong> — с 1-го по 28 февраля.</li><li><strong>Resident Evil</strong> — с 1-го по 28 февраля.</li><li><strong>Dandara: Trials of Fear Edition</strong> — с 16 февраля по 15 марта.</li><li><strong>Indiana Jones and the Emperor's Tomb</strong> — с 1-го по 15 февраля.</li><li><strong>Lost Planet 2</strong> — с 16-го по 28 февраля.</li></ul><div class=\"twitter-tweet twitter-tweet-rendered\" style=\"display: flex; max-width: 550px; width: 100%; margin-top: 10px; margin-bottom: 10px;\"><iframe id=\"twitter-widget-0\" scrolling=\"no\" frameborder=\"0\" allowtransparency=\"true\" allowfullscreen=\"true\" class=\"\" style=\"position: static; visibility: visible; width: 550px; height: 640px; display: block; flex-grow: 1;\" title=\"Twitter Tweet\" src=\"https://platform.twitter.com/embed/index.html?dnt=false&amp;embedId=twitter-widget-0&amp;frame=false&amp;hideCard=false&amp;hideThread=false&amp;id=1352617810678214656&amp;lang=ru&amp;origin=https%3A%2F%2Fstopgame.ru%2Fnewsdata%2F46477&amp;siteScreenName=stopgameru&amp;theme=light&amp;widgetsVersion=ed20a2b%3A1601588405575&amp;width=550px\" data-tweet-id=\"1352617810678214656\"></iframe></div><h3>Повышение цен</h3><p>По словам <strong>Microsoft</strong>, периодически она оценивает стоимость своих сервисов, чтобы «отразить изменения на региональных рынках и продолжать вкладываться в сообщество Xbox». Кое-где расценки не менялись годами, а то и больше десятка лет. Посему корпорация приняла решение поднять стоимость подписки:</p><ul><li>Месяц Gold: $9.99 → $10.99.</li><li>Три месяца: $24.99 → $29.99.</li><li>Шесть месяцев: $39.99 → $59.99.</li></ul><p>К счастью, России изменения не коснутся — это в комментарии для StopGame.ru подтвердил представитель Xbox.</p><p>Жителям регионов, где произойдёт подорожание, в течение ближайшего месяца разошлют соответствующее уведомление. Новые цены вступят в силу не раньше чем через 45 дней после получения письма.</p>", "https://sun9-1.userapi.com/impf/ZG2fSFlu3KL4oUz7rXpTqBaI7EPd3o1w0vBn7Q/Us73exmwiTA.jpg?size=537x240&quality=96&sign=d25a4256d00ce63594eed133ded9f0bb&type=share", "XBOX|Gears 5|Resident Evi", "XBOX LIVE GOLD В ФЕВРАЛЕ: GEARS 5, RESIDENT EVIL И НЕ ТОЛЬКО. ПОДПИСКА ПОДОРОЖАЕТ — НО НЕ В РОССИИ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Short_Description",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 31, 38, 872, DateTimeKind.Local).AddTicks(9410), "Blog" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6304), "Blog" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6333), "Blog" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Date", "Type" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 31, 38, 874, DateTimeKind.Local).AddTicks(6337), "Blog" });

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
    }
}
