using FluentValidation;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;

namespace StudentWebApi.Students
{
    public class StudentValidator : AbstractValidator<CreateStudentDto>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is required!");
            RuleFor(s => s.Age).NotEmpty().WithMessage("Age is required!");
        }
    }
}
