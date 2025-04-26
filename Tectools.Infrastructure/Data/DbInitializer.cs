using Tectools.Domain.Entities;
namespace Tectools.Infrastructure.Data;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        
        // Brand instances
        Brand B_amd = new Brand { Id = 1, Name = "AMD", Logo = "amd.webp" };
        Brand B_intel = new Brand { Id = 2, Name = "Intel", Logo = "intel.webp" };
        Brand B_nvidia = new Brand { Id = 3, Name = "NVIDIA", Logo = "nvidia.webp" };
        Brand B_corsair = new Brand { Id = 4, Name = "Corsair", Logo = "corsair.webp" };
        Brand B_kingston = new Brand { Id = 5, Name = "Kingston", Logo = "kingston.webp" };
        Brand B_gigabyte = new Brand { Id = 6, Name = "Gigabyte", Logo = "gigabyte.webp" };
        Brand B_asus = new Brand { Id = 7, Name = "ASUS", Logo = "asus.webp" };
        Brand B_msi = new Brand { Id = 8, Name = "MSI", Logo = "msi.webp" };
        Brand B_seagate = new Brand { Id = 9, Name = "Seagate", Logo = "seagate.webp" };
        Brand B_westernDigital = new Brand { Id = 10, Name = "Western Digital", Logo = "wd.webp" };
        Brand B_samsung = new Brand { Id = 11, Name = "Samsung", Logo = "samsung.webp" };
        Brand B_logitech = new Brand { Id = 12, Name = "Logitech", Logo = "logitech.webp" };
        Brand B_redragon = new Brand { Id = 13, Name = "Redragon", Logo = "redragon.webp" };
        Brand B_hyperx = new Brand { Id = 14, Name = "HyperX", Logo = "hyperx.webp" };
        
        // Category instances
        Category C_cpu = new Category { Id = 1, Name = "Processador", Slug = "cpu", Icon = "cpu"};
        Category C_gpu = new Category { Id = 2, Name = "Placa de Vídeo", Slug = "placa-de-video", Icon = "gpu"};
        Category C_motherboard = new Category { Id = 3, Name = "Placa-mãe", Slug = "placa-mae", Icon = "motherboard"};
        Category C_ram = new Category { Id = 4, Name = "Memória RAM", Slug = "memoria-ram", Icon = "ram" };
        Category C_storage = new Category { Id = 5, Name = "Armazenamento", Slug = "armazenamento", Icon = "storage"};
        Category C_psu = new Category { Id = 6, Name = "Fonte de Alimentação", Slug = "fonte-de-alimentacao", Icon = "psu"};
        Category C_case = new Category { Id = 7, Name = "Gabinete", Slug = "gabinete", Icon = "case" };
        Category C_cooler = new Category { Id = 8, Name = "Cooler / Refrigeração", Slug = "cooler", Icon = "cooler" };
        Category C_monitor = new Category { Id = 9, Name = "Monitor", Slug = "monitor", Icon = "monitor" };
        Category C_peripheral = new Category { Id = 10, Name = "Periféricos", Slug = "perifericos" , Icon = "peripheral" };
        Category C_accessory = new Category { Id = 11, Name = "Acessórios", Slug = "accessories", Icon = "accessory" };
        
        
        // CPUs
        Cpu cpu_5600x = new Cpu
        {
            Id = 1,
            Name = "AMD Ryzen 5 5600X",
            Brand = B_amd,
            Category = C_cpu,
            AveragePrice = 1100.00M,
            AffiliateUrl = "https://mercadolivre.com.br/ryzen-5600x?matt_tool=tecmundo123",
            Socket = "AM4",
            Cores = 6,
            Threads = 12,
            BaseClock = "3.7GHz",
            BoostClock = "4.6GHz",
            Tdp = "65W",
            Featured = true,
            Image = "ryzen-5600x.webp"
        };

        Cpu cpu_i5_12400f = new Cpu
        {
            Id = 2,
            Name = "Intel Core i5-12400F",
            Brand = B_intel,
            Category = C_cpu,
            AveragePrice = 999.00M,
            AffiliateUrl = "https://kabum.com.br/i5-12400f?afiliado=tecmundo",
            Socket = "LGA1700",
            Cores = 6,
            Threads = 12,
            BaseClock = "2.5GHz",
            BoostClock = "4.4GHz",
            Tdp = "65W",
            Featured = false,
            Image = "i5-12400f.webp"
        };

        Cpu cpu_7800x3d = new Cpu
        {
            Id = 3,
            Name = "AMD Ryzen 7 7800X3D",
            Brand = B_amd,
            Category = C_cpu,
            AveragePrice = 2299.00M,
            AffiliateUrl = "https://amazon.com.br/ryzen-7800x3d?tag=tecmundo-20",
            Socket = "AM5",
            Cores = 8,
            Threads = 16,
            BaseClock = "4.2GHz",
            BoostClock = "5.0GHz",
            Tdp = "120W",
            Featured = true,
            Image = "ryzen-7800x3d.webp"
        };
        
        

        // Insert brands
        if (!context.Brands.Any())
        {
            context.Brands.AddRange(    
                B_amd,
                B_intel,
                B_nvidia,
                B_corsair,
                B_kingston,
                B_gigabyte,
                B_asus,
                B_msi,
                B_seagate,
                B_westernDigital,
                B_samsung,
                B_logitech,
                B_redragon,
                B_hyperx
            );
        }
        
        // Insert categories
        if (!context.Categories.Any())
        {
            context.Categories.AddRange(
                C_cpu,
                C_gpu,
                C_motherboard,
                C_ram,
                C_storage,
                C_psu,
                C_case,
                C_cooler,
                C_monitor,
                C_peripheral,
                C_accessory
            );
        }
        
        // Insert CPU's
        if (!context.Components.Any())
        {
            context.Components.AddRange(cpu_5600x, cpu_i5_12400f, cpu_7800x3d);
        }
       
        context.SaveChanges();

    }
}