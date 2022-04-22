namespace PowerProducts.Data.Models
{
    using System.Collections.Generic;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Data.Common.Models;
    using PowerProducts.Services.Mapping;

    public class Product : BaseDeletableModel<int>, IMapTo<ProductListViewModel>
    {
        public string Name { get; set; }

        public string Information { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string Taste { get; set; }

        public string Description { get; set; }

        public string OriginalUrl { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int SubcategoryId { get; set; }

        public virtual Subcategory Subcategory { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public virtual ICollection<Images> Images { get; set; } = new HashSet<Images>();
    }
}
