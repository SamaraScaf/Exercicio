using ExercicioDaSemana09.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = "Server=DESKTOP-BG93S41\\SQLEXPRESS02;Database=Semana;Trusted_Connection=True;TrustServerCertificate=True;";
//Inje��o de Depencencia do Context
builder.Services.AddDbContext<SemanaContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddDbContext<SemanaContext>();

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