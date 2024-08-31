using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentWebApi.Students;
using StudentWebApi.Students.DTO;
using StudentWebApi.Students.Models;

namespace StudentWebApi
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        

        public StudentService(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public StudentDto GetById(int studentId)
        {
            var studentDto= _context.Students.Where(s=>s.Id==studentId).FirstOrDefault();
            return _mapper.Map<StudentDto>(studentDto);
             
        }
        public List<StudentDetailDto> GetAll()
        {

            var students=_context.Students.Include(s=>s.Teachers)
                .ToList();
            var studentDetailDto=_mapper.Map<List<StudentDetailDto>>(students);
            return studentDetailDto;
            
        }
        public void Create(CreateStudentDto createStudentDto)
        {
            var student=_mapper.Map<Student>(createStudentDto); 
           _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Update(int id, UpdateStudentDto updatedStudent)
        {
            var student = _context.Students.Find(id);    
            _mapper.Map(updatedStudent, student);
            _context.Students.Update(student);
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
