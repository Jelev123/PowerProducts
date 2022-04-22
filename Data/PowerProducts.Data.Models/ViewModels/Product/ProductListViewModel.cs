namespace PowerProducts.Data.ViewModels.Food;

using System.Collections.Generic;
using PowerProducts.Data.Models.ViewModels;

public class ProductListViewModel : PagingViewModel
{
    public virtual IEnumerable<ProductInlistViewModel> Products { get; set; }

}
