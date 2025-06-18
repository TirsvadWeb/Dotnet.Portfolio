using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Models;
using Portfolio.Data;
using Portfolio.Repository;

namespace TestPortfolio;

//[DoNotParallelize]
[TestClass]
public sealed class GenreRepositoryTests
{
    private ApplicationDbContext _dbContext;
    private GenreRepository _repository;
    private SqliteConnection _connection;

    [TestInitialize]
    public void TestInitialize()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlite(_connection)
            .Options;

        _dbContext = new ApplicationDbContext(options);
        _dbContext.Database.EnsureCreated();
        _repository = new GenreRepository(_dbContext);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        _dbContext.Dispose();
        _connection.Dispose();
    }

    [TestMethod]
    public async Task AddAsync_AddsGenre()
    {
        var genre = new Genre { Id = Guid.NewGuid(), Name = "TestGenre" };
        var result = await _repository.AddAsync(genre);

        Assert.IsNotNull(result);
        Assert.AreEqual("TestGenre", result.Name);
        Assert.IsTrue(await _dbContext.Genre.AnyAsync(g => g.Id == genre.Id));
    }

    [TestMethod]
    public async Task GetAllAsync_ReturnsGenres()
    {
        await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "Genre1" });
        await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "Genre2" });

        var genres = await _repository.GetAllAsync();

        Assert.AreEqual(5, System.Linq.Enumerable.Count(genres));
    }

    [TestMethod]
    public async Task DeleteAsync_RemovesGenre()
    {
        var genre = await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "ToDelete" });
        var deleted = await _repository.DeleteAsync(genre.Id);

        Assert.IsTrue(deleted);
        Assert.IsFalse(await _dbContext.Genre.AnyAsync(g => g.Id == genre.Id));
    }

    [TestMethod]
    public async Task ExistsAsync_ReturnsTrueIfExists()
    {
        var genre = await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "Exists" });
        var exists = await _repository.ExistsAsync(genre.Id);

        Assert.IsTrue(exists);
    }

    [TestMethod]
    public async Task GetAsync_ReturnsGenre()
    {
        var genre = await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "GetMe" });
        var result = await _repository.GetAsync(genre.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual("GetMe", result.Name);
    }

    [TestMethod]
    public async Task UpdateAsync_UpdatesGenre()
    {
        var genre = await _repository.AddAsync(new Genre { Id = Guid.NewGuid(), Name = "OldName" });
        genre.Name = "NewName";
        var updated = await _repository.UpdateAsync(genre);

        Assert.AreEqual("NewName", updated.Name);
    }
}

[TestClass]
public sealed class PortfolioItemRepositoryTests
{
    private ApplicationDbContext _dbContext;
    private PortfolioItemRepository _repository;
    private SqliteConnection _connection;

    [TestInitialize]
    public void TestInitialize()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlite(_connection)
            .Options;

        _dbContext = new ApplicationDbContext(options);
        _dbContext.Database.EnsureCreated();
        _repository = new PortfolioItemRepository(_dbContext);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        _dbContext.Dispose();
        _connection.Dispose();
    }

    [TestMethod]
    public async Task AddAsync_AddsPortfolioItem()
    {
        var PortfolioItem = new PortfolioItem { Id = Guid.NewGuid(), Name = "TestPortfolioItem" };
        var result = await _repository.AddAsync(PortfolioItem);

        Assert.IsNotNull(result);
        Assert.AreEqual("TestPortfolioItem", result.Name);
        Assert.IsTrue(await _dbContext.PortfolioItem.AnyAsync(g => g.Id == PortfolioItem.Id));
    }

    [TestMethod]
    public async Task GetAllAsync_ReturnsPortfolioItems()
    {
        await _repository.AddAsync(new PortfolioItem
        {
            Id = Guid.NewGuid(),
            Name = "PortfolioItem1",
            Description = "Description",
            SourceLink = "http://localhost"
        });
        await _repository.AddAsync(new PortfolioItem { Id = Guid.NewGuid(), Name = "PortfolioItem2" });

        var PortfolioItems = await _repository.GetAllAsync();

        Assert.AreEqual(3, System.Linq.Enumerable.Count(PortfolioItems));
    }

    [TestMethod]
    public async Task DeleteAsync_RemovesPortfolioItem()
    {
        var PortfolioItem = await _repository.AddAsync(new PortfolioItem { Id = Guid.NewGuid(), Name = "ToDelete" });
        var deleted = await _repository.DeleteAsync(PortfolioItem.Id);

        Assert.IsTrue(deleted);
        Assert.IsFalse(await _dbContext.PortfolioItem.AnyAsync(g => g.Id == PortfolioItem.Id));
    }

    [TestMethod]
    public async Task ExistsAsync_ReturnsTrueIfExists()
    {
        var PortfolioItem = await _repository.AddAsync(new PortfolioItem { Id = Guid.NewGuid(), Name = "Exists" });
        var exists = await _repository.ExistsAsync(PortfolioItem.Id);

        Assert.IsTrue(exists);
    }

    [TestMethod]
    public async Task GetAsync_ReturnsPortfolioItem()
    {
        var PortfolioItem = await _repository.AddAsync(new PortfolioItem { Id = Guid.NewGuid(), Name = "GetMe" });
        var result = await _repository.GetAsync(PortfolioItem.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual("GetMe", result.Name);
    }

    [TestMethod]
    public async Task UpdateAsync_UpdatesPortfolioItem()
    {
        var PortfolioItem = await _repository.AddAsync(new PortfolioItem { Id = Guid.NewGuid(), Name = "OldName" });
        PortfolioItem.Name = "NewName";
        var updated = await _repository.UpdateAsync(PortfolioItem);

        Assert.AreEqual("NewName", updated.Name);
    }

}