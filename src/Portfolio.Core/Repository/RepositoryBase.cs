using Portfolio.Core.Interfaces;

namespace Portfolio.Core.Repository;

public abstract class RepositoryBase<T> where T : class, IHasGuid
{
    public List<T> Items { get; set; } = [];

    public Task AddAsync(T item)
    {
        Items.Add(item);
        return Task.CompletedTask;
    }

    public Task<List<T>> GetAsync() =>
    Task.FromResult(Items);

    public Task<T?> GetAsync(Guid guid) =>
        Task.FromResult(Items.FirstOrDefault(item => item.Guid == guid));

    public Task UpdateAsync(T item)
    {
        var index = Items.FindIndex(x => x.Guid == item.Guid);
        if (index != -1)
            Items[index] = item;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(T item)
    {
        Items.Remove(item);
        return Task.CompletedTask;
    }
}
