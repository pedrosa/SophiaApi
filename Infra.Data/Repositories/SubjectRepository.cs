
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public IEnumerable<Subject> SearchByName(string name)
        {
            return Db.Subjects.Where(x => x.Name == name);
        }
    }
}
