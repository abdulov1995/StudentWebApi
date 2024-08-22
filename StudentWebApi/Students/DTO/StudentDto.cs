using StudentWebApi.Teachers.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentWebApi.Students.DTO
{
    public class StudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<TeacherStudent> TeacherStudents { get; set; }
    }
}
