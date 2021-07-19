namespace Domain.Entities
{
    public class Grade
    {
        public int GradeId { get; set; }
        public decimal SubjectGrade { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int StudentId { get; set; }
        public virtual  Student Student { get; set; }

    }
}