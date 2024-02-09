using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Services.Interfaces
{
    public interface IServiceEntity<T> where T : IEntity
    {
        T Add(T entity);

        void Delete(Guid uuid);

        T Update(T entity);

        T GetById(Guid uuid);

        IReadOnlyCollection<T> GetAll();
    }
}
