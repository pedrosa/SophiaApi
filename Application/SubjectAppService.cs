
using System.Collections.Generic;
using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class SubjectAppService : AppServiceBase<Subject>, ISubjectAppService
    {
        private readonly ISubjectService _subjectService;

        public SubjectAppService(ISubjectService subjectService)
            : base(subjectService)
        {
            _subjectService = subjectService;
        }

        public IEnumerable<Subject> SearchByName(string name)
        {
            return _subjectService.SearchByName(name);
        }
    }
}
