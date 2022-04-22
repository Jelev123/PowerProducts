namespace PowerProducts.Data.Models;

using System.Collections.Generic;
using Common.Models;
using PowerProducts.Data.ViewModels.Food;
using PowerProducts.Data.ViewModels.Product;
using PowerProducts.Services.Mapping;

public class Ingredient : BaseDeletableModel<int>, IMapTo<CategoriesViewModel>, IMapTo<ProductListViewModel>
{
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
