namespace PowerProducts.Data.Models.ViewModels.Product
{
    using System.Collections.Generic;

    using PowerProducts.Data.Models;
    using PowerProducts.Data.Models.ViewModels;
    using PowerProducts.Data.ViewModels;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Services.Mapping;

    public class IngredientsViewModel : PagingViewModel, IMapFrom<Ingredient>, IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ProductInlistViewModel> Products { get; set; }
    }
}
