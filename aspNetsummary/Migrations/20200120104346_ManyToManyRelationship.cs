using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class ManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("00d0af23-bf24-4f21-be1c-bb50ba033a19"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("032db8f5-d70e-469e-8511-b87df0e94dd4"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("43fbd120-ca72-479d-9ceb-2c5845c925da"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4d147263-c990-4ea4-9170-2095b2644ee2"));

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("27b9d6cf-8a63-4bc9-8421-4cae9baef150"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("fcc94616-4fa5-46bc-8e3c-8b4262952042"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("5ed1a0cf-8248-41d9-8a2b-9dad4afe0849"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("56cbe843-b73f-4ede-9d21-9449e4926f63"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("27b9d6cf-8a63-4bc9-8421-4cae9baef150"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("56cbe843-b73f-4ede-9d21-9449e4926f63"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("5ed1a0cf-8248-41d9-8a2b-9dad4afe0849"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("fcc94616-4fa5-46bc-8e3c-8b4262952042"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("43fbd120-ca72-479d-9ceb-2c5845c925da"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("00d0af23-bf24-4f21-be1c-bb50ba033a19"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("4d147263-c990-4ea4-9170-2095b2644ee2"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("032db8f5-d70e-469e-8511-b87df0e94dd4"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });
        }
    }
}
