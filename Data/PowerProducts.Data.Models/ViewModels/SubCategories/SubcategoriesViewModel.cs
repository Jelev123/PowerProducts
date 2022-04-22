namespace PowerProducts.Data.Models.ViewModels.Product
{
    using System.Collections.Generic;

    using PowerProducts.Data.ViewModels;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;
    using PowerProducts.Data.ViewModels.Food;

    public class SubcategoriesViewModel :PagingViewModel, IMapFrom<Subcategory>, IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ProductInlistViewModel> Products { get; set; }

    }
}
