using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("StudentId")]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Length must be less than 50 characters")]
        public string Name { get; set; }
        public int? Age { get; set; }

        [NotMapped]
        public int LocalCalculation { get; set; }
        public Guid AnotherKeyProperty { get; set; }
        public bool IsRegularStudent { get; set; }

        //one to one
        public StudentDetails StudentDetails { get; set; }
        //one to many
        public ICollection<Evaluation> Evaluations { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
