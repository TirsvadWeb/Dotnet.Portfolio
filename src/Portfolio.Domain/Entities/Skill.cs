// Domain/Entities/Skill.cs
namespace Portfolio.Domain.Entities;

/// <summary>
/// A skill or technology the person is proficient in.
/// </summary>
public class Skill : BaseEntity
{
    public string Name { get; private set; }
    public SkillLevel Level { get; private set; }

    public Skill(string name, SkillLevel level)
    {
        Name = name;
        Level = level;
    }

    public void UpdateLevel(SkillLevel newLevel) => Level = newLevel;
}

public enum SkillLevel
{
    Beginner,
    Intermediate,
    Advanced,
    Expert
}
