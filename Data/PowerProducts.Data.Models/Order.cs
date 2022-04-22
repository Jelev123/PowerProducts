namespace PowerProducts.Data.Models
{
    using PowerProducts.Data.Common.Models;
    using PowerProducts.Data.Models.ViewModels;
    using PowerProducts.Data.Models.ViewModels.Receipts.Details;
    using PowerProducts.Services.Mapping;
    using PowerProducts.Data.Common.Models;

    public class Order : BaseModel<string>, IMapTo<OrderCartViewModel>, IMapTo<ReceiptDetailsOrderViewModel>
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public int StatusOrderId { get; set; }

        public StatusOrder StatusOrder { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
