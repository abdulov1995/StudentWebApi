using System.ComponentModel.DataAnnotations;

namespace StudentWebApi;

    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }

        public List<TeacherStudent> TeacherStudents { get; set; }
    }

