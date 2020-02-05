using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("4a2c8e86-ddac-48c1-83e5-9398e48ecac8"), "First test...", 5, new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690") },
                    { new Guid("064e1073-5024-46d6-9fd1-0030af450139"), "Second test...", 4, new Guid("16581a5f-c193-427f-97f4-35867c957e82") },
                    { new Guid("e2e85c14-061e-403c-a197-99824ca1aa7e"), "First test...", 3, new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f") },
                    { new Guid("ac04f2bb-da1c-43ba-b2cc-11aaf36cb881"), "Last test...", 2, new Guid("9b706460-15e0-494e-8597-551c070741b3") }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("dc2b59e1-35d7-412d-a5d0-cbbc517306ab"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("0980a91e-6eb0-4feb-aa8f-953d234e12e6"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("dc4314f1-068f-4829-80fb-ca41b565d509"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("091b9ff7-8194-4bae-8251-fa78fa5fa2d8"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("16581a5f-c193-427f-97f4-35867c957e82"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") },
                    { new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") },
                    { new Guid("9b706460-15e0-494e-8597-551c070741b3"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("064e1073-5024-46d6-9fd1-0030af450139"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("4a2c8e86-ddac-48c1-83e5-9398e48ecac8"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("ac04f2bb-da1c-43ba-b2cc-11aaf36cb881"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("e2e85c14-061e-403c-a197-99824ca1aa7e"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("091b9ff7-8194-4bae-8251-fa78fa5fa2d8"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0980a91e-6eb0-4feb-aa8f-953d234e12e6"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("dc2b59e1-35d7-412d-a5d0-cbbc517306ab"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("dc4314f1-068f-4829-80fb-ca41b565d509"));

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("16581a5f-c193-427f-97f4-35867c957e82"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { new Guid("9b706460-15e0-494e-8597-551c070741b3"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") });

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
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") },
                    { new Guid("660ed4cd-1361-4216-9faa-9636e4df681a"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") },
                    { new Guid("410c14e3-e6df-45b8-8c6f-1e19aed675ac"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("4addc421-0937-45cb-b55c-200b45c6caca"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") }
                });
        }
    }
}
