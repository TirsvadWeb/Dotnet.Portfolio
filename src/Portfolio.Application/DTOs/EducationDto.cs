// Portfolio.Application.Models/Dtos/EducationDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class EducationDto
    {
        public Guid Id { get; set; }
        public string Institution { get; set; } = default!;
        public string Degree { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = default!;
    }

    public class CreateEducationDto
    {
        public string Institution { get; set; } = default!;
        public string Degree { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = default!;
    }

    public class UpdateEducationDto
    {
        public string Degree { get; set; } = default!;
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = default!;
    }
}
