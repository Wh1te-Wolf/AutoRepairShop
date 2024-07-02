using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Task<Customer> AddAsync(Customer entity)
    {
        return _customerRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _customerRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<Customer>> GetAllAsync()
    {
        return _customerRepository.GetAllAsync();
    }

    public Task<Customer> GetByIdAsync(Guid uuid)
    {
        return _customerRepository.GetByIdAsync(uuid);
    }

    public Task<Customer> UpdateAsync(Customer entity)
    {
        return _customerRepository.UpdateAsync(entity);
    }
}
