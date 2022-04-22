namespace PowerProducts.Services.Data.NewFolder.Orders
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PowerProducts.Services.Data.ServiceModels;
    using PowerProducts.Data.Models;

    public interface IOrderService
    {
        Task<bool> CreateOrder(OrderServiceModel orderServiceModel);

        IEnumerable<T> GetAll<T>();

        Task SetOrdersToReceipt(Receipt receipt);

        Task<bool> CompleteOrder(string orderId);

        Task<bool> ReduceQuantity(string orderId);

        Task<bool> IncreaseQuantity(string orderId);
    }
}
