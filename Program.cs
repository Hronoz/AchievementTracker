using AchievementTracker.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AchievementTrackerDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AchievementTrackerDb"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AchievementTracker API", Version = "v1" });
});

builder.Services.AddScoped<IAchievementRepository, AchievementRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AchievementTracker API v1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
