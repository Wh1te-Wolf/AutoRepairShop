using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public Task<Service> AddAsync(Service entity)
    {
        return _serviceRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _serviceRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<Service>> GetAllAsync()
    {
        return _serviceRepository.GetAllAsync();
    }

    public Task<Service> GetByIdAsync(Guid uuid)
    {
        return _serviceRepository.GetByIdAsync(uuid);
    }

    public Task<Service> UpdateAsync(Service entity)
    {
        return _serviceRepository.UpdateAsync(entity);
    }
}
