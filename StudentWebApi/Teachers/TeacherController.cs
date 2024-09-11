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
        public void Create(CreateTeacherDto teacher)
        {
            _teacherService.Create(teacher);
        }
        [HttpPut("{id}")]
        public void Update(int teacherId, Teacher updatedTeacher)
        {
            _teacherService.Update(teacherId, updatedTeacher);
        }
        [HttpDelete("{id}")]
        public void Delete(int teacherId)
        {
            _teacherService.Delete(teacherId);
        }
    }
}
