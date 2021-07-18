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
            .IsRequired();

            Property(x => x.Birthday)
            .IsRequired();

            Property(x => x.Email)
            .IsRequired();

            Property(x => x.Telephone)
            .IsRequired();

        }
    }
}
