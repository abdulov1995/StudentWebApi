using AutoMapper;
using StudentWebApi.Teachers.DTO;

namespace StudentWebApi.Teachers.Models
{
    public class TeacherMapper:Profile
    {
        public TeacherMapper()
        {
            CreateMap<Teacher, TeacherDto >().ReverseMap(); ;
            CreateMap<Teacher, CreateTeacherDto >();
            CreateMap<Teacher, UpdateTeacherDto >();
            CreateMap<Teacher, TeacherDetailDto>()
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.Students));
        }
    }
}
