namespace PowerProducts.Services.Data.ServiceModels
{
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class OrderStatusServiceModel : IMapFrom<StatusOrder>, IMapTo<Order>
    {
        public string Name { get; set; }
    }
}
