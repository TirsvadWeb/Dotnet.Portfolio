using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents the base entity type with a unique identifier.
/// All domain entities should inherit from this class.
/// </summary>
public abstract class BaseEntity : IHashGuidId
{
    /// <summary>
    /// Gets or sets the unique identifier for this entity.
    /// This property is protected set to ensure ID immutability after creation.
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity"/> class.
    /// Automatically generates a new GUID for the <see cref="Id"/> property.
    /// </summary>
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
}
