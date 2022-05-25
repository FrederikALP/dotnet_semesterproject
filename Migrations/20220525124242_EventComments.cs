using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventComment",
                columns: table => new
                {
                    EventCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventComment", x => x.EventCommentId);
                    table.ForeignKey(
                        name: "FK_EventComment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventComment_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09a2f161-83ea-491c-9fff-e95688868f2e", "AQAAAAEAACcQAAAAEJJM93BXJLIKuB8mZSDYkGwnrBvXaeIvDtHlrPal3/A7L6cnG4yhxMmD8PDuem7eDg==", "520f4b76-bf76-462d-9391-32c592b43bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66821318-68fe-48e0-a3d2-471bc2259af9", "AQAAAAEAACcQAAAAENb7CTAIrIEZZyFEArCpAJOKWOqo+uepKpSX0cwS55ohyfYt3X6G1D287mTHFcAFIg==", "17f450e7-84d6-4519-8935-e3b4049967e7" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.InsertData(
                table: "EventComment",
                columns: new[] { "EventCommentId", "EventId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 1, 1, "Hello", new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1403), "1" });

            migrationBuilder.InsertData(
                table: "EventComment",
                columns: new[] { "EventCommentId", "EventId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 2, 1, "Hello again", new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1416), "2" });

            migrationBuilder.InsertData(
                table: "EventComment",
                columns: new[] { "EventCommentId", "EventId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 3, 2, "Hi", new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1417), "1" });

            migrationBuilder.InsertData(
                table: "EventComment",
                columns: new[] { "EventCommentId", "EventId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 4, 3, "Bye", new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1419), "1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1461), new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 508, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.CreateIndex(
                name: "IX_EventComment_EventId",
                table: "EventComment",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventComment_UserId",
                table: "EventComment",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventComment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fca68fa-106e-4c04-8516-478ffa4fc5ef", "AQAAAAEAACcQAAAAEIrTMLBuFVRIRPDoTZSlmGCA7v4dHr09+zVWQKTN7AYJh2kvkYC/PmweRwKAlNmqBA==", "a02f979d-84ba-4135-8c51-425834769385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183a5e04-fbab-44c2-89c3-eefbd07f4424", "AQAAAAEAACcQAAAAEP4PjTFqPF5FrPV5mHmChv7wnSlgjCamH71rPIkK1RcNoTJ8EGDEGz0YXIgHwzWdBQ==", "104a8441-acf1-4ec8-b234-7ec827551e75" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5263), new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 24, 18, 39, 54, 2, DateTimeKind.Local).AddTicks(5206));
        }
    }
}
