using AutoMapper;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;



namespace StudentWebApi
{
    public class StudentMapper:Profile
    {
        public StudentMapper()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
        }
    }
}
