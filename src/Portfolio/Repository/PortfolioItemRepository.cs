﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Models;
using Portfolio.Core.Repository.IRepository;
using Portfolio.Data;

namespace Portfolio.Repository;

public class PortfolioItemRepository : IPortfolioItemRepository
{
    private readonly ApplicationDbContext _db;

    public PortfolioItemRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<PortfolioItem> AddAsync(PortfolioItem obj)
    {
        while (await _db.PortfolioItem.AnyAsync(g => g.Id == obj.Id))
        {
            obj.Id = Guid.NewGuid();
        }
        await _db.PortfolioItem.AddAsync(obj);
        await _db.SaveChangesAsync();
        return obj;
    }

    public async Task<bool> DeleteAsync(Guid guid)
    {
        var obj = await _db.PortfolioItem.FirstOrDefaultAsync(g => g.Id == guid);
        if (obj != null)
        {
            _db.PortfolioItem.Remove(obj);
            return (await _db.SaveChangesAsync()) > 0;
        }
        return false;
    }

    public async Task<IEnumerable<PortfolioItem>> GetAllAsync()
    {
        return await _db.PortfolioItem.ToListAsync();
    }

    public async Task<PortfolioItem> GetAsync(Guid guid)
    {
        var obj = await _db.PortfolioItem.FirstOrDefaultAsync(u => u.Id == guid);
        if (obj == null)
        {
            return new PortfolioItem();
        }
        return obj;
    }

    public async Task<PortfolioItem> UpdateAsync(PortfolioItem obj)
    {
        var objFromDb = await _db.PortfolioItem.FirstOrDefaultAsync(u => u.Id == obj.Id);
        if (objFromDb is not null)
        {
            objFromDb.Name = obj.Name;
            _db.PortfolioItem.Update(objFromDb);
            await _db.SaveChangesAsync();
            return objFromDb;
        }
        return obj;
    }

    public async Task<bool> ExistsAsync(Guid guid)
    {
        return await _db.PortfolioItem.AnyAsync(g => g.Id == guid);
    }
}
