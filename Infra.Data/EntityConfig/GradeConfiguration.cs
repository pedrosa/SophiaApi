using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class GradeConfiguration : EntityTypeConfiguration<Grade>
    {
        public GradeConfiguration()
        {
            HasKey(x => x.GradeId);

            Property(x => x.SubjectGrade)
            .IsRequired();

            HasRequired(x => x.Student)
            .WithMany()
            .HasForeignKey(x => x.StudentId);

        }
    }
}
