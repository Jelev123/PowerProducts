namespace PowerProducts.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using PowerProducts.Data.Models;

    public class IngredientsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Ingrediants.Any())
            {
                return;
            }

            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = null });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "5-HTP" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "GPLC" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "7-KETO" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "AAKG" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ACAI" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ACETYL L-CARNITINE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ACIDOPHILUS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "AFRICAN MANGO" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "AGMATINE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALA" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALFALFA" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALLICIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALLIIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALOE VERA" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ALPHA-GLYCERYL PHOSPHORYL CHOLINE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "AMINO ACIDS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ANDROGRAPHIS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ANTHOCYANOSIDES" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ANTIOXIDANTS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "ARIMISTANE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "BARLEY GRASS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "BEET ROOT" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "BORON" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "CHONDROITIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "COLLAGEN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "COQ10" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "CURCUMIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "CRANBERRY" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "SENNA" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "TURKESTERONE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "TRYPTOPHAN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "TURMERIC" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "XYLITOL" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "YERBA MATE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "RED CLOVER" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "RASPBERRY KETONES" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "SAME" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "SPIANCH" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "SYNEPHRINE" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "TRYPTOPHAN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "TURMERIC" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "WHEY PROTEIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "WHEY PROTEIN ***" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "PROBIOTICS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "POTASSIUM" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "PROPOLIS" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "PROTEIN" });
            await dbContext.Ingrediants.AddAsync(new Ingredient() { Name = "MULTIVITAMINS" });
            await dbContext.SaveChangesAsync();
        }
    }
}
