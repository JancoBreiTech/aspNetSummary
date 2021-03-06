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
    [Migration("20200120094200_RevertTestMigration")]
    partial class RevertTestMigration
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
                        .HasColumnName("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnotherKeyProperty")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegularStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id", "AnotherKeyProperty");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3a06dedf-4fa8-4219-97e4-b0448ad0b75f"),
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("4fdeea29-a3df-4cb0-8893-dc09f308ca27"),
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = new Guid("9c3e0e6a-7707-474d-8ee2-71eaff385c33"),
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            Age = 28,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            Id = new Guid("f49d12d8-9339-472e-8990-ab3938332ba7"),
                            AnotherKeyProperty = new Guid("00000000-0000-0000-0000-000000000000"),
                            Age = 100,
                            IsRegularStudent = false,
                            Name = "TEST NAME"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
