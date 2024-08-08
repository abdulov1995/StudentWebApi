using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Student;

namespace StudentWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {

        StudentService studentService = new StudentService();

        [HttpGet("Get")]
        public void Get()
        {
            studentService.GetAllStudents();
        }
        [HttpPost("Create")]
        public void Create(Students student)
        {
            studentService.CreateStudent(student);
        }
        [HttpPut("Update")]
        public void Update(int studentId, Students updatedStudent)
        {
            studentService.UpdateStudent(studentId, updatedStudent);
        }
        [HttpDelete("Delete")]
        public void Delete(int studentId)
        {
            studentService.DeleteStudent(studentId);
        }
    }
}
