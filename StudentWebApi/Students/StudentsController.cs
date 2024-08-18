using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Students;
using StudentWebApi.Teachers;

namespace StudentWebApi.Students
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        //StudentService studentService = new StudentService();

        [HttpGet("Get")]
        public void Get()
        {
            studentService.GetAll();
        }
        [HttpGet("GetById")]
        public void Get(int id)
        {
            studentService.GetById(id);
        }
        [HttpPost("Create")]
        public void Create(Student student)
        {
            studentService.Create(student);
        }
        [HttpPut("Update")]
        public void Update(int studentId, Student updatedStudent)
        {
            studentService.Update(studentId, updatedStudent);
        }
        [HttpDelete("Delete")]
        public void Delete(int studentId)
        {
            studentService.Delete(studentId);
        }
    }
}
