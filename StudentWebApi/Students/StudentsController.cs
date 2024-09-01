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
        public ActionResult<List<StudentDto>> GetAll()
        {
            return _studentService.GetAll();    
        }
        [HttpGet("{id}")]
        public  StudentDetailDto GetById(int id)
        {
           return _studentService.GetById(id);
        }
        [HttpPost]
        public void Create(CreateStudentDto student)
        {
            _studentService.Create(student);
        }
        [HttpPut("{id}")]
        public void Update(int id, UpdateStudentDto updatedStudent)
        {
            _studentService.Update(id, updatedStudent);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}
