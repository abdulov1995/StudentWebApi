using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students;

namespace StudentWebApi
{
    public class StudentService:IStudentService
    {
        private readonly AppDbContext _context;
        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public Student GetById(int studentId)
        {
            var student = context.Students.Include(s => s.TeacherStudents).FirstOrDefault(s => s.Id == studentId);
            return student;
        }
        public List<Student> GetAll()
        {
            var students = context.Students.Include(s => s.TeacherStudents).ToList();
            return students;
        }
        public void Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void Update(int id, Student updatedStudent)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            context.Students.Update(student);
            context.SaveChanges();
        }
        public void Delete(int studentId)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
