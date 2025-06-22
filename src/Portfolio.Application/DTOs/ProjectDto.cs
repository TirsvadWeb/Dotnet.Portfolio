// Portfolio.Application.Models/Dtos/ProjectDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class ProjectDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public Guid PersonId { get; set; }
        public List<string> Tags { get; set; } = new();
        public string? LiveUrl { get; set; }
        public string? RepoUrl { get; set; }
    }

    public class CreateProjectDto
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public Guid PersonId { get; set; }
        public List<string> Tags { get; set; } = new();
        public string? LiveUrl { get; set; }
        public string? RepoUrl { get; set; }
    }

    public class UpdateProjectDto
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public List<string> Tags { get; set; } = new();
        public string? LiveUrl { get; set; }
        public string? RepoUrl { get; set; }
    }
}
