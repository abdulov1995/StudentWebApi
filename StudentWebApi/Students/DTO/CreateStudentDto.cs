using StudentWebApi.Teachers.DTO;

namespace StudentWebApi.Students.DTO
{
    public class CreateStudentDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> TeacherIds { get; set; }
    }
}
