using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Teachers;

namespace StudentWebApi.TeacherStudents
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherStudentController : Controller
    {
        private readonly ITeacherStudentService teacherStudentService;
        //TeacherStudentService teacherStudentService = new TeacherStudentService();
        [HttpGet("Get")]
        public void Get()
        {
            teacherStudentService.GetTeacherStudents();
        }
        [HttpGet("GetById")]
        public void GetById(int Id)
        {
            teacherStudentService.GetTeacherStudentsById(Id);   
        }
        [HttpPost("Create")]
        public void Create(TeacherStudent teacherStudent)
        {
            teacherStudentService.Create(teacherStudent);
        }
        [HttpPut("Update")]
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent)
        {
            teacherStudentService.Update(teacherId,studentId, teacherStudent);
        }
        [HttpDelete("Delete")]
        public void Delete(int teacherId = 0, int studentId = 0)
        {
            teacherStudentService.Delete(studentId,studentId);
        }

    }
}
