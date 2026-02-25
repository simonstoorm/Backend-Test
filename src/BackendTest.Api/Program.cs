var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();