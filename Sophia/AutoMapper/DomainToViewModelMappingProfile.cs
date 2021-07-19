
using AutoMapper;
using Domain.Entities;
using Sophia.ViewModels;

namespace Sophia.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<StudentViewModel, Student>();
            Mapper.CreateMap<SubjectViewModel, Subject>();
        }
    }
}