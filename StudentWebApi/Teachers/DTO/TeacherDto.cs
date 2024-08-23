﻿using System.ComponentModel.DataAnnotations;

namespace StudentWebApi.Teachers.DTO
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}
