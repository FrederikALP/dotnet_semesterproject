using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventsCollaboration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d827fc1b-6ec9-4a78-aae1-a5d4dae892fe", "AQAAAAEAACcQAAAAEG0OfZqet/bd4hQUpCMDu8/RbF2ENodV/atyDvmbs6ZgDlf8IP+Xo0K2+vD4NMVwQg==", "6333f66b-9391-4902-9ca0-c5ed7ff40f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac4c74bb-b5ff-4a55-98a6-e6e6bf5b827a", "AQAAAAEAACcQAAAAEMThD8qA4MsG2j51UWZcrz1p2AKorFHg/WYA4kuht0cs+slQXGhIUwqYShIw2+6ERw==", "962213fc-2044-4a68-bc22-837ed11cb985" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4855), new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4859), new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4862), new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 9, 29, 900, DateTimeKind.Local).AddTicks(4818));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ef7e8b-4a49-4401-a581-8822fcc672bf", "AQAAAAEAACcQAAAAEBNLKUFTA7DGtRSnY5M5ruCJnIpXDRbBasD8x2GLjkTMtmm1Qu/Rur2CSTrx8+H8FQ==", "87fd5d5e-29c5-49bd-90c8-8487ea562034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05a32938-3cfe-4a82-a4ca-2edc0988f0f8", "AQAAAAEAACcQAAAAEO11EjSsKcabotFcTgeEPJJLR/lKPX+QUByFW14SStuNzZoyQDrUtHwkPS5DFNxQAQ==", "6237d8b5-ac4c-442f-bf12-1e49f1bde77d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8201), new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8205), new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8208), new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8163));
        }
    }
}
