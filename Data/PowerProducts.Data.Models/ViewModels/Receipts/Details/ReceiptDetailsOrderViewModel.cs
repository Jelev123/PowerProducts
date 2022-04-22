namespace PowerProducts.Data.Models.ViewModels.Receipts.Details
{
    using PowerProducts.Services.Data.ServiceModels;
    using PowerProducts.Services.Mapping;

    public class ReceiptDetailsOrderViewModel : IMapFrom<OrderServiceModel>
    {
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public int Quantity { get; set; }
    }
}
