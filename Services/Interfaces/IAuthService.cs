using AutoRepairShop.Entities;

namespace AutoRepairShop.Services.Interfaces;

public interface IAuthService
{
    Task RegisterUserAsync(string login, string password, string role);

    Task<User> GetUserAsync(string login, string password);
}
