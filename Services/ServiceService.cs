using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public Service Add(Service entity)
        {
            return _serviceRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _serviceRepository.Delete(uuid);
        }

        public IReadOnlyCollection<Service> GetAll()
        {
            return _serviceRepository.GetAll();
        }

        public Service GetById(Guid uuid)
        {
            return _serviceRepository.GetById(uuid);
        }

        public Service Update(Service entity)
        {
            return _serviceRepository.Update(entity);
        }
    }
}
