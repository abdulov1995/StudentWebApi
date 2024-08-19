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
            context.TeacherStudents.Add(teacherStudent);
            context.SaveChanges();
        }
        public List<TeacherStudent> GetTeacherStudents()
        {
            return context.TeacherStudents.Include(ts => ts.Teacher)
                  .Include(ts => ts.Student)
                  .ToList();
        }
        public List<TeacherStudent> GetTeacherStudentsById(int teacherId)
        {
            return context.TeacherStudents.Include(ts => ts.Teacher)
               .Include(ts => ts.Student)
               .Where(ts => ts.TeacherId == teacherId)
               .ToList();
        }
        public void Delete(int teacherId = 0, int studentId = 0)
        {
            if (teacherId != 0 && studentId == 0)
            {
                TeacherService teacherService = new TeacherService();
                var teacherStudent = context.TeacherStudents.FirstOrDefault(ts => ts.TeacherId == teacherId);
                var teacher = context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                context.TeacherStudents.Remove(teacherStudent);
                context.Teachers.Remove(teacher);
            }
            else if (teacherId == 0 && studentId != 0)
            {
                var teacherStudent = context.TeacherStudents.FirstOrDefault(ts => ts.StudentId == studentId);
                var student = context.Students.FirstOrDefault(s => s.Id == studentId);
                context.Students.Remove(student);
                context.TeacherStudents.Remove(teacherStudent);
            }
            else if (teacherId != 0 && studentId != 0)
            {
                var teacherStudent = context.TeacherStudents.FirstOrDefault(ts => ts.TeacherId == teacherId && ts.StudentId == studentId);
                var student = context.Students.FirstOrDefault(s => s.Id == studentId);
                var teacher = context.Teachers.FirstOrDefault(t => t.Id == teacherId);
                context.TeacherStudents.Remove(teacherStudent);
                context.Students.Remove(student);
                context.Teachers.Remove(teacher);
            }
            context.SaveChanges();
        }
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent)
        {
            var newInput = context.TeacherStudents.Include(ts => ts.Teacher)
                                                 .Include(ts => ts.Student)
                                                 .FirstOrDefault(ts => ts.TeacherId == teacherId && ts.StudentId == studentId);
            newInput.Teacher.Name = teacherStudent.Teacher.Name;
            newInput.Teacher.Subject = teacherStudent.Teacher.Subject;
            newInput.Student.Name = teacherStudent.Student.Name;
            newInput.Student.Age = teacherStudent.Student.Age;

            context.TeacherStudents.Update(newInput);
            context.SaveChanges();
        }
    }
}
