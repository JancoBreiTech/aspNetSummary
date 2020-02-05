using Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new EvaluationConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());

            modelBuilder.Entity<Student>()
                .ToTable("Student");
            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .HasColumnName("StudentId");
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired(false);
            modelBuilder.Entity<Student>()
                .Ignore(s => s.LocalCalculation);
            modelBuilder.Entity<Student>()
                .HasKey(s => s.Id);
           /* modelBuilder.Entity<Student>()
                .HasKey(s => new { s.Id, s.AnotherKeyProperty });//Composite key*/
            modelBuilder.Entity<Student>()
                .Property(s => s.IsRegularStudent)
                .HasDefaultValue(true);

           /* modelBuilder.Entity<Student>()
                .HasData(
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
                    }
                );*/

        }

        public DbSet<Student> Students { get; set; }


        
    }
}
