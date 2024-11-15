namespace AchievementTracker.Domain;

public class Achievement
{
    /// <summary>
    /// The id of the achievement
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The type of the achievement
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// The amount of points associated with the achievement
    /// </summary>
    public int Points { get; set; }

    /// <summary>
    /// The title of the achievement
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The description of the achievement
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Whether or not the achievement has been completed
    /// </summary>
    public bool Completed { get; set; }

    /// <summary>
    /// Timestamp for last update
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
