using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}