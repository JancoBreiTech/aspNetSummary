using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData
            (
                new Subject
                {
                    Id = Guid.NewGuid(),
                    SubjectName = "Math"
                },
                new Subject
                {
                    Id = Guid.NewGuid(),
                    SubjectName = "English"
                },
                new Subject
                {
                    Id = Guid.NewGuid(),
                    SubjectName = "History"
                },
                new Subject
                {
                    Id = Guid.NewGuid(),
                    SubjectName = "Computer Science"
                }
            );
        }
    }
}
