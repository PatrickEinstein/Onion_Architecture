var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Central Authentication",
        Version = "v1",
        Description = "API for central authentication"
    });
});

var app = builder.Build();

// Enable middleware
app.UseSwagger();
app.UseSwaggerUI(o =>
{
    o.SwaggerEndpoint("/swagger/v1/swagger.json", "Auth V1");
    o.RoutePrefix = string.Empty; // Swagger UI at root
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
