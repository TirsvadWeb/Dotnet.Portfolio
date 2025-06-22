// Portfolio.Application.Models/Dtos/PersonDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class PersonDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default!;
        public string Bio { get; set; } = default!;
        public string ProfileImage { get; set; } = default!;
        public string SocialBannerImage { get; set; } = default!;

        // Project summaries associated with this person
        public List<ProjectDto> Projects { get; set; } = new();
    }

    public class CreatePersonDto
    {
        public string FullName { get; set; } = default!;
        public string Bio { get; set; } = default!;
        public string ProfileImage { get; set; } = default!;
        public string SocialBannerImage { get; set; } = default!;
    }

    public class UpdatePersonDto
    {
        public string FullName { get; set; } = default!;
        public string Bio { get; set; } = default!;
    }
}
