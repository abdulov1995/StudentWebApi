﻿using Microsoft.AspNetCore.Mvc;

namespace StudentWebApi.Teachers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController:Controller
    {
        private readonly ITeacherService _teacherService;
        //TeacherService teacherService=new TeacherService();
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet("Get")]
        public void Get()
        {
            teacherService.GetAll();
        }

        [HttpGet("GetById")]
        public void Get(int id)
        {
            teacherService.GetById(id);
        }
        [HttpPost("Create")]
        public void Create(Teacher teacher)
        {
            teacherService.Create(teacher);
        }
        [HttpPut("Update")]
        public void Update(int teacherId, Teacher updatedTeacher)
        {
            teacherService.Update(teacherId, updatedTeacher);
        }
        [HttpDelete("Delete")]
        public void Delete(int teacherId)
        {
            teacherService.Delete(teacherId);
        }
    }
}
