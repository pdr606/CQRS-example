using Cars.Application.Outuput.Repositories.CarContext;
using Cars.Infrastructure.Repositories.CarContext;
using Cars.Infrastructure.IoC;
using cqrs.example.application.Input.Commands.CarContext;
using cqrs.example.application.Input.Handlers.CarContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddServices();

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
