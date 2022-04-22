namespace PowerProducts.Services.Data.ServiceModels
{
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class ProductServiceModel : IMapTo<Product>, IMapFrom<Product>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }
    }
}
