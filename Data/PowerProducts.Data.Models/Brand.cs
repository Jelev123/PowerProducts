namespace PowerProducts.Data.Models
{
    using System.Collections.Generic;

    using PowerProducts.Data.Common.Models;
    using PowerProducts.Data.Models.ViewModels.Product;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Services.Mapping;

    public class Brand : BaseDeletableModel<int>, IMapTo<BrandsViewModel>, IMapTo<ProductListViewModel>
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}