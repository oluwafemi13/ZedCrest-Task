using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Zedcrest_Task.Data;
using Zedcrest_Task.Models;
using Zedcrest_Task.Repository;
using Zedcrest_Task.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(Mapper));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddIdentityCore<User>(q => q.User.RequireUniqueEmail = true);
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
