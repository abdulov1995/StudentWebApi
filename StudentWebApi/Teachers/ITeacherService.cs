using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public interface ITeacherService
    {
        TeacherDto GetById(int teacherId);
        List<TeacherDetailDto> GetAll();
        void Create(Teacher teacher);
        void Update(int id, Teacher updatedTeacher);
        void Delete(int teacherId);
    }
}
