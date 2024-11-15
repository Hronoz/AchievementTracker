using AchievementTracker.Domain;

namespace AchievementTracker.Infrastructure;

public interface IAchievementRepository
{
    Task<List<Achievement>> GetAllAchievementsAsync();
    Task<Achievement> GetAchievementByIdAsync(int id);
    Task CreateAchievementAsync(Achievement achievement);
    Task UpdateAchievementAsync(int id, Achievement achievement);
    Task DeleteAchievementAsync(int id);
}
