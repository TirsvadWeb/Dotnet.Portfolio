namespace Portfolio.Domain.Entities;

/// <summary>
/// A skill or technology the person is proficient in.
/// </summary>
public class Skill : BaseEntity
{
    /// <summary>
    /// Gets the name of the skill or technology.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the proficiency level for this skill.
    /// </summary>
    public SkillLevel Level { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Skill"/> class.
    /// </summary>
    /// <param name="name">The name of the skill or technology.</param>
    /// <param name="level">The proficiency level for this skill.</param>
    public Skill(string name, SkillLevel level)
    {
        Name = name;
        Level = level;
    }

    /// <summary>
    /// Updates the proficiency level for this skill.
    /// </summary>
    /// <param name="newLevel">The new proficiency level.</param>
    public void UpdateLevel(SkillLevel newLevel) => Level = newLevel;
}

/// <summary>
/// Represents the proficiency level for a skill.
/// </summary>
public enum SkillLevel
{
    /// <summary>
    /// Beginner level.
    /// </summary>
    Beginner,
    /// <summary>
    /// Intermediate level.
    /// </summary>
    Intermediate,
    /// <summary>
    /// Advanced level.
    /// </summary>
    Advanced,
    /// <summary>
    /// Expert level.
    /// </summary>
    Expert
}
