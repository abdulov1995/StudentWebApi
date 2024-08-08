namespace StudentWebApi.Student
{
    public class StudentService
    {
        AppDbContext context=new AppDbContext();
        public Students? GetStudentById(int studentId)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            return student;
        }
        public List<Students> GetAllStudents()
        {
            var student = context.Students.ToList();
            return student;
        }
        public void CreateStudent(Students student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void UpdateStudent(int studentId, Students updatedStudent)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            context.Students.Update(student);
            context.SaveChanges();
        }
        public void DeleteStudent(int studentId)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            context.Students.Remove(student);
            context.SaveChanges();

        }

    }
}
