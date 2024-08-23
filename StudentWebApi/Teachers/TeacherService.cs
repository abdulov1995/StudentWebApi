using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Teachers.DTO;
using StudentWebApi.Teachers.Models;

namespace StudentWebApi.Teachers
{
    //public class TeacherService:ITeacherService
    //{
    //    //private readonly AppDbContext _context;
    //    private readonly IMapper _mapper;
    //    public TeacherService(IMapper mapper)
    //    {
    //        _mapper = mapper;
    //    }
    //    //public TeacherService(AppDbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    public TeacherDto GetById(int teacherId)
    //    {
    //        var teacher = _context.Teachers.Include(s => s.Name).FirstOrDefault(t =>t.Id == teacherId);
    //        return teacher;
    //    }
    //    public List<TeacherDetailDto> GetAll()
    //    {
    //        var teachers = _context.TeachersDetailDto.Include(s => s.Students).ToList();
    //        return teachers;
    //    }
    //    public void Create(Teacher teacher)
    //    {
    //        _context.Teachers.Add(teacher);
    //        _context.SaveChanges();
    //    }
    //    public void Update(int id, Teacher updatedTeacher)
    //    {
    //        var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
    //        teacher.Name = updatedTeacher.Name;
    //        teacher.Subject = updatedTeacher.Subject;

    //        _context.Teachers.Update(teacher);
    //        _context.SaveChanges();
    //    }
    //    public void Delete(int teacherId)
    //    {
    //        var teacher = _context.Teachers.FirstOrDefault(t => t.Id == teacherId);
    //        _context.Teachers.Remove(teacher);
    //        _context.SaveChanges();
    //    }
    //}
}
