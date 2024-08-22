using StudentWebApi.Students.Models;
using AutoMapper;
using StudentWebApi.Students.DTO;
using System.Runtime.InteropServices;

namespace StudentWebApi.Students
{
    public class StudentMapperProfile:Student
    {
        public StudentMapperProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

        }
    }
}
