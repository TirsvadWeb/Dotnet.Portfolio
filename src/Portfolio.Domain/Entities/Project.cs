using Portfolio.Domain.ValueObjects;

namespace Portfolio.Domain.Entities
{
    /// <summary>
    /// Represents a project entity in the portfolio domain.
    /// </summary>
    public class Project : BaseEntity
    {
        /// <summary>
        /// Gets the title of the project.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the description of the project.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the creation date and time of the project.
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets the identifier of the person who owns the project.
        /// </summary>
        public Guid PersonId { get; private set; }

        /// <summary>
        /// Gets the author of the project.
        /// </summary>
        public Person Author { get; private set; }

        private readonly List<Tag> _tags = new();

        /// <summary>
        /// Gets the collection of tags associated with the project.
        /// </summary>
        public IReadOnlyCollection<Tag> Tags => _tags;

        /// <summary>
        /// Gets the live URL of the project, if available.
        /// </summary>
        public UriString? LiveUrl { get; private set; }

        /// <summary>
        /// Gets the repository URL of the project, if available.
        /// </summary>
        public UriString? RepoUrl { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        public Project()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class with the specified details.
        /// </summary>
        /// <param name="title">The title of the project.</param>
        /// <param name="description">The description of the project.</param>
        /// <param name="personId">The identifier of the person who owns the project.</param>
        /// <param name="author">The author of the project.</param>
        /// <param name="liveUrl">The live URL of the project (optional).</param>
        /// <param name="repoUrl">The repository URL of the project (optional).</param>
        /// <exception cref="ArgumentNullException">Thrown if title, description, or author is null.</exception>
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

        /// <summary>
        /// Updates the title and description of the project.
        /// </summary>
        /// <param name="title">The new title of the project.</param>
        /// <param name="description">The new description of the project.</param>
        /// <exception cref="ArgumentNullException">Thrown if title or description is null or whitespace.</exception>
        public void UpdateDetails(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentNullException(nameof(description));
            Title = title;
            Description = description;
        }

        /// <summary>
        /// Sets the live URL of the project.
        /// </summary>
        /// <param name="url">The live URL to set, or null to clear.</param>
        public void SetLiveUrl(string? url)
        {
            LiveUrl = string.IsNullOrWhiteSpace(url) ? null : new UriString(url);
        }

        /// <summary>
        /// Sets the repository URL of the project.
        /// </summary>
        /// <param name="url">The repository URL to set, or null to clear.</param>
        public void SetRepoUrl(string? url)
        {
            RepoUrl = string.IsNullOrWhiteSpace(url) ? null : new UriString(url);
        }

        /// <summary>
        /// Adds a tag to the project if it is not already present.
        /// </summary>
        /// <param name="tag">The tag to add.</param>
        /// <exception cref="ArgumentNullException">Thrown if tag is null.</exception>
        public void AddTag(Tag tag)
        {
            if (tag == null) throw new ArgumentNullException(nameof(tag));
            if (!_tags.Contains(tag))
                _tags.Add(tag);
        }

        /// <summary>
        /// Removes a tag from the project if it exists.
        /// </summary>
        /// <param name="tag">The tag to remove.</param>
        /// <exception cref="ArgumentNullException">Thrown if tag is null.</exception>
        public void RemoveTag(Tag tag)
        {
            if (tag == null) throw new ArgumentNullException(nameof(tag));
            _tags.Remove(tag);
        }
    }
}
