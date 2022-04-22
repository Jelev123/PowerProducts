namespace PowerProducts.Data.Models.ViewModels;

using PowerProducts.Services.Data.ServiceModels;
using PowerProducts.Services.Mapping;

public class OrderCartViewModel : IMapFrom<OrderServiceModel>, IMapFrom<Order>
{
    public string Id { get; set; }

    public string ProductOriginalUrl { get; set; }

    public int ProductPrice { get; set; }

    public string ProductName { get; set; }

    public int Quantity { get; set; }

    public string UserId { get; set; }

    public ApplicationUser User { get; set; }
}
