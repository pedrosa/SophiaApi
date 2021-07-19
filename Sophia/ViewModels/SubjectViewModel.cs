using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sophia.ViewModels
{
    public class SubjectViewModel
    {
        [Key]
        public int SubjectId { get; set; }

        public string Name { get; set; }
        //public int TeacherId { get; set; }
        //public virtual Teacher Teacher { get; set; }
        //public int CourseId { get; set; }
        //public virtual Course Course { get; set; }
        public int StudentId { get; set; }
        //public virtual Student Student { get; set; }
        //public int GradeId { get; set; }
        //public virtual Grade Grade { get; set; }
        public virtual StudentViewModel Student { get; set; }

    }
}