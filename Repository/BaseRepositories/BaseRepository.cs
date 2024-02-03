using AutoRepairShop.Entities.Interfaces;
using AutoRepairShop.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutoRepairShop.Repository.BaseRepositories
{
    public class BaseRepository<T, DBtype> : IRepository<T> where T : class, IEntity, new() where DBtype : DbContext
    {
        public virtual T Add(T entity)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            var addedEntity = dBContext.Set<T>().Add(entity);
            dBContext.SaveChanges();
            return entity;
        }

        public virtual IReadOnlyCollection<T> GetAll()
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            return dBContext.Set<T>().ToList();
        }

        public virtual T GetById(Guid uuid)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            return dBContext.Set<T>().FirstOrDefault(e => e.UUID == uuid);
        }

        public virtual void Delete(Guid uuid)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            dBContext.Set<T>().Remove(new T { UUID = uuid });
            dBContext.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            using DBtype dBContext = Activator.CreateInstance<DBtype>();
            var updatedEntity = dBContext.Set<T>().Update(entity);
            dBContext.SaveChanges();
            return updatedEntity.Entity;
        }
    }
}
