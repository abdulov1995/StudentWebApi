using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Teachers;

namespace StudentWebApi.TeacherStudents
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherStudentController : Controller
    {
        private readonly ITeacherStudentService _teacherStudentService;
        //TeacherStudentService teacherStudentService = new TeacherStudentService();
        public TeacherStudentController(ITeacherStudentService teacherStudentService)
        {
            _teacherStudentService = teacherStudentService;
        }
        [HttpGet("Get")]
        public void Get()
        {
            _teacherStudentService.GetTeacherStudents();
        }
        [HttpGet("GetById")]
        public void GetById(int Id)
        {
            _teacherStudentService.GetTeacherStudentsById(Id);   
        }
        [HttpPost("Create")]
        public void Create(TeacherStudent teacherStudent)
        {
            _teacherStudentService.Create(teacherStudent);
        }
        [HttpPut("Update")]
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent)
        {
            _teacherStudentService.Update(teacherId,studentId, teacherStudent);
        }
        [HttpDelete("Delete")]
        public void Delete(int teacherId = 0, int studentId = 0)
        {
            _teacherStudentService.Delete(studentId,studentId);
        }

    }
}
