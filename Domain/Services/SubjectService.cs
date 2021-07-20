using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class SubjectService : ServiceBase<Subject>, ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
            : base(subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public IEnumerable<Subject> SearchByName(string name)
        {
            return _subjectRepository.SearchByName(name);
        }
    }
}
