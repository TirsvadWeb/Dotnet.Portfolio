// Domain/Entities/Project.cs
using Portfolio.Domain.ValueObjects;

namespace Portfolio.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Guid PersonId { get; private set; }
        public Person Author { get; private set; }

        private readonly List<Tag> _tags = new();
        public IReadOnlyCollection<Tag> Tags => _tags;

        public UriString? LiveUrl { get; private set; }
        public UriString? RepoUrl { get; private set; }

        public Project()
        {

        }

        public Project(
            string title,
            string description,
            Guid personId,
            Person author,
            string? liveUrl = null,
            string? repoUrl = null)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CreatedAt = DateTime.UtcNow;
            PersonId = personId;
            Author = author ?? throw new ArgumentNullException(nameof(author));
            if (liveUrl is not null) LiveUrl = new UriString(liveUrl);
            if (repoUrl is not null) RepoUrl = new UriString(repoUrl);
        }

        public void UpdateDetails(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description));
            Title = title;
            Description = description;
        }

        public void SetLiveUrl(string? url)
        {
            LiveUrl = string.IsNullOrWhiteSpace(url) ? null : new UriString(url);
        }

        public void SetRepoUrl(string? url)
        {
            RepoUrl = string.IsNullOrWhiteSpace(url) ? null : new UriString(url);
        }

        public void AddTag(Tag tag)
        {
            if (tag == null) throw new ArgumentNullException(nameof(tag));
            if (!_tags.Contains(tag))
                _tags.Add(tag);
        }

        public void RemoveTag(Tag tag)
        {
            if (tag == null) throw new ArgumentNullException(nameof(tag));
            _tags.Remove(tag);
        }
    }
}
