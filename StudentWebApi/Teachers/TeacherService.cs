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
            var teacher = context.Teachers.Include(t => t.TeacherStudents).FirstOrDefault(s => s.Id == teacherId);
            return teacher;
        }
        public List<Teacher> GetAll()
        {
            var teachers = context.Teachers.Include(t => t.TeacherStudents).ToList();
            return teachers;
        }
        public void Create(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
        }
        public void Update(int id, Teacher updatedTeacher)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.Id == id);
            teacher.Name = updatedTeacher.Name;
            teacher.Subject = updatedTeacher.Subject;

            context.Teachers.Update(teacher);
            context.SaveChanges();
        }
        public void Delete(int teacherId)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.Id == teacherId);
            context.Teachers.Remove(teacher);
            context.SaveChanges();
        }
    }
}
