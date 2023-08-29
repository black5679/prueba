using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using LibeyTechnicalTest.Backend.Infrastructure.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using LibeyTechnicalTest.Backend.Application.Extensions;
using LibeyTechnicalTest.Backend.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("localCors",
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILibeyUserRepository, LibeyUserRepository>();
builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibeyTechnicalTest"),
    sqlServerOptionsAction: builder =>
    {
        builder.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.Run();
