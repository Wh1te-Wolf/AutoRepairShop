using AutoRepairShop.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AutoRepairShop.Repository.EF;

public class AutoRepairShopContext : DbContext
{
    public DbSet<AcceptanceDocument> AcceptanceDocuments { get; set; }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<DocumentLine> DocumentLines { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Service> Services { get; set; }

    public DbSet<Shift> Shifts { get; set; }

    public DbSet<User> Users { get; set; }

    public static string ConnectionString { get; set; }

    public AutoRepairShopContext()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
}
