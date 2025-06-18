using System.ComponentModel.DataAnnotations;
using Portfolio.Core.Interfaces;

namespace Portfolio.Core.Models;

public class Genre : IHasGuid
{
    #region Properties
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Please enter name..")]
    [StringLength(20, ErrorMessage = "Name must be 20 characters or less.")]
    public string Name { get; set; }
    #endregion
    public Genre()
    {
        Name = string.Empty;
    }
}
