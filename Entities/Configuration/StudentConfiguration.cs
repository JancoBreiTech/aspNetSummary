﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(s => s.Age)
                .IsRequired(false);
            builder.Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);
            builder.HasMany(e => e.Evaluations)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData
                (
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "John Doe",
                        Age = 30
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jane Doe",
                        Age = 25
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mike Miles",
                        Age = 28
                    },
                    new Student
                    {
                        Id = Guid.NewGuid(),
                        Name = "TEST NAME",
                        Age = 100
                    }
                );
        }
    }
}
