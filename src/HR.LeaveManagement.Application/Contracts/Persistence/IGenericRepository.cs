using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IReadOnlyCollection<T>> GetAllAsync();

    Task<T> GetAsync(Guid id);

    Task CreateAsync(T entity);

    Task DeleteAsync(T entity);

    Task UpdateAsync(T entity);
}