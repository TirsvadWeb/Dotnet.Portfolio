using Portfolio.Core.Models;

namespace Portfolio.Core.Repository;

public class GenreRepository : RepositoryBase<Genre>
{
    private static readonly Lazy<GenreRepository> _instance = new(() => new GenreRepository());

    public static GenreRepository Instance => _instance.Value;

    private GenreRepository() { }

    public override Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
