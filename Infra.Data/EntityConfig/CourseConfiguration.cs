using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(x => x.CourseId);

            Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(130);

            HasRequired(x => x.Student)
            .WithMany()
            .HasForeignKey(x => x.StudentId);
        }
    }
}
