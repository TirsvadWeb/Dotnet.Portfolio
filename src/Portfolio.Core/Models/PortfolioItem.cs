using System.ComponentModel.DataAnnotations;
using Portfolio.Core.Interfaces;

namespace Portfolio.Core.Models;

public class PortfolioItem : IHasGuid
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Please enter name..")]
    [StringLength(50)]
    public string Name { get; set; }

    public string Description { get; set; }

    [StringLength(2048)]
    [RegularExpression(@"^https?:\/\/.+", ErrorMessage = "SourceLink must be a valid HTTP or HTTPS URL.")]
    public string SourceLink { get; set; }

    public IEnumerable<Guid> GenreTags { get; set; }

    public PortfolioItem()
    {
        Name = string.Empty;
        Description = string.Empty;
        SourceLink = string.Empty;
        GenreTags = [];
    }
}
