using AutoMapper;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;



namespace StudentWebApi
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<CreateStudentDto, Student>().ReverseMap();
            CreateMap<UpdateStudentDto, Student>().ReverseMap();
            CreateMap<Student, StudentDetailDto>().ReverseMap()
                .ForMember(dest => dest.Teachers, opt => opt.MapFrom(src => src.Teachers));
            CreateMap<TeacherDto, Teacher>();
            CreateMap<CreateTeacherDto, Teacher>().ReverseMap();
            CreateMap<UpdateTeacherDto, Teacher>().ReverseMap();
            CreateMap<Teacher, TeacherDetailDto>().ReverseMap()
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.Students));
        }
    }
}
