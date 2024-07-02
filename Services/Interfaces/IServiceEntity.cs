using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Services.Interfaces;

public interface IServiceEntity<T> where T : IEntity
{
    Task<T> AddAsync(T entity);

    Task DeleteAsync(Guid uuid);

    Task<T> UpdateAsync(T entity);

    Task<T> GetByIdAsync(Guid uuid);

    Task<IReadOnlyCollection<T>> GetAllAsync();
}
