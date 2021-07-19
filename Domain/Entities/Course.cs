using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public virtual IEnumerable<Subject> Subject { get; set; }
    }
}