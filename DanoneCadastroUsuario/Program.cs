using DanoneCadastroUsuario.Application.Interfaces;
using DanoneCadastroUsuario.Application.Services;
using DanoneCadastroUsuario.Infrastructure.Context;
using DanoneCadastroUsuario.Infrastructure.Interfaces;
using DanoneCadastroUsuario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDanoneUsuarioService, DanoneUsuarioService>();
builder.Services.AddScoped<IDanoneUsuarioRepository, DanoneUsuarioRepository>();

builder.Services.AddDbContext<DanoneCadastroUsuarioContext>(options =>
{
    options.UseSqlite("Data Source=C:\\Projetos\\JovemProgramador.db");
});

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

