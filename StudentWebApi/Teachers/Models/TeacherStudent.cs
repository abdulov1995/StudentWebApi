using StudentWebApi.Students.Models;
using StudentWebApi.Teachers;

namespace StudentWebApi.Teachers.Models
{
    public class TeacherStudent
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
    }
}
