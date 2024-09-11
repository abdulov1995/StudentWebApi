using AutoMapper;
using StudentWebApi.Students.DTO;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;



namespace StudentWebApi.Students.Models
{
    public class StudentMapper : Profile
    {
        public StudentMapper()
        {
            CreateMap<Student,StudentDto >().ReverseMap();
            CreateMap<Student,CreateStudentDto >().ReverseMap();
            CreateMap<Student,UpdateStudentDto >().ReverseMap();
            CreateMap<Student, StudentDetailDto>()
                .ForMember(dest => dest.Teachers, opt => opt.MapFrom(src => src.Teachers));
        }
    }
}
