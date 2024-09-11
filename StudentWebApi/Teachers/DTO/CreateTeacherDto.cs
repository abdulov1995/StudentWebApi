using StudentWebApi.Students.DTO;

namespace StudentWebApi.Teachers.DTO
{
    public class CreateTeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<int> StudentIds { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}
