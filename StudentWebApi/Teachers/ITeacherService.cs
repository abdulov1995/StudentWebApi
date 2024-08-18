namespace StudentWebApi.Teachers
{
    public interface ITeacherService
    {
        Teacher GetById(int teacherId);
        List<Teacher> GetAll();
        void Create(Teacher teacher);
        void Update(int id, Teacher updatedTeacher);
        void Delete(int teacherId);
    }
}
