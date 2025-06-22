// Portfolio.Application.Models/Dtos/SkillDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class SkillDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Level { get; set; } = default!;
    }

    public class CreateSkillDto
    {
        public string Name { get; set; } = default!;
        public string Level { get; set; } = default!;
    }

    public class UpdateSkillDto
    {
        public string Level { get; set; } = default!;
    }
}
