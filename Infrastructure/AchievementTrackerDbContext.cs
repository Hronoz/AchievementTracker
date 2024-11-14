using AchievementTracker.Domain;
using Microsoft.EntityFrameworkCore;

namespace AchievementTracker.Infrastructure;

public class AchievementTrackerDbContext : DbContext
{
    public AchievementTrackerDbContext(DbContextOptions<AchievementTrackerDbContext> options)
        : base(options) { }

    public DbSet<Achievement> Achievements { get; set; }
}
