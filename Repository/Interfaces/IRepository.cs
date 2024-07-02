using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Repository.Interfaces;

public interface IRepository<T> where T : class, IEntity
{
    /// <summary>
    /// Добавить сущность
    /// </summary>
    Task<T> AddAsync(T entity);

    /// <summary>
    /// Удалить сущность
    /// </summary>
    Task DeleteAsync(Guid uuid);

    /// <summary>
    /// Обновить сущность
    /// </summary>
    Task<T> UpdateAsync(T entity);

    /// <summary>
    /// Получить сущность по UUID
    /// </summary>
    Task<T> GetByIdAsync(Guid uuid);

    /// <summary>
    /// Получить список всех сущностей
    /// </summary>
    Task<IReadOnlyCollection<T>> GetAllAsync();
}
