namespace PowerProducts.Data.Models;

using System.Collections.Generic;
using Common.Models;
using PowerProducts.Data.ViewModels.Food;
using PowerProducts.Services.Mapping;

public class Subcategory : BaseDeletableModel<int>, IMapTo<ProductListViewModel>
{
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
