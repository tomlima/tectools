using Microsoft.EntityFrameworkCore;
using Mysqlx.Connection;
using Tectools.Domain.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSets for your entities
    public DbSet<Component> Components { get; set; }
    
    public DbSet<Cpu> Cpus { get; set; }
    
    public DbSet<Ram> Rams { get; set; }
    
    public DbSet<Cooler> Coolers { get; set; }

    public DbSet<Tectools.Domain.Entities.Monitor> Monitors { get; set; }
    
    public DbSet<Motherboard> Motherboards { get; set; }
    
    public DbSet<Peripheral> Peripherals { get; set; }
    
    public DbSet<PowerSupply> PowerSupplies { get; set; }
    
    public DbSet<Storage> Storages { get; set; }
    
    public DbSet<UserBuild> UserBuilds { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; } 
    
    public DbSet<Compability> Compabilities { get; set; }
}