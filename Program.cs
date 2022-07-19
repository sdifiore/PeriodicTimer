using PeriodicTimerStudy;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<RepeatingService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
