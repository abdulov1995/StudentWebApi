using StudentWebApi.Students.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers.DTO
{
    public class TeacherDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentDto> StudentsDto { get; set; }
    }
}
