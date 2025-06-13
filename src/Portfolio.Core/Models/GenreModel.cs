using System.ComponentModel.DataAnnotations;
using Portfolio.Core.Interfaces;

namespace Portfolio.Core.Models;

public class GenreModel : IHasGuid
{
    #region Properties
    [Key]
    public Guid Guid { get; set; }
    [Required]
    [StringLength(20)]
    public required string Name
    {
        get; set;
    }
    #endregion
    public GenreModel()
    {
    }
}
