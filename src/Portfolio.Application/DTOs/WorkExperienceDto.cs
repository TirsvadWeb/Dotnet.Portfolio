// Portfolio.Application.Models/Dtos/WorkExperienceDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class WorkExperienceDto
    {
        public Guid Id { get; set; }
        public string Company { get; set; } = default!;
        public string Role { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Responsibilities { get; set; } = default!;
    }

    public class CreateWorkExperienceDto
    {
        public string Company { get; set; } = default!;
        public string Role { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Responsibilities { get; set; } = default!;
    }

    public class UpdateWorkExperienceDto
    {
        public string Role { get; set; } = default!;
        public DateTime? EndDate { get; set; }
        public string Responsibilities { get; set; } = default!;
    }
}
