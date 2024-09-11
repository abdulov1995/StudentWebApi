using StudentWebApi.Teachers.DTO;

namespace StudentWebApi.Students.DTO
{
    public class CreateStudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> TeacherIds { get; set; }
        public List<TeacherDto> Teachers { get; set; }
    }
}
