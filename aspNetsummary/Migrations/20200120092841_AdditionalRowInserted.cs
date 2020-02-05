using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("50b922ff-d1c6-469f-9c99-d368618d01a4"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("b835665e-82df-4ef1-ae9b-b7e71f77a9d5"), new Guid("00000000-0000-0000-0000-000000000000") });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("b835665e-82df-4ef1-ae9b-b7e71f77a9d5"), new Guid("00000000-0000-0000-0000-000000000000"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("50b922ff-d1c6-469f-9c99-d368618d01a4"), new Guid("00000000-0000-0000-0000-000000000000"), 25, "Jane Doe" });
        }
    }
}
