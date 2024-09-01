using StudentWebApi.Teachers.DTO;

namespace StudentWebApi.Students.DTO
{
    public class UpdateStudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<TeacherDto> Teachers { get; set; }
    }
}
