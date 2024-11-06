using AchievementTracker.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AchievementTracker.Infrastructure;

public class AchievementTrackerDbContext : IdentityDbContext<ApplicationUser>
{
    public AchievementTrackerDbContext(DbContextOptions<AchievementTrackerDbContext> options)
        : base(options) { }

    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}
