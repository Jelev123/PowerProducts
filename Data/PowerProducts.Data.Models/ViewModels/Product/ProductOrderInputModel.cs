namespace PowerProducts.Data.ViewModels.Product
{
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class ProductOrderInputModel : IMapTo<Order>, IMapFrom<Order>
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
