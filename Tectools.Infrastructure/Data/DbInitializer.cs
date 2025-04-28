using Tectools.Domain.Entities;
namespace Tectools.Infrastructure.Data;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        // Brand instances
        Brand B_amd = new Brand { Id = 1, Name = "AMD", Logo = "amd.webp", Website = "https://www.amd.com" };
        Brand B_intel = new Brand { Id = 2, Name = "Intel", Logo = "intel.webp", Website = "https://www.intel.com" };
        Brand B_nvidia = new Brand { Id = 3, Name = "NVIDIA", Logo = "nvidia.webp", Website = "https://www.nvidia.com" };
        Brand B_corsair = new Brand { Id = 4, Name = "Corsair", Logo = "corsair.webp", Website = "https://www.corsair.com" };
        Brand B_kingston = new Brand { Id = 5, Name = "Kingston", Logo = "kingston.webp", Website = "https://www.kingston.com" };
        Brand B_gigabyte = new Brand { Id = 6, Name = "Gigabyte", Logo = "gigabyte.webp", Website = "https://www.gigabyte.com" };
        Brand B_asus = new Brand { Id = 7, Name = "ASUS", Logo = "asus.webp", Website = "https://www.asus.com" };
        Brand B_msi = new Brand { Id = 8, Name = "MSI", Logo = "msi.webp", Website = "https://www.msi.com" };
        Brand B_seagate = new Brand { Id = 9, Name = "Seagate", Logo = "seagate.webp", Website = "https://www.seagate.com" };
        Brand B_westernDigital = new Brand { Id = 10, Name = "Western Digital", Logo = "wd.webp", Website = "https://www.westerndigital.com" };
        Brand B_samsung = new Brand { Id = 11, Name = "Samsung", Logo = "samsung.webp", Website = "https://www.samsung.com" };
        Brand B_logitech = new Brand { Id = 12, Name = "Logitech", Logo = "logitech.webp", Website = "https://www.logitech.com" };
        Brand B_redragon = new Brand { Id = 13, Name = "Redragon", Logo = "redragon.webp", Website = "https://www.redragonshop.com" };
        Brand B_hyperx = new Brand { Id = 14, Name = "HyperX", Logo = "hyperx.webp", Website = "https://www.hyperxgaming.com" };
        
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
       
        context.SaveChanges();

    }
}