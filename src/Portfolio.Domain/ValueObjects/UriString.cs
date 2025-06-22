namespace Portfolio.Domain.ValueObjects
{
    public record UriString
    {
        public string Value { get; }
        public UriString(string uri)
        {
            if (!Uri.TryCreate(uri, UriKind.Absolute, out _))
                throw new ArgumentException("Invalid URI", nameof(uri));
            Value = uri;
        }
        public override string ToString() => Value;
    }
}
