using AutoMapper;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public class TeacherMapper : Profile
    {
        public TeacherMapper()
        {
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<Teacher, CreateTeacherDto>().ReverseMap();
            CreateMap<Teacher, UpdateTeacherDto>().ReverseMap();
            CreateMap<Teacher, TeacherDetailDto>()
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.TeacherStudents));
        }
    }
}
