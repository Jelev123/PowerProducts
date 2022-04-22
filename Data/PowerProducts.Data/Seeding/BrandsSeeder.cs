namespace PowerProducts.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PowerProducts.Data.Models;

    public class BrandsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Brands.Any())
            {
                return;
            }

            await dbContext.Brands.AddAsync(new Brand() { Name = "4+ Nutrition" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "AMIX" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "AB CUTS" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ABB" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ABOPHARMA" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ADAPT NUTRITION" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ADF" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ALLNUTRITION" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ALPHA BETIC" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ARES" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BALI TEA" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ADF" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BEZZO" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BSN" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BIOTICA" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BLUETENS" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "BIOSIL" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "CANABIGAL" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "CANNABIN" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "CONSUMATIVES" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "DYMATIZE" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "DR ZAK" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "DELICATO" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "EASY FITNESS" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "EFX" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "EVERLAST" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "EVOLITE" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "FA NUTRITION" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "FAMILIA" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "FITMISS" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "FIT SPO" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "GAME READY" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "HARBINGER" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ISOSTAR" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "KFD" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "LACTOFLOR" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "MAXXWIN" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "NUTRAMINO" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "NATROL" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "NEW FORMULA" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "NATURETECH" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "ORALGEN" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "MYSTERY" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "OPTIMUM NUTRITION" });
            await dbContext.Brands.AddAsync(new Brand() { Name = "EVERBUILD" });
            await dbContext.SaveChangesAsync();
        }
    }
}
