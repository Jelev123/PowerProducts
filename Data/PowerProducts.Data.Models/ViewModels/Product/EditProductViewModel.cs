namespace PowerProducts.Data.ViewModels.Product
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class EditProductViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string OriginalUrl { get; set; }

        public string Flavors { get; set; }

        public string Brand { get; set; }

        public string Information { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int SubcategoryId { get; set; }

        public int BrandId { get; set; }

        public int IngredientId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Categories { get; set; }

        public IEnumerable<KeyValuePair<string, string>> SubCategories { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Brands { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Ingredients { get; set; }
    }
}
