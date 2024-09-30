using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    [ApiController]
    [Route("api/teachers")]
    public class TeacherController:Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        public ActionResult<List<TeacherDto>> GetAll()
        {
            return _teacherService.GetAll();
        }
        [HttpGet("{id}")]
        public TeacherDetailDto GetById(int id)
        {
            return _teacherService.GetById(id);
        }
        [HttpPost]
        public IActionResult Create(CreateTeacherDto teacher)
        {
            if (!ModelState.IsValid)
            {
               return  BadRequest(ModelState);
            }
            _teacherService.Create(teacher);
            return Ok();
        }
        [HttpPut("{id}")]
        public void Update(int teacherId, UpdateTeacherDto updatedTeacherDto)
        {
            _teacherService.Update(teacherId, updatedTeacherDto);
        }
        [HttpDelete("{id}")]
        public void Delete(int teacherId)
        {
            _teacherService.Delete(teacherId);
        }
    }
}
