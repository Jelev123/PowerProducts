namespace PowerProducts.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PowerProducts.Data.Models;

    public class SubCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Subcategories.Any())
            {
                return;
            }

            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = null });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Whey" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Creatine free" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Stimulant free" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Energy boosters" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Focus and concentration" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Creapure®" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Single component" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Single component" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Creatine only" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Creatine matrix with other ingredients" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "L-Carnitine" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Thermogenic ***s" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Lipotropic ***s" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Fat Blocker" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Carb Blocker" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "CLA" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Synephrine" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Raspberry Ketones" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Green coffee" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Garcinia" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Water-Out products" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Single Component Products" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Complex Formulas" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Matrix" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Beef" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Casein/Milk" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Vegetable" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Egg" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Ready to use (liquid)" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Single doses" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Poultry protein" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "For specific needs" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "With creatine" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Non-creatine" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "High protein" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Balanced" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Formulas for men" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Formulas for women" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Children's vitamins" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Liquid" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Minerals" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Vitamins" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "MCT" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Coconut oil" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Flaxseed oil" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Omega fatty acids" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Herbal" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "VITARGO ®" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Simple " });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Complex" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Fibers " });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Testosterone modulators" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Estrogen blockers & Aromatase inhibitors" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Insulin imitators" });
            await dbContext.Subcategories.AddAsync(new Subcategory() { Name = "Hardcore products" });
            await dbContext.SaveChangesAsync();
        }
    }
}
