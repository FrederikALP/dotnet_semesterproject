using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventCommentsListHope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "247e2916-9608-407c-a6df-cc3d8074ba47", "AQAAAAEAACcQAAAAEF4SRNgR3OWv1Bl+6B6kyX5DRDM+FEjtR5G0cr2Tl7m0hFX6cy8JnpJJVrLfL1YI8Q==", "8b12f113-5d90-45fa-99b2-cff7f86c633b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3dc90d2-61d8-486a-84a6-ec5a3155480f", "AQAAAAEAACcQAAAAEL+WfqaOKZWuQMCUdDdbIzuD9r/orJXGzqLpyN9ryZMlTWPg1zhFX8XeMZc66HIICg==", "27614c04-1989-4865-b1bd-fd82c44ebebf" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4069), new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4072), new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4076), new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4008));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
