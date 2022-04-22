namespace PowerProducts.Services.Data.ServiceModels
{
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class OrderServiceModel : IMapTo<Order>, IMapFrom<Order>
    {
        public string Id { get; set; }

        public int ProductId { get; set; }

        public ProductServiceModel Product { get; set; }

        public int Quantity { get; set; }

        public string UserId { get; set; }

        public UserServiceModel User { get; set; }

        public int OrderStatusId { get; set; }

        public OrderStatusServiceModel Status { get; set; }
    }
}
