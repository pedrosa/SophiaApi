using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ISubjectService : IServiceBase<Subject>
    {
        IEnumerable<Subject> SearchByName(string name);
    }
}
