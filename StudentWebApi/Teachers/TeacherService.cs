using Microsoft.EntityFrameworkCore;

namespace StudentWebApi.Teachers
{
    public class TeacherService:ITeacherService
    {
        private readonly AppDbContext _context;

        public TeacherService(AppDbContext context)
        {
            _context = context;
        }
        public Teacher GetById(int teacherId)
        {
            var teacher = _context.Teachers.Include(t => t.TeacherStudents).FirstOrDefault(s => s.Id == teacherId);
            return teacher;
        }
        public List<Teacher> GetAll()
        {
            var teachers = _context.Teachers.Include(t => t.TeacherStudents).ToList();
            return teachers;
        }
        public void Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }
        public void Update(int id, Teacher updatedTeacher)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
            teacher.Name = updatedTeacher.Name;
            teacher.Subject = updatedTeacher.Subject;

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
