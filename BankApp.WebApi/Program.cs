using BankApp.Application;
using BankApp.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "BankApp API",
        Version = "v1",
        Description = "Banking Application API"
    });
});

// Application & Persistence Service Registrations
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
// Swagger'ı HTTPS redirect'ten önce ekle
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BankApp API V1");
    c.RoutePrefix = string.Empty; // Swagger UI'yi root'ta göster
    c.DisplayRequestDuration();
});

app.UseHttpsRedirection();

app.UseCustomExceptionMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
