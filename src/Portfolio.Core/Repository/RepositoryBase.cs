using Portfolio.Core.Interfaces;

public abstract class RepositoryBase<T> where T : class, IHasGuid
{
    public List<T> Items { get; set; } = [];
    //protected readonly object _lock = new();

    public abstract Task SaveChangesAsync();

    public async Task AddAsync(T item)
    {
        //lock (_lock)
        //{
        Items.Add(item);
        //}
        await SaveChangesAsync();
    }

    public Task<List<T>> GetAsync()
    {
        //lock (_lock)
        {
            // Return a copy to avoid external modification
            return Task.FromResult(new List<T>(Items));
        }
    }

    public Task<T?> GetAsync(Guid guid)
    {
        //lock (_lock)
        {
            return Task.FromResult(Items.FirstOrDefault(item => item.Guid == guid));
        }
    }

    public async Task UpdateAsync(T item)
    {
        //lock (_lock)
        {
            var index = Items.FindIndex(x => x.Guid == item.Guid);
            if (index != -1)
                Items[index] = item;
        }
        await SaveChangesAsync();
    }

    public async Task DeleteAsync(T item)
    {
        //lock (_lock)
        {
            Items.Remove(item);
        }
        await SaveChangesAsync();
    }
}