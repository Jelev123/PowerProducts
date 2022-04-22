namespace PowerProducts.Data.ViewModels.Home
{
    using System.Collections.Generic;

    using PowerProducts.Data.Models;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Data.ViewModels.Product;

    public class HomeViewModel
    {
        public IEnumerable<IndexRandomViewModel> RandomProducts { get; set; }

        public int ProductCount { get; set; }

        public int CategoryCounts { get; set; }

        public int SubCategoryCounts { get; set; }

        public int IngredientCounts { get; set; }

        public string SearchTerm { get; set; }

        public List<Product> Products { get; set; }

        public List<ProductInlistViewModel> Product { get; set; }
    }
}
