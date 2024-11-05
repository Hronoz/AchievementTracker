namespace AchievementTracker.Models;

public class Achievement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }
}
