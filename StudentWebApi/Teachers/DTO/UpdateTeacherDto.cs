using StudentWebApi.Students.DTO;

namespace StudentWebApi.Teachers.DTO
{
    public class UpdateTeacherDto
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<StudentDto> StudentDto { get; set; }
    }
}
