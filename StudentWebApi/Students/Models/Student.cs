using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Students.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public List<TeacherStudent> TeacherStudents { get; set; }
    }
}
