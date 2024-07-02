using AutoRepairShop.Entities;
using AutoRepairShop.Repository.BaseRepositories;
using AutoRepairShop.Repository.EF;
using AutoRepairShop.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutoRepairShop.Repository;

public class UserRepository : BaseRepository<User, AutoRepairShopContext>, IUserRepository
{
    public async Task<User> GetByLoginAndPasswordAsync(string login, string passwordHash)
    {
        using AutoRepairShopContext context = new AutoRepairShopContext();
        return await context.Users.FirstOrDefaultAsync(u => u.Login == login && u.PasswordHash == passwordHash);
    }
}
