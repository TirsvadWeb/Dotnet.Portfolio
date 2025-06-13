using Portfolio.Core.Models;
using Portfolio.Core.Repository;

namespace TestPortfolioCore;

[DoNotParallelize]
[TestClass]
public sealed class GenreRepositoryTests
{
    [TestInitialize]
    public void TestInitialize()
    {
        // Clear repository before each test if Items is accessible
        GenreRepository.Instance.Items.Clear();
    }


    [TestMethod]
    public async Task AddAsync_ShouldAddGenre()
    {
        var repo = GenreRepository.Instance;
        var genre = new GenreModel { Guid = Guid.NewGuid(), Name = "TestGenre" };

        await repo.AddAsync(genre);

        var result = await repo.GetAsync(genre.Guid);
        Assert.IsNotNull(result);
        Assert.AreEqual("TestGenre", result!.Name);
    }

    [TestMethod]
    public async Task GetAsync_ShouldReturnAllGenres()
    {
        var repo = GenreRepository.Instance;
        var genre1 = new GenreModel { Guid = Guid.NewGuid(), Name = "Genre1" };
        var genre2 = new GenreModel { Guid = Guid.NewGuid(), Name = "Genre2" };

        await repo.AddAsync(genre1);
        await repo.AddAsync(genre2);

        var allGenres = await repo.GetAsync();

        Assert.AreEqual(2, allGenres.Count);
        Assert.IsTrue(allGenres.Any(g => g.Name == "Genre1"));
        Assert.IsTrue(allGenres.Any(g => g.Name == "Genre2"));
    }

    [TestMethod]
    public async Task UpdateAsync_ShouldUpdateGenre()
    {
        var repo = GenreRepository.Instance;
        var genre = new GenreModel { Guid = Guid.NewGuid(), Name = "OldName" };
        await repo.AddAsync(genre);

        genre.Name = "NewName";
        await repo.UpdateAsync(genre);

        var updated = await repo.GetAsync(genre.Guid);
        Assert.IsNotNull(updated);
        Assert.AreEqual("NewName", updated!.Name);
    }

    [TestMethod]
    public async Task DeleteAsync_ShouldRemoveGenre()
    {
        var repo = GenreRepository.Instance;
        var genre = new GenreModel { Guid = Guid.NewGuid(), Name = "ToDelete" };
        await repo.AddAsync(genre);

        await repo.DeleteAsync(genre);

        var result = await repo.GetAsync(genre.Guid);
        Assert.IsNull(result);
    }
}
