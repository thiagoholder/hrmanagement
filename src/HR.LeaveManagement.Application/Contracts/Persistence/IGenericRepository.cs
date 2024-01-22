namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();

    Task<T> GetAsync(Guid id);

    Task<T> CreateAsync(T entity);

    Task<T> DeleteAsync(T entity);

    Task<T> UpdateAsync(T entity);
}