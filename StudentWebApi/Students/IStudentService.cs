using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;


namespace StudentWebApi
{
    public interface IStudentService
    {
        StudentDto GetById(int studentId);
        List<StudentDetailDto> GetAll();
        void Create(CreateStudentDto createStudentDto);
        void Update(int id, UpdateStudentDto updatedStudent);
        void Delete(int studentId);
    }

}
