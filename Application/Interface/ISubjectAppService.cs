using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interface
{
    public interface ISubjectAppService : IAppServiceBase<Subject>
    {
        IEnumerable<Subject> SearchByName(string name);
    }
}
