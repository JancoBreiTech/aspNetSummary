using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class AddSeedData31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Evaluation",
                columns: new[] { "EvaluationId", "AdditionalExplanation", "Grade", "StudentId" },
                values: new object[,]
                {
                    { new Guid("36090657-2a75-4287-864d-c4163a5ba440"), "First test...", 5, new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690") },
                    { new Guid("fca9e605-e862-4ea4-b730-94e6e04a8b43"), "Second test...", 4, new Guid("16581a5f-c193-427f-97f4-35867c957e82") },
                    { new Guid("9f9db548-25e6-44c2-93b8-282bc9e0baa0"), "First test...", 3, new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f") },
                    { new Guid("3d44279f-24cf-4d8d-8ab2-e4d2498e25f7"), "Last test...", 2, new Guid("9b706460-15e0-494e-8597-551c070741b3") }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("be11f88f-a6c1-49cb-9138-ddf1c37f5b1a"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("911cc66f-e160-4010-bef3-143c1c871a53"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("6e6f9255-d056-4814-93cb-14cd6d0ac476"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("06be1b46-9d0e-4171-9b40-3fd3ba2cb8f5"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectId", "SubjectName" },
                values: new object[,]
                {
                    { new Guid("e47657f6-0f8d-49ba-a5b4-0e311a82fb09"), "Math" },
                    { new Guid("f6108ad4-62b7-4f22-8c83-2b5264f306b3"), "English" },
                    { new Guid("bdbee560-4efd-4466-8384-ba719b254516"), "History" },
                    { new Guid("fbede2c6-7953-496d-8a63-84afa2cc7f2f"), "Computer Science" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("36090657-2a75-4287-864d-c4163a5ba440"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("3d44279f-24cf-4d8d-8ab2-e4d2498e25f7"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("9f9db548-25e6-44c2-93b8-282bc9e0baa0"));

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: new Guid("fca9e605-e862-4ea4-b730-94e6e04a8b43"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("06be1b46-9d0e-4171-9b40-3fd3ba2cb8f5"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("6e6f9255-d056-4814-93cb-14cd6d0ac476"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("911cc66f-e160-4010-bef3-143c1c871a53"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("be11f88f-a6c1-49cb-9138-ddf1c37f5b1a"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("bdbee560-4efd-4466-8384-ba719b254516"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("e47657f6-0f8d-49ba-a5b4-0e311a82fb09"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("f6108ad4-62b7-4f22-8c83-2b5264f306b3"));

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "SubjectId",
                keyValue: new Guid("fbede2c6-7953-496d-8a63-84afa2cc7f2f"));

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
                    { new Guid("444e88e5-21b8-48e6-aa71-0e8ad6fd3690"), new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8") },
                    { new Guid("16581a5f-c193-427f-97f4-35867c957e82"), new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7") },
                    { new Guid("0906ace6-cecd-4579-99f0-4cc06ae1ac0f"), new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad") },
                    { new Guid("9b706460-15e0-494e-8597-551c070741b3"), new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f") }
                });
        }
    }
}
