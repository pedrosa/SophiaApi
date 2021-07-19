using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sophia.ViewModels
{
    public class StudentViewModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name field is required.")]
        [MaxLength(100, ErrorMessage = "Max 100 characters.")]
        [MinLength(2, ErrorMessage = "Minx 2 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name Birthday is required.")]
        public DateTime Birthday { get; set; }
        //public Course Course { get; set; }
        //public IEnumerable<Grade> Grades { get; set; }
        public IEnumerable<SubjectViewModel> Subjects { get; set; }

    }
}