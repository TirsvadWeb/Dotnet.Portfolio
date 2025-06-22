using Portfolio.Domain.Interfaces;

namespace Portfolio.Domain.Entities;

/// <summary>
/// Represents the base entity type with a unique identifier.
/// All domain entities should inherit from this class.
/// </summary>
public abstract class BaseEntity : IHashGuidId
{
    public Guid Id { get; protected set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
}
