using System.ComponentModel.DataAnnotations;
using StudentWebApi.Students.Models;
namespace StudentWebApi.Teachers.Models;

public class Teacher
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Subject { get; set; }
    public List<Student> Students { get; set; }
    //public List<TeacherStudent> TeacherStudents { get; set; }
}

