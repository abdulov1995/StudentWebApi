using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi

{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        
        public StudentService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public StudentDetailDto GetById(int studentId)
        {
            var student = _context.Students.Include(s => s.TeacherStudents).ThenInclude(t=>t.Teacher).FirstOrDefault(s => s.Id == studentId);
            return _mapper.Map<StudentDetailDto>(student);
        }
        public List<StudentDto> GetAll()
        {
            var students = _context.Students.Include(s => s.TeacherStudents).ThenInclude(t=>t.Teacher).ToList();
            return _mapper.Map<List<StudentDto>>(students);
        }
        public void Create(CreateStudentDto createStudentDto)
        {
            var student = _mapper.Map<Student>(createStudentDto);
            _context.Students.Add(student);
            _context.SaveChanges();
            var teacherStudents = new List<TeacherStudent>();
            foreach (var teacherId in createStudentDto.TeacherIds)
            {
                var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                if (teacher == null)
                {
                    throw new ArgumentException($"Teacher with ID {teacherId} does not exist.");
                }
                var teacherStudent = new TeacherStudent
                {
                    TeacherId = teacherId,
                    StudentId = student.Id
                };
                teacherStudents.Add(teacherStudent);

            }
            _context.TeacherStudents.AddRange(teacherStudents);
            _context.SaveChanges();
        }
        public void Update(int id, UpdateStudentDto updatedStudentDto)
        {
            var studentsIds = _context.Students.Include(s => s.TeacherStudents).ThenInclude(t => t.Teacher).Where(s=>s.Id==id).ToList();

            foreach (var studentId in studentsIds)
            {
                _context.Students.Remove(studentId);
            }
            var student = _mapper.Map<Student>(updatedStudentDto);
            _context.Students.Add(student);
            _context.SaveChanges();
            var teacherStudents = new List<TeacherStudent>();
            foreach (var teacherId in updatedStudentDto.TeacherIds)
            {
                var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                var teacherStudent = new TeacherStudent
                {
                    TeacherId = teacherId,
                    StudentId = student.Id
                };
                teacherStudents.Add(teacherStudent);
            }
            _context.TeacherStudents.AddRange(teacherStudents);
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
