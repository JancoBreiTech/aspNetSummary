using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class OneToOneRelationship_StudentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("3a06dedf-4fa8-4219-97e4-b0448ad0b75f"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("4fdeea29-a3df-4cb0-8893-dc09f308ca27"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("9c3e0e6a-7707-474d-8ee2-71eaff385c33"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("f49d12d8-9339-472e-8990-ab3938332ba7"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentId");

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentDetailsId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentDetailsId);
                    table.ForeignKey(
                        name: "FK_StudentDetails_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_StudentId",
                table: "StudentDetails",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("3a06dedf-4fa8-4219-97e4-b0448ad0b75f"), new Guid("00000000-0000-0000-0000-000000000000"), 30, "John Doe" },
                    { new Guid("4fdeea29-a3df-4cb0-8893-dc09f308ca27"), new Guid("00000000-0000-0000-0000-000000000000"), 25, "Jane Doe" },
                    { new Guid("9c3e0e6a-7707-474d-8ee2-71eaff385c33"), new Guid("00000000-0000-0000-0000-000000000000"), 28, "Mike Miles" },
                    { new Guid("f49d12d8-9339-472e-8990-ab3938332ba7"), new Guid("00000000-0000-0000-0000-000000000000"), 100, "TEST NAME" }
                });
        }
    }
}
