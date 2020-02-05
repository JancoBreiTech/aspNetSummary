using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class OneToManyEvaluationNotNullFKFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0dc8d98e-c60f-4fcd-9841-d13a53849903"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("2f30f1ae-f6f8-429d-938b-c831d9977b7d"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("58d52da6-de41-443e-87f7-51d52a60b78c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9347b94a-65a2-41f3-a5e0-fb10add58c8a"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("2f30f1ae-f6f8-429d-938b-c831d9977b7d"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("0dc8d98e-c60f-4fcd-9841-d13a53849903"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("58d52da6-de41-443e-87f7-51d52a60b78c"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("9347b94a-65a2-41f3-a5e0-fb10add58c8a"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });
        }
    }
}
