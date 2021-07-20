using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ISubjectRepository : IRepositoryBase<Subject>
    {
        IEnumerable<Subject> SearchByName(string name);
    }
}
