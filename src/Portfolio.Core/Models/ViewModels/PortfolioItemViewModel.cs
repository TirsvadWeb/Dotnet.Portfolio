namespace Portfolio.Core.Models.ViewModels;

public class PortfolioItemViewModel : PortfolioItem
{
    public IEnumerable<string> GenreTagAsName { get; set; }

    public PortfolioItemViewModel() : base()
    {
        GenreTagAsName = [];
    }
}
