using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(s => new { s.StudentId, s.SubjectId });

            builder.HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.StudentId);

            builder.HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectId);

            /*builder.HasData
            (
                new StudentSubject
                {
                    StudentId = new Guid("444E88E5-21B8-48E6-AA71-0E8AD6FD3690"),
                    SubjectId = new Guid("7e69e207-5131-4791-9064-57f6d3c47fc8")
                },
                new StudentSubject
                {
                    StudentId = new Guid("16581A5F-C193-427F-97F4-35867C957E82"),
                    SubjectId = new Guid("89fc9e5d-74f6-4d2e-ae82-76f2b1decce7")
                },
                new StudentSubject
                {
                    StudentId = new Guid("0906ACE6-CECD-4579-99F0-4CC06AE1AC0F"),
                    SubjectId = new Guid("9e5f12c2-0aa2-49b0-9db2-7df40fecf9ad")
                },
                new StudentSubject
                {
                    StudentId = new Guid("9B706460-15E0-494E-8597-551C070741B3"),
                    SubjectId = new Guid("fee204f4-a51d-44bb-a3d7-dcc2b5ee5d4f")
                }
                
            );*/
        }
    }


}
