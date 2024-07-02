using AutoRepairShop.Entities.Interfaces;
using AutoRepairShop.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AutoRepairShop.Repository.BaseRepositories
{
    public class BaseRepository<T, DBtype> : IRepository<T> where T : class, IEntity, new() where DBtype : DbContext
    {
        public virtual async Task<T> AddAsync(T entity)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            EntityEntry<T> addedEntity = await dBContext.Set<T>().AddAsync(entity);
            await dBContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            return await dBContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid uuid)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            return await dBContext.Set<T>().FirstOrDefaultAsync(e => e.UUID == uuid);
        }

        public virtual async Task DeleteAsync(Guid uuid)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            dBContext.Set<T>().Remove(new T { UUID = uuid });
            await dBContext.SaveChangesAsync();
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            EntityEntry<T> updatedEntity = dBContext.Set<T>().Update(entity);
            await dBContext.SaveChangesAsync();
            return updatedEntity.Entity;
        }
    }
}
