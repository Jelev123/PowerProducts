namespace PowerProducts.Data.ViewModels.Product
{
    using System.Collections.Generic;

    using PowerProducts.Data.Models;
    using PowerProducts.Data.Models.ViewModels;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Services.Mapping;

    public class CategoriesViewModel : PagingViewModel, IMapFrom<Category>, IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ProductInlistViewModel> Products { get; set; }
    }
}
