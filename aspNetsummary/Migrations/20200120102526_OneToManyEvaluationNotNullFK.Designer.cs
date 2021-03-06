﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace aspNetsummary.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200120102526_OneToManyEvaluationNotNullFK")]
    partial class OneToManyEvaluationNotNullFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalExplanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("AnotherKeyProperty")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f30f1ae-f6f8-429d-938b-c831d9977b7d"),
                            Age = 30,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("0dc8d98e-c60f-4fcd-9841-d13a53849903"),
                            Age = 25,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = new Guid("58d52da6-de41-443e-87f7-51d52a60b78c"),
                            Age = 28,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            Id = new Guid("9347b94a-65a2-41f3-a5e0-fb10add58c8a"),
                            Age = 100,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "TEST NAME"
                        });
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionsalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Entities.Evaluation", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithMany("Evaluations")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithOne("StudentDetails")
                        .HasForeignKey("Entities.StudentDetails", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
