// Portfolio.Application.Models/Dtos/ContactInfoDto.cs
namespace Portfolio.Application.Models.Dtos
{
    public class ContactInfoDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = default!;
        public string Value { get; set; } = default!;
    }

    public class CreateContactInfoDto
    {
        public string Type { get; set; } = default!;
        public string Value { get; set; } = default!;
    }

    public class UpdateContactInfoDto
    {
        public string Type { get; set; } = default!;
        public string Value { get; set; } = default!;
    }
}
