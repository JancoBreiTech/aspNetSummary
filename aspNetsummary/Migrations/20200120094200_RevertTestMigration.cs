using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class RevertTestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("20d0e29e-a207-4ac8-bd71-4be75cb3b6ba"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("66d8b5c5-3c58-4674-b211-73908083a4fc"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("87d3d675-cce3-465a-a58b-4ad0efb29ae1"), new Guid("00000000-0000-0000-0000-000000000000") });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("87d3d675-cce3-465a-a58b-4ad0efb29ae1"), new Guid("00000000-0000-0000-0000-000000000000"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("20d0e29e-a207-4ac8-bd71-4be75cb3b6ba"), new Guid("00000000-0000-0000-0000-000000000000"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("66d8b5c5-3c58-4674-b211-73908083a4fc"), new Guid("00000000-0000-0000-0000-000000000000"), 28, "Mike Miles" });
        }
    }
}
