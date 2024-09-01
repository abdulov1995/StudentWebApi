using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;


namespace StudentWebApi
{
    public interface IStudentService
    {
        StudentDetailDto GetById(int studentId);
        List<StudentDto> GetAll();
        void Create(CreateStudentDto createStudentDto);
        void Update(int id, UpdateStudentDto updatedStudent);
        void Delete(int studentId);
    }

}
