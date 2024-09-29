using StudentWebApi.Students.DTO;

namespace StudentWebApi.Teachers.DTO
{
    public class CreateTeacherDto
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<int> StudentIds { get; set; }
    }
}
