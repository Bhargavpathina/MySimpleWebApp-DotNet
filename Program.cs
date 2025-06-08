var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Azure DevOps DotNet App from GitHub!");

app.Run();
