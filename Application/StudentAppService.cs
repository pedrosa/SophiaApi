using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class StudentAppService : AppServiceBase<Student>, IStudentAppService
    {
        private readonly IStudentService _studentService;

        public StudentAppService(IStudentService studentService)
            : base(studentService)
        {
            _studentService = studentService;
        }
    }
}
