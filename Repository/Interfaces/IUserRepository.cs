using AutoRepairShop.Entities;

namespace AutoRepairShop.Repository.Interfaces;

public interface IUserRepository : IRepository<User>
{
    public Task<User> GetByLoginAndPasswordAsync(string login, string passwordHash);
}
