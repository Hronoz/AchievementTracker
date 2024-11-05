using AchievementTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace AchievementTracker.Data;

public class AchievementTrackerDbContext : DbContext
{
    public AchievementTrackerDbContext(DbContextOptions<AchievementTrackerDbContext> options)
        : base(options) { }

    public DbSet<Achievement> Achievements { get; set; }
}
