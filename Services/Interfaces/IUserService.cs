using AutoRepairShop.Entities;

namespace AutoRepairShop.Services.Interfaces;

public interface IUserService : IServiceEntity<User>
{
    public Task<User> GetByLoginAndPasswordAsync(string login, string passwordHash);
}
