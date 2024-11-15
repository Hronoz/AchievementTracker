using AchievementTracker.Domain;
using Microsoft.EntityFrameworkCore;

namespace AchievementTracker.Infrastructure;

public class AchievementRepository : IAchievementRepository
{
    private readonly AchievementTrackerDbContext _context;

    public AchievementRepository(AchievementTrackerDbContext context)
    {
        _context = context;
    }

    public async Task<List<Achievement>> GetAllAchievementsAsync()
    {
        return await _context.Achievements.ToListAsync();
    }

    public async Task<Achievement> GetAchievementByIdAsync(int id)
    {
        return await _context.Achievements.FindAsync(id);
    }

    public async Task CreateAchievementAsync(Achievement achievement)
    {
        _context.Achievements.Add(achievement);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAchievementAsync(int id, Achievement achievement)
    {
        _context.Entry(achievement).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAchievementAsync(int id)
    {
        var achievement = await _context.Achievements.FindAsync(id);
        _context.Achievements.Remove(achievement);
        await _context.SaveChangesAsync();
    }
}
