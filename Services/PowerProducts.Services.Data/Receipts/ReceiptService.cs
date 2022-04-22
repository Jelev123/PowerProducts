namespace PowerProducts.Services.Data.Receipt
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Data;
    using PowerProducts.Services.Mapping;

    public class ReceiptService : IReceiptService
    {
        private readonly IOrderService orderService;
        private readonly PowerProducts.Data.ApplicationDbContext data;
        private readonly IRepository<Receipt> receiptRepository;

        public ReceiptService(IOrderService orderService, PowerProducts.Data.ApplicationDbContext data, IRepository<Receipt> receiptRepository)
        {
            this.orderService = orderService;
            this.data = data;
            this.receiptRepository = receiptRepository;
        }

        public async Task<string> CreateReceipt(string recipientId)
        {
            var receipt = new Receipt
            {
                Id = Guid.NewGuid().ToString(),
                RecipientId = recipientId,
                IssuedOn = DateTime.Now,
            };

            await this.orderService.SetOrdersToReceipt(receipt);

            foreach (var order in receipt.Orders)
            {
                await this.orderService.CompleteOrder(order.Id);
            }

            this.data.Receipts.Add(receipt);
            await this.data.SaveChangesAsync();
            return receipt.Id;
        }

        public T Details<T>(string id)
        {
            var details = this.receiptRepository.All().Where(s => s.Id == id).To<T>().FirstOrDefault();

            return details;
        }
    }
}
