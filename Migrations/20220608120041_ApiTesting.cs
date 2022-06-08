using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class ApiTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d11faaa3-818d-4ad4-b1ef-6d9fe2e28e12", "AQAAAAEAACcQAAAAEBajZgtWZUp6GM1EtwUswtC5mTXWrfAyrcHMet+aCxY9+vLJ0T/DmEeEWLQ8FG6EYg==", "b6e7a2ee-d0d6-4e7b-b33e-9d84e40a9096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1618aa9f-e661-4c02-a7af-7c693d555aec", "AQAAAAEAACcQAAAAEBt4p5ztI/aBZtdcuiOUeurwgV54ovln+cx2JhvVh0cc23dUMhE2bbMLVja8dNlTiQ==", "573feb2c-c9b7-471f-8be4-a0f514d4f33d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                columns: new[] { "PostId", "TimeStamp" },
                values: new object[] { 4, new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "EventComment",
                keyColumn: "EventCommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9463), new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 8, 14, 0, 41, 380, DateTimeKind.Local).AddTicks(9348));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "PostId", "TimeStamp" },
                values: new object[] { 3, new DateTime(2022, 5, 25, 15, 34, 32, 705, DateTimeKind.Local).AddTicks(4031) });

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
    }
}
