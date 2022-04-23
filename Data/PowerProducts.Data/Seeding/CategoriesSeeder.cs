namespace PowerProducts.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PowerProducts.Data;
    using PowerProducts.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category() { Name = null });
            await dbContext.Categories.AddAsync(new Category() { Name = "POST-WORKOUT" });
            await dbContext.Categories.AddAsync(new Category() { Name = "PRE-WORKOUT" });
            await dbContext.Categories.AddAsync(new Category() { Name = "INTRA-WORKOUT" });
            await dbContext.Categories.AddAsync(new Category() { Name = "PROTEINS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "AMINO ACIDS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "CREATINE SUPPLEMENTS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "WEIGHT MANAGEMENT AND WEIGHT LOSS " });
            await dbContext.Categories.AddAsync(new Category() { Name = "JOINT RECOVERY" });
            await dbContext.Categories.AddAsync(new Category() { Name = "PROTEINS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "WEIGHT GAINERS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "ALL IN ONE PRODUCTS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "SUPPLEMENTS FOR WOMEN" });
            await dbContext.Categories.AddAsync(new Category() { Name = "VITAMINS AND MINERALS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "FATTY ACIDS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "ANTIOXIDANTS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "ADAPTOGENS" });
            await dbContext.Categories.AddAsync(new Category() { Name = "EXTRACTS " });
            await dbContext.Categories.AddAsync(new Category() { Name = "CARBOHYDRATES " });
            await dbContext.Categories.AddAsync(new Category() { Name = "HORMONE - STIMULATING AND HARDCORE PRODUCTS " });
            await dbContext.SaveChangesAsync();
        }
    }
}
