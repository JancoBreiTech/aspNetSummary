using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class OneToOneRelationship_StudentDetails12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("29d0714e-a8e5-40c7-b880-9cce1b2175a7"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("63fea1ee-5eaf-4f04-8aae-afc52ea80b10"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("673946bd-82ec-454e-9531-c939acd4f3bc"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("80ef2f6b-5e16-4fec-95c7-36c9d9e08a70"));

            migrationBuilder.AddColumn<string>(
                name: "AdditionsalInformation",
                table: "StudentDetails",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("581f5902-bb40-4b63-9ee7-da24a8a0818c"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("561b5298-f0cd-413e-80c4-61f1d1426855"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("07a08cc0-3fa6-4508-8771-052ae85287e4"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("b2dd8cf3-18fd-41e5-976a-80bc6c2f1271"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("07a08cc0-3fa6-4508-8771-052ae85287e4"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("561b5298-f0cd-413e-80c4-61f1d1426855"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("581f5902-bb40-4b63-9ee7-da24a8a0818c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b2dd8cf3-18fd-41e5-976a-80bc6c2f1271"));

            migrationBuilder.DropColumn(
                name: "AdditionsalInformation",
                table: "StudentDetails");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("63fea1ee-5eaf-4f04-8aae-afc52ea80b10"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("80ef2f6b-5e16-4fec-95c7-36c9d9e08a70"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("29d0714e-a8e5-40c7-b880-9cce1b2175a7"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("673946bd-82ec-454e-9531-c939acd4f3bc"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });
        }
    }
}
