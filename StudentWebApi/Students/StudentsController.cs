using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Students;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers;

namespace StudentWebApi.Students
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        //StudentService studentService = new StudentService();
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("Get")]
        public ActionResult<List<Student>> Get()
        {
            return _studentService.GetAll();

        }
        [HttpGet("GetById")]
        public Student GetById(int id)
        {
           return _studentService.GetById(id);
        }
        [HttpPost("Create")]
        public void Create(Student student)
        {
            _studentService.Create(student);
        }
        [HttpPut("Update")]
        public void Update(int studentId, Student updatedStudent)
        {
            _studentService.Update(studentId, updatedStudent);
        }
        [HttpDelete("Delete")]
        public void Delete(int studentId)
        {
            _studentService.Delete(studentId);
        }
    }
}
