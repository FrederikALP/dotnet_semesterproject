using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventTitle = table.Column<string>(type: "TEXT", nullable: false),
                    EventText = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Created", "EventText", "EventTitle", "Location", "Status", "UserId" },
                values: new object[] { 1, new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9852), "This is Event 1", "Post no 1", "CBS", 0, "1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Created", "EventText", "EventTitle", "Location", "Status", "UserId" },
                values: new object[] { 2, new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9855), "This is Event 2", "Post no 2", "Rådhuspladsen", 1, "1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Created", "EventText", "EventTitle", "Location", "Status", "UserId" },
                values: new object[] { 3, new DateTime(2022, 5, 23, 18, 10, 10, 88, DateTimeKind.Local).AddTicks(9856), "This is Event 3", "Post no 3", "KEA", 1, "1" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6e0e8b-5c42-49dd-81a4-4e2d51402328", "AQAAAAEAACcQAAAAEAtw7H60mzjhPwaZ+NqRkAjZ4aeSde5fu3YGLSI94/mU/6WuVkBLkykIKECj4a1BxQ==", "3022a109-4222-44bc-a24c-7af9e69df2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc398c9-9202-49b1-b82a-b5e1efd6838b", "AQAAAAEAACcQAAAAEJJ6LmqTnZ+ADQg+V3hgbbOL7y45YvStRo+ySZYGZIEFjHcV0qG8c3I5x06VKudZ1Q==", "26034978-c05a-40e5-92d2-3a5262682eb6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 739, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));
        }
    }
}
