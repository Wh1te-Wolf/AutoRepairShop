using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Add(Customer entity)
        {
            return _customerRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _customerRepository.Delete(uuid);
        }

        public IReadOnlyCollection<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(Guid uuid)
        {
            return _customerRepository.GetById(uuid);
        }

        public Customer Update(Customer entity)
        {
            return _customerRepository.Update(entity);
        }
    }
}
