var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.MapGet("/", () => "Hello Worlddd!");
app.MapGet("/ahmet", () => "BELER Worlddd!");

app.Run();
