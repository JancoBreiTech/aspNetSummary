using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class AddedSeedDataAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("41d4a695-a93b-444e-ad34-cc7cb90897c6"), "First test...", 5, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("8c290e13-b5c3-4f65-b5d5-5024e2ae8953"), "Second test...", 4, new Guid("660ed4cd-1361-4216-9faa-9636e4df681a") },
                    { new Guid("f4e2a3cf-b630-46c5-980b-0e0b78bc2693"), "First test...", 3, new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac") },
                    { new Guid("812bc99d-d29f-4b86-8d5a-ea0ac500650c"), "Last test...", 2, new Guid("4addc421-0937-45cb-b55c-200b45c6caca") }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("49773a83-92a5-4e54-946d-fbf249999188"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("a5321399-9ea3-4b7d-aee7-cef3a47555ab"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("6bf4eebf-b008-4eaf-bb0e-a4f0bc6d13d2"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("6d9a6b14-831c-400f-a949-a60126c12b44"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectId", "SubjectName" },
                values: new object[,]
                {
                    { new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8"), "Math" },
                    { new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7"), "English" },
                    { new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad"), "History" },
                    { new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f"), "Computer Science" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") },
                    { new Guid("4addc421-0937-45cb-b55c-200b45c6caca"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("41d4a695-a93b-444e-ad34-cc7cb90897c6"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("812bc99d-d29f-4b86-8d5a-ea0ac500650c"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("8c290e13-b5c3-4f65-b5d5-5024e2ae8953"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("f4e2a3cf-b630-46c5-980b-0e0b78bc2693"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("49773a83-92a5-4e54-946d-fbf249999188"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("6bf4eebf-b008-4eaf-bb0e-a4f0bc6d13d2"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("6d9a6b14-831c-400f-a949-a60126c12b44"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a5321399-9ea3-4b7d-aee7-cef3a47555ab"));

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("4addc421-0937-45cb-b55c-200b45c6caca"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") });

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f"));

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
    }
}
