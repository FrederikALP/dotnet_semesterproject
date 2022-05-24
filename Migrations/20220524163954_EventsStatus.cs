using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventsStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");

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
    }
}
