// Portfolio.Application.Models/Dtos/TagDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class TagDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }

    public class CreateTagDto
    {
        public string Name { get; set; } = default!;
    }

    public class UpdateTagDto
    {
        public string Name { get; set; } = default!;
    }
}
