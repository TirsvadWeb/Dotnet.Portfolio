namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents a tag entity for categorizing portfolio items.
/// </summary>
public class Tag : BaseEntity
{
    /// <summary>
    /// Gets the name of the tag.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Tag"/> class.
    /// </summary>
    /// <param name="name">The name of the tag.</param>
    public Tag(string name) => Name = name;
}
