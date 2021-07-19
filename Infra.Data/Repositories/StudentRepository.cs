using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
    }
}
