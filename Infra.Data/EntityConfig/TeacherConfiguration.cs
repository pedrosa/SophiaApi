using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Infra.Data.EntityConfig
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            HasKey(x => x.TeacherId);

            Property(x => x.Name)
            .IsRequired();

            Property(x => x.Birthday)
            .IsRequired();

            Property(x => x.Salary)
            .IsRequired();            
        }
    }
}
