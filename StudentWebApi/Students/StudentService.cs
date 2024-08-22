using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students;
using StudentWebApi.Students.Models;

namespace StudentWebApi
{
    public class StudentService:IStudentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public StudentService(IMapper mapper)
        {
                _mapper = mapper;
        }
        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public Student GetById(int studentId)
        {
            var student = _context.Students.Include(s => s.TeacherStudents).FirstOrDefault(s => s.Id == studentId);
            return student;
        }
        public List<Student> GetAll()
        {
            var students = _context.Students.Include(s => s.TeacherStudents).ToList();
            return students;
        }
        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Update(int id, Student updatedStudent)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public void Delete(int studentId)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
