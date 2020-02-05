using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class EvaluationConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.HasData
            (
                new Evaluation
                {
                    Id = Guid.NewGuid(),
                    Grade = 5,
                    AdditionalExplanation = "First test...",
                    StudentId = new Guid("444E88E5-21B8-48E6-AA71-0E8AD6FD3690")
                },
                new Evaluation
                {
                    Id = Guid.NewGuid(),
                    Grade = 4,
                    AdditionalExplanation = "Second test...",
                    StudentId = new Guid("16581A5F-C193-427F-97F4-35867C957E82")
                },
                new Evaluation
                {
                    Id = Guid.NewGuid(),
                    Grade = 3,
                    AdditionalExplanation = "First test...",
                    StudentId = new Guid("0906ACE6-CECD-4579-99F0-4CC06AE1AC0F")
                },
                new Evaluation
                {
                    Id = Guid.NewGuid(),
                    Grade = 2,
                    AdditionalExplanation = "Last test...",
                    StudentId = new Guid("9B706460-15E0-494E-8597-551C070741B3")
                }
            );
        }
    }
}
