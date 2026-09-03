using Microsoft.EntityFrameworkCore;
using OppgaveUkeEnModul3.Core;
using OppgaveUkeEnModul3.Core.Interfaces;
using OppgaveUkeEnModul3.Core.Services;
using OppgaveUkeEnModul3.WebApi.Services;
using OppgaveUkeEnModul3.WebApi.DatabaseContext;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddControllers();


builder.Services.AddScoped<LevelCalculator>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapControllers();

app.Run();


