using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace AutoRepairShop.Services;

public class AuthService : IAuthService
{
    private readonly IUserService _userService;

    public AuthService(IUserService userService)
    {
        _userService = userService;
    }

    public Task<User> GetUserAsync(string login, string password)
    {
        string hashPassword = ComputeHash(password);
        return _userService.GetByLoginAndPasswordAsync(login, hashPassword);
    }

    public async Task RegisterUserAsync(string login, string password, string role)
    {
        User user = new User()
        { 
            Login = login,
            Role = role,
            PasswordHash = ComputeHash(password)
        };

        await _userService.AddAsync(user);
    }

    private string ComputeHash(string input)
    {
        using (var sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
