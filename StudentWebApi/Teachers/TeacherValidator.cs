using FluentValidation;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public class TeacherValidator:AbstractValidator<CreateTeacherDto>
    {
        public TeacherValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage("Name is required!");
            RuleFor(t => t.Subject).NotEmpty().WithMessage("Subject is required!");
        }
    }
}
