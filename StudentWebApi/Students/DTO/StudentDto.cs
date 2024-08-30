using StudentWebApi.Teachers.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentWebApi.Students.DTO
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
