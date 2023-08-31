using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using StudentAPI.Services;
using StudentAPI.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<StudentDatabaseSettings>(
      builder.Configuration.GetSection(nameof(StudentDatabaseSettings)));
builder.Services.AddSingleton<IStudentDatabaseSettings>(provider =>
    provider.GetRequiredService<IOptions<StudentDatabaseSettings>>().Value);
builder.Services.AddControllers();
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<CourseService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
