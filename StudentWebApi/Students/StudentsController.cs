using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers;

namespace StudentWebApi.Students
{
    [ApiController]
    [Route("api/[]")]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("Get")]
        public ActionResult<List<StudentDetailDto>> Get()
        {
            return _studentService.GetAll();
        }
        [HttpGet("GetById")]
        public  StudentDto GetById(int id)
        {
            _studentService.GetById(id);
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
