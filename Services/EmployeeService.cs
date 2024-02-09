using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Add(Employee entity)
        {
            return _employeeRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _employeeRepository.Delete(uuid);
        }

        public IReadOnlyCollection<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetById(Guid uuid)
        {
            return _employeeRepository.GetById(uuid);
        }

        public Employee Update(Employee entity)
        {
            return _employeeRepository.Update(entity);
        }
    }
}
