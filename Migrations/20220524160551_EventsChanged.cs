using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Events",
                newName: "StartDate");

            migrationBuilder.AddColumn<string>(
                name: "Collaboration",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReservedRoom",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Responsible",
                table: "Events",
                type: "TEXT",
                nullable: true);

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
                columns: new[] { "Collaboration", "EndDate", "EventTitle", "PhotoURL", "ReservedRoom", "Responsible", "StartDate" },
                values: new object[] { "Event no 1", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8201), "Event no 1", "Event no 1", "Event no 1", "Event no 1", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Collaboration", "EndDate", "EventText", "EventTitle", "Location", "PhotoURL", "ReservedRoom", "Responsible", "StartDate" },
                values: new object[] { "Event no 2", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8205), "Event no 2", "Event no 2", "KEA", "Event no 2", "Event no 2", "Event no 2", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Collaboration", "EndDate", "EventText", "EventTitle", "Location", "PhotoURL", "ReservedRoom", "Responsible", "StartDate" },
                values: new object[] { "Event no 3", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8208), "Event no 3", "Event no 3", "Home", "Event no 3", "Event no 3", "Event no 3", new DateTime(2022, 5, 24, 18, 5, 51, 95, DateTimeKind.Local).AddTicks(8207) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Collaboration",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ReservedRoom",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Responsible",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Events",
                newName: "Created");

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
                values: new object[] { "eaa80768-b69f-4db6-8445-3b5f29eb2441", "AQAAAAEAACcQAAAAEPRbBHH00Z0gjawFcBa8zrN+9gRIx9hetRSGyABs/v438IyfWHnU/MF6r7jF263XrQ==", "840f73c6-394d-49dd-86ba-db4c2ddf9417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "048904bb-0f32-4cb8-8526-e88321142485", "AQAAAAEAACcQAAAAELzE9NPcHXAex6cX+px3gyDSV4MmVH5sxaB1OT+vOA2kw/cuxIvsadKgPXILO2f7Mg==", "db1350a2-40d2-4406-ae5d-0d7bba8e3800" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "Created", "EventTitle" },
                values: new object[] { new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9852), "Post no 1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "Created", "EventText", "EventTitle", "Location", "Status" },
                values: new object[] { new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9855), "This is Event 2", "Post no 2", "Rådhuspladsen", 1 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "Created", "EventText", "EventTitle", "Location", "Status" },
                values: new object[] { new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9856), "This is Event 3", "Post no 3", "KEA", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9810));
        }
    }
}
