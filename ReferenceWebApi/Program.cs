using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReferenceWebApi.Data;
using ReferenceWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("AzureSqlConnection");
builder.Services.AddDbContext<DataContext>(Options => Options.UseSqlServer(connectionString));
builder.Services.AddTransient<ICourseRepo, CourseRepo>();
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
