var builder = WebApplication.CreateBuilder(args);

// Add services to the container

var app = builder.Build();

// Configurwe the HTTP request pipeline

app.Run();
