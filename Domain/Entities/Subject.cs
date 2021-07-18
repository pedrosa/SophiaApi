namespace Domain.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public Teacher TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public Course CourseId { get; set; }
        public Student StudentId { get; set; }
        public virtual Student Student { get; set; }
        public Grade SubjectGrade { get; set; }
    }
}