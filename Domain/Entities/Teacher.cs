using System;

namespace Domain.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public virtual Subject Subject{ get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }

    }
}