using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController:Controller
    {
        private readonly ITeacherService _teacherService;
        //TeacherService teacherService=new TeacherService();
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        //[HttpGet("Get")]
        //public ActionResult<List<Teacher>> Get()
        //{
        //    return _teacherService.GetAll();
        //}

        //[HttpGet("GetById")]
        //public Teacher GetById(int id)
        //{
        //    return _teacherService.GetById(id);
        //}
        //[HttpPost("Create")]
        //public void Create(Teacher teacher)
        //{
        //    _teacherService.Create(teacher);
        //}
        //[HttpPut("Update")]
        //public void Update(int teacherId, Teacher updatedTeacher)
        //{
        //    _teacherService.Update(teacherId, updatedTeacher);
        //}
        //[HttpDelete("Delete")]
        //public void Delete(int teacherId)
        //{
        //    _teacherService.Delete(teacherId);
        //}
    }
}
