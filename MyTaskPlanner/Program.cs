using Microsoft.EntityFrameworkCore;
using MyTaskPlanner.Entity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyTaskPlannerContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyTaskPlannerConnectionString"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
