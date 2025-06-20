﻿using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Models;
using Portfolio.Core.Repository.IRepository;
using Portfolio.Data;

namespace Portfolio.Repository;

public class GenreRepository : IGenreRepository
{
    private readonly ApplicationDbContext _db;

    public GenreRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<Genre> AddAsync(Genre obj)
    {
        while (await _db.Genre.AnyAsync(g => g.Id == obj.Id))
        {
            obj.Id = Guid.NewGuid();
        }
        await _db.Genre.AddAsync(obj);
        await _db.SaveChangesAsync();
        return obj;
    }

    public async Task<bool> DeleteAsync(Guid guid)
    {
        var obj = await _db.Genre.FirstOrDefaultAsync(g => g.Id == guid);
        if (obj != null)
        {
            _db.Genre.Remove(obj);
            return (await _db.SaveChangesAsync()) > 0;
        }
        return false;
    }

    public async Task<IEnumerable<Genre>> GetAllAsync()
    {
        return await _db.Genre.OrderBy(g => g.Name).ToListAsync();
    }

    public async Task<Genre> GetAsync(Guid guid)
    {
        var obj = await _db.Genre.FirstOrDefaultAsync(u => u.Id == guid);
        if (obj == null)
        {
            return new Genre();
        }
        return obj;
    }

    public async Task<Genre> UpdateAsync(Genre obj)
    {
        var objFromDb = await _db.Genre.FirstOrDefaultAsync(u => u.Id == obj.Id);
        if (objFromDb is not null)
        {
            objFromDb.Name = obj.Name;
            _db.Genre.Update(objFromDb);
            await _db.SaveChangesAsync();
            return objFromDb;
        }
        return obj;
    }

    public async Task<bool> ExistsAsync(Guid guid)
    {
        return await _db.Genre.AnyAsync(g => g.Id == guid);
    }
}