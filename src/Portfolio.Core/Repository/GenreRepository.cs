using Portfolio.Core.Models;

namespace Portfolio.Core.Repository;

public class GenreRepository : RepositoryBase<GenreModel>
{
    private static readonly Lazy<GenreRepository> _instance = new(() => new GenreRepository());

    public static GenreRepository Instance => _instance.Value;

    private GenreRepository() { }
}
