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
    [Migration("20200120101255_OneToOneRelationship_StudentDetails")]
    partial class OneToOneRelationship_StudentDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            Id = new Guid("63fea1ee-5eaf-4f04-8aae-afc52ea80b10"),
                            Age = 30,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("80ef2f6b-5e16-4fec-95c7-36c9d9e08a70"),
                            Age = 25,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = new Guid("29d0714e-a8e5-40c7-b880-9cce1b2175a7"),
                            Age = 28,
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            Id = new Guid("673946bd-82ec-454e-9531-c939acd4f3bc"),
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

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
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
