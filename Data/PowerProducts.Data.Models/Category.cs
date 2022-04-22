namespace PowerProducts.Data.Models;

using PowerProducts.Data.Common.Models;
using PowerProducts.Data.ViewModels.Food;
using PowerProducts.Services.Mapping;
using System.Collections.Generic;

public class Category : BaseDeletableModel<int>, IMapTo<ProductListViewModel>
{
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
