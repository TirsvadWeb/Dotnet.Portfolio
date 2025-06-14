using System.ComponentModel.DataAnnotations;
using Portfolio.Core.Interfaces;

namespace Portfolio.Core.Models;

public class Genre : IHasGuid
{
    #region Properties
    [Key]
    public Guid Guid { get; set; }
    [Required(ErrorMessage = "Please enter name..")]
    [StringLength(20)]
    public string Name { get; set; }
    #endregion
    public Genre()
    {
        Name = string.Empty;
    }
}
