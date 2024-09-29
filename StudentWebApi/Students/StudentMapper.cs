using AutoMapper;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;



namespace StudentWebApi.Students
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDto, Student>();
            CreateMap<Student, StudentDetailDto>()
                .ForMember(dest => dest.Teachers, opt => opt.MapFrom(src => src.TeacherStudents.Select(x => x.Teacher)));
        }
    }
}
