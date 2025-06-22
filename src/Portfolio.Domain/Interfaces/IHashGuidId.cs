namespace Portfolio.Domain.Interfaces;

/// <summary>
/// Interface for entities that use a GUID as their unique identifier.
/// Implementing this interface ensures the entity has a GUID-based ID property.
/// </summary>
public interface IHashGuidId
{
    /// <summary>
    /// Gets the unique identifier for this entity.
    /// </summary>
    public Guid Id { get; }
}
