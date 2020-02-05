using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspNetsummary.Migrations
{
    public partial class OneToManyEvaluationNotNullFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("5bcc92da-56b1-4b62-98dd-66f70dbeee1f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("b2a8b051-d652-4c80-beaf-95659d378fcc"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("d10204ef-0152-4ae1-950f-5408b256ca63"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f6b36c5f-85b2-4f7d-842c-4a4d1467731b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "Evaluation",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentId",
                table: "Evaluation",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherKeyProperty", "Name" },
                values: new object[,]
                {
                    { new Guid("b2a8b051-d652-4c80-beaf-95659d378fcc"), 30, new Guid("00000000-0000-0000-0000-000000000000"), "John Doe" },
                    { new Guid("5bcc92da-56b1-4b62-98dd-66f70dbeee1f"), 25, new Guid("00000000-0000-0000-0000-000000000000"), "Jane Doe" },
                    { new Guid("d10204ef-0152-4ae1-950f-5408b256ca63"), 28, new Guid("00000000-0000-0000-0000-000000000000"), "Mike Miles" },
                    { new Guid("f6b36c5f-85b2-4f7d-842c-4a4d1467731b"), 100, new Guid("00000000-0000-0000-0000-000000000000"), "TEST NAME" }
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
