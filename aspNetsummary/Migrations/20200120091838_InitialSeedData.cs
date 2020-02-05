using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("b835665e-82df-4ef1-ae9b-b7e71f77a9d5"), new Guid("00000000-0000-0000-0000-000000000000"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AnotherKeyProperty", "Age", "Name" },
                values: new object[] { new Guid("50b922ff-d1c6-469f-9c99-d368618d01a4"), new Guid("00000000-0000-0000-0000-000000000000"), 25, "Jane Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("50b922ff-d1c6-469f-9c99-d368618d01a4"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumns: new[] { "StudentId", "AnotherKeyProperty" },
                keyValues: new object[] { new Guid("b835665e-82df-4ef1-ae9b-b7e71f77a9d5"), new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
