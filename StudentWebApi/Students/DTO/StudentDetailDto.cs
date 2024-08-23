using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Students.DTO
{
    public class StudentDetailDto
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<TeacherDto> Teachers { get; set; }
    }
}
