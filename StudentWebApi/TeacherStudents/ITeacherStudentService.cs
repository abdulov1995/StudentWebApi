namespace StudentWebApi.TeacherStudents
{
    public interface ITeacherStudentService
    {
        void Create(TeacherStudent teacherStudent);
        List<TeacherStudent> GetTeacherStudents();
        List<TeacherStudent> GetTeacherStudentsById(int teacherId);
        public void Delete(int teacherId = 0, int studentId = 0);
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent);
    }
}
