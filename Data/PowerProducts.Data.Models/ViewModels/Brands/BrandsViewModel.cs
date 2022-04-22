namespace PowerProducts.Data.Models.ViewModels.Product
{
    using System.Collections.Generic;
    using PowerProducts.Data.Models.ViewModels;
    using PowerProducts.Data.ViewModels.Food;

    public class BrandsViewModel : PagingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ProductInlistViewModel> Products { get; set; }
    }
}
