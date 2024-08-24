using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;

namespace StudentWebApi
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;
        public StudentService(IMapper mapper,IStudentService studentService)
        {
            _mapper = mapper;
            _studentService=studentService;
        }

        public StudentDto GetById(int studentId)
        {
            var studentDto=studentService.GetById(studentId);
            var student = _mapper.Map<Student>(studentDto);
            return student;
        }
        public List<StudentDetailDto> GetAll()
        {
            var students=_mapper.Map<Student>
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
