using Lesson14_Intro.Models.Entities.Abstracts;

namespace Lesson14_Intro.Repositories.Abstracts;

public interface IGenericRepository<T> where T: BaseEntity, new()
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
    Task AddAsync(T entity);

    Task SaveChangeAsync();
}
