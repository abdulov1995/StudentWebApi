using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentWebApi;
using StudentWebApi.Student;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var connectionString = builder.Configuration.GetConnectionString("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=StudentDB");
builder.Services.AddDbContext<DbContext>(options =>
    options.UseNpgsql(connectionString, b => b.MigrationsAssembly("StudentWebApi")));


builder.Services.AddSwaggerGen();

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
