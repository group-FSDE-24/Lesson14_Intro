using Lesson14_Intro.Datas;
using Microsoft.EntityFrameworkCore; 
using Lesson14_Intro.Repositories.Abstracts;
using Lesson14_Intro.Models.Entities.Abstracts;

namespace Lesson14_Intro.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _appDbContext;

    public GenericRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task AddAsync(T entity)
    {
        await _appDbContext.Set<T>().AddAsync(entity);
    }

    public async Task DeleteAsync(T entity)
    {
        _appDbContext.Set<T>().Remove(entity);
    }

    public Task<List<T>> GetAllAsync()
    {
        return _appDbContext.Set<T>().ToListAsync();
    }

    public Task<T> GetByIdAsync(int id)
    {
        return _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id)!;
    }

    public async Task SaveChangeAsync()
    {
        await _appDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _appDbContext.Set<T>().Update(entity);
    }
}
