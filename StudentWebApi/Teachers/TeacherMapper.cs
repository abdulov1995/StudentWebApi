using AutoMapper;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public class TeacherMapper : Profile
    {
        public TeacherMapper()
        {
            CreateMap<Teacher, TeacherDto>();
            CreateMap<CreateTeacherDto,Teacher>();
            CreateMap<UpdateTeacherDto,Teacher>();
            CreateMap<Teacher, TeacherDetailDto>()
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.TeacherStudents.Select(x=>x.Student)));
        }
    }
}
