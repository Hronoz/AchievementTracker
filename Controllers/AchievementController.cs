using AchievementTracker.Data;
using AchievementTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace AchievementTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AchievementController : ControllerBase
{
    private readonly IAchievementRepository _achievementRepository;

    public AchievementController(IAchievementRepository achievementRepository)
    {
        _achievementRepository = achievementRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAchievements()
    {
        return Ok(await _achievementRepository.GetAllAchievementsAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAchievementById(int id)
    {
        return Ok(await _achievementRepository.GetAchievementByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAchievement(Achievement achievement)
    {
        await _achievementRepository.CreateAchievementAsync(achievement);
        return CreatedAtAction(
            nameof(GetAchievementById),
            new { id = achievement.Id },
            achievement
        );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAchievement(int id, Achievement achievement)
    {
        await _achievementRepository.UpdateAchievementAsync(id, achievement);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAchievement(int id)
    {
        await _achievementRepository.DeleteAchievementAsync(id);
        return Ok();
    }
}
