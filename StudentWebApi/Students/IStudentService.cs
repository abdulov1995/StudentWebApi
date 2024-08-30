using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;


namespace StudentWebApi
{
    public interface IStudentService
    {
        StudentDto GetById(int studentId);
        List<StudentDetailDto> GetAll();
        void Create(Student student);
        void Update(int id, Student updatedStudent);
        void Delete(int studentId);
    }

}
