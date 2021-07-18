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
        public Course Course { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}
