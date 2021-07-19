using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            HasKey(x => x.SubjectId);

            Property(x => x.Name)
            .IsRequired();

            HasRequired(x => x.Student)
            .WithMany()
            .HasForeignKey(x => x.StudentId);

            HasRequired(x => x.Teacher)
            .WithMany()
            .HasForeignKey(x => x.TeacherId);

            HasRequired(x => x.Course)
            .WithMany()
            .HasForeignKey(x => x.CourseId);

            HasRequired(x => x.Grade)
            .WithRequiredDependent();

        }
    }
}
