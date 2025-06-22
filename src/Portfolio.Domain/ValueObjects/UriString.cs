namespace Portfolio.Domain.ValueObjects;

/// <summary>
/// Represents a strongly-typed absolute URI string value object.
/// </summary>
public record UriString
{
    /// <summary>
    /// Gets the absolute URI string value.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UriString"/> record.
    /// Throws an <see cref="ArgumentException"/> if the provided string is not a valid absolute URI.
    /// </summary>
    /// <param name="uri">The absolute URI string.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="uri"/> is not a valid absolute URI.</exception>
    public UriString(string uri)
    {
        if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
            throw new ArgumentException("Invalid URI", nameof(uri));
        Value = uri;
    }

    /// <summary>
    /// Returns the string representation of the URI.
    /// </summary>
    /// <returns>The absolute URI string.</returns>
    public override string ToString() => Value;
}
