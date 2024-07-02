using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> AddAsync(User entity)
        {
            return _userRepository.AddAsync(entity);
        }

        public Task DeleteAsync(Guid uuid)
        {
            return _userRepository.DeleteAsync(uuid);
        }

        public Task<IReadOnlyCollection<User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync();
        }

        public Task<User> GetByIdAsync(Guid uuid)
        {
            return _userRepository.GetByIdAsync(uuid);
        }

        public Task<User> GetByLoginAndPasswordAsync(string login, string passwordHash)
        {
            return _userRepository.GetByLoginAndPasswordAsync(login, passwordHash);
        }

        public Task<User> UpdateAsync(User entity)
        {
            return _userRepository.UpdateAsync(entity);
        }
    }
}
