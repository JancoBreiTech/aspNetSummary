using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class studentEvaluationRestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

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
                    { new Guid("9b706460-15e0-494e-8597-551c070741b3"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("16581a5f-c193-427f-97f4-35867c957e82"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("16581a5f-c193-427f-97f4-35867c957e82"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9b706460-15e0-494e-8597-551c070741b3"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
