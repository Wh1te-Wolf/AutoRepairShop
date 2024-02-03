using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Repository.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        /// <summary>
        /// Добавить сущность
        /// </summary>
        T Add(T entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        void Delete(Guid uuid);

        /// <summary>
        /// Обновить сущность
        /// </summary>
        T Update(T entity);

        /// <summary>
        /// Получить сущность по UUID
        /// </summary>
        T GetById(Guid uuid);

        /// <summary>
        /// Получить список всех сущностей
        /// </summary>
        IReadOnlyCollection<T> GetAll();
    }
}
