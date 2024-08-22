using StudentWebApi.Students;
using StudentWebApi.Students.Models;


namespace StudentWebApi
{
    public interface IStudentService
    {
        public Student GetById(int studentId);
        public List<Student> GetAll();
        public void Create(Student student);
        public void Update(int id, Student updatedStudent);
        public void Delete(int studentId);
    }
    
}
