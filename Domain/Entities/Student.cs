using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public decimal GradeId { get; set; }
        public IEnumerable<Grade> Grades { get; set; }
        public int SubjectId { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}
