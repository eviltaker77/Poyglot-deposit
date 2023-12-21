var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

//var port = Environment.GetEnvironmentVariable("PORT")??"8080";

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "GET - Net 6 Running ... 15092023-v1.0.0 CI/CD in AKS v1.0.0 POLYGLOT";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST - Net 6 Running ...15092023-v1.0.0 CI/CD in AKS v1.0.0 POLYGLOT";
});

//app.Run($"http://0.0.0.0:{port}");
app.Run();
