using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core.Models;

public class DeveloperInfo
{
    public int ID { get; set; }

    [Required, StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Url, StringLength(2048)]
    public string? ProfileImageUrl { get; set; }

    [Url, StringLength(2048)]
    public string? SocialBannerUrl { get; set; }
}
