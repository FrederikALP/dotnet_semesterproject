using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventCommentsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8ecac4-993f-4897-9838-4f7fe6c29e5e", "AQAAAAEAACcQAAAAEOYl6awDLvER0vsxkDajXAE/3f4VAuYclCuvnpcs/U3z/QpDtZfMPXafk4ryq9yVJQ==", "569fc009-88b7-4164-83dc-c5f3f54c7475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24bf7cd7-237e-4ed5-8284-8492dc96b7f9", "AQAAAAEAACcQAAAAEN7K2TwEdYZjB0aYjG4DizySSj5xTIs8KIpaLPbr1U4vtW8MKiFUKt5phZLOK4EPcA==", "aa087e09-59f8-4fbe-b966-ae7e857d811e" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9818), new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9822), new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9825), new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 14, 50, 34, 55, DateTimeKind.Local).AddTicks(9757));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 14, 42, 42, 510, DateTimeKind.Local).AddTicks(1419));

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
        }
    }
}
