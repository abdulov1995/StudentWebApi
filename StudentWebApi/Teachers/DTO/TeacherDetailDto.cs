using StudentWebApi.Students.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers.DTO
{
    public class TeacherDetailDto
    {
        public string Name { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}
