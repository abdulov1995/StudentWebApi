using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public interface ITeacherService
    {
        TeacherDetailDto GetById(int teacherId);
        List<TeacherDto> GetAll();
        void Create(CreateTeacherDto createTeacherDto);
        void Update(int id, Teacher updatedTeacher);
        void Delete(int teacherId);
    }
}
