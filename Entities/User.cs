using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities;

public class User : IEntity
{
    public Guid UUID { get; set; }

    public string Login { get; set; }

    public string PasswordHash { get; set; }

    public string Role { get; set; }
}
