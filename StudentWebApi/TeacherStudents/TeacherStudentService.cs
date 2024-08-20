using Microsoft.EntityFrameworkCore;
using StudentWebApi.Teachers;

namespace StudentWebApi.TeacherStudents
{
    public class TeacherStudentService:ITeacherStudentService
    {
        private readonly AppDbContext _context;
        public TeacherStudentService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(TeacherStudent teacherStudent)
        {
            _context.TeacherStudents.Add(teacherStudent);
            _context.SaveChanges();
        }
        public List<TeacherStudent> GetTeacherStudents()
        {
            return _context.TeacherStudents.Include(ts => ts.Teacher)
                  .Include(ts => ts.Student)
                  .ToList();
        }
        public List<TeacherStudent> GetTeacherStudentsById(int teacherId)
        {
            return _context.TeacherStudents.Include(ts => ts.Teacher)
               .Include(ts => ts.Student)
               .Where(ts => ts.TeacherId == teacherId)
               .ToList();
        }
        public void Delete(int teacherId = 0, int studentId = 0)
        {
            if (teacherId != 0 && studentId == 0)
            {
               // TeacherService teacherService = new TeacherService();
                var teacherStudent = _context.TeacherStudents.FirstOrDefault(ts => ts.TeacherId == teacherId);
                var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                _context.TeacherStudents.Remove(teacherStudent);
                _context.Teachers.Remove(teacher);
            }
            else if (teacherId == 0 && studentId != 0)
            {
                var teacherStudent = _context.TeacherStudents.FirstOrDefault(ts => ts.StudentId == studentId);
                var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
                _context.Students.Remove(student);
                _context.TeacherStudents.Remove(teacherStudent);
            }
            else if (teacherId != 0 && studentId != 0)
            {
                var teacherStudent = _context.TeacherStudents.FirstOrDefault(ts => ts.TeacherId == teacherId && ts.StudentId == studentId);
                var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
                var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                _context.TeacherStudents.Remove(teacherStudent);
                _context.Students.Remove(student);
                _context.Teachers.Remove(teacher);
            }
            _context.SaveChanges();
        }
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent)
        {
            var newInput = _context.TeacherStudents.Include(ts => ts.Teacher)
                                                 .Include(ts => ts.Student)
                                                 .FirstOrDefault(ts => ts.TeacherId == teacherId && ts.StudentId == studentId);
            newInput.Teacher.Name = teacherStudent.Teacher.Name;
            newInput.Teacher.Subject = teacherStudent.Teacher.Subject;
            newInput.Student.Name = teacherStudent.Student.Name;
            newInput.Student.Age = teacherStudent.Student.Age;

            _context.TeacherStudents.Update(newInput);
            _context.SaveChanges();
        }
    }
}
