using AutoMapper;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;

namespace StudentWebApi.Students
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentDto>();
        }
    }
}
