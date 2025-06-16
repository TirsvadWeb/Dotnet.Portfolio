namespace Portfolio.ViewModels;

public class PortfolioItem : Core.Models.PortfolioItem
{
    public IEnumerable<string> GenreTagAsName { get; set; }
    public PortfolioItem() : base()
    {
        GenreTagAsName = [];
    }
}
