using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentWebApi;
using StudentWebApi.Students;
using StudentWebApi.Teachers;
using AutoMapper;
using FluentValidation.AspNetCore;
using StudentWebApi.Students.DTO;
using StudentWebApi.Teachers.DTO;


//using StudentWebApi.TeacherStudents;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddAutoMapper(typeof(StudentMapper).Assembly );
builder.Services.AddControllers().AddFluentValidation(fv =>
                fv.RegisterValidatorsFromAssemblyContaining<CreateStudentDto>());
builder.Services.AddControllers().AddFluentValidation(fv =>
                fv.RegisterValidatorsFromAssemblyContaining<CreateTeacherDto>());

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

