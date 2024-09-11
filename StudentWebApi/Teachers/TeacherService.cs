using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    public class TeacherService : ITeacherService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public TeacherService(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public TeacherDetailDto GetById(int teacherId)
        {
            var teacher = _context.Teachers.Include(s => s.Students).FirstOrDefault(t => t.Id == teacherId);
            return _mapper.Map<TeacherDetailDto>(teacher);
        }
        public List<TeacherDto> GetAll()
        {
            var teachers = _context.Teachers.Include(s => s.Students).ToList();
            return _mapper.Map<List<TeacherDto>>(teachers);
        }
        public void Create(CreateTeacherDto createTeacherDto)
        {
            var teacher = _mapper.Map<Teacher>(createTeacherDto);
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            var studentTeachers = new List<TeacherStudent>();

            foreach (var studentId in createTeacherDto.StudentIds)
            {
                var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
                if (student == null)
                {
                    throw new ArgumentException($"Student with ID {studentId} does not exist.");
                }
                var studentTeacher = new TeacherStudent
                {
                    StudentId = studentId,
                    TeacherId = teacher.Id,
                };
                studentTeachers.Add(studentTeacher);
            }
            _context.TeacherStudents.AddRange(studentTeachers);
            _context.SaveChanges();
        }
        public void Update(int id, Teacher updatedTeacher)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
            _mapper.Map(updatedTeacher, teacher);
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
        }
        public void Delete(int teacherId)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }
    }
}
