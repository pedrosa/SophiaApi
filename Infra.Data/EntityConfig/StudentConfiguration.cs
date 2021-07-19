using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(x => x.StudentId);

            Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

            Property(x => x.Birthday)
            .IsRequired();
        }
    }
}
