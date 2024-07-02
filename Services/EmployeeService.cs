using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public Task<Employee> AddAsync(Employee entity)
    {
        return _employeeRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _employeeRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<Employee>> GetAllAsync()
    {
        return _employeeRepository.GetAllAsync();
    }

    public Task<Employee> GetByIdAsync(Guid uuid)
    {
        return _employeeRepository.GetByIdAsync(uuid);
    }

    public Task<Employee> UpdateAsync(Employee entity)
    {
        return _employeeRepository.UpdateAsync(entity);
    }
}
