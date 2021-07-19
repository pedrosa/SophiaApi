
using AutoMapper;
using Domain.Entities;
using Sophia.ViewModels;

namespace Sophia.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Student, StudentViewModel>();
            Mapper.CreateMap<Student, SubjectViewModel>();
        }
    }
}