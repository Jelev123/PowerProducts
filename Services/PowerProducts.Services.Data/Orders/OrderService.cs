namespace PowerProducts.Services.Data.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using PowerProducts.Data;
    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Data.ServiceModels;
    using PowerProducts.Services.Mapping;

    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext data;
        private readonly IRepository<Order> orderRepository;

        public OrderService(ApplicationDbContext data, IRepository<Order> orderRepository)
        {
            this.data = data;
            this.orderRepository = orderRepository;
        }

        public async Task<bool> CreateOrder(OrderServiceModel orderServiceModel)
        {
            Order order = new()
            {
                Id = Guid.NewGuid().ToString(),
                StatusOrderId = orderServiceModel.OrderStatusId,
                ProductId = orderServiceModel.ProductId,
                UserId = orderServiceModel.UserId,
                Quantity = orderServiceModel.Quantity,
            };

            order.StatusOrder = await this.data.StatusOrders
                .SingleOrDefaultAsync(orderStatus => orderStatus.Name == "Active");

            await this.orderRepository.AddAsync(order);
            int result = await this.orderRepository.SaveChangesAsync();

            return result > 0;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var orders = this.orderRepository.All()
                .Where(s => s.StatusOrderId == 2).To<T>().ToList();

            return orders;
        }

        public async Task SetOrdersToReceipt(Receipt receipt)
        {
            List<Order> ordersFromDb = await this.data.Orders
                .Where(order => order.UserId == receipt.RecipientId && order.StatusOrder.Id == 2).ToListAsync();

            receipt.Orders = ordersFromDb;
        }

        public async Task<bool> CompleteOrder(string orderId)
        {
            Order orderFromDb = await this.data.Orders
               .SingleOrDefaultAsync(order => order.Id == orderId);

            orderFromDb.StatusOrder = await this.data.StatusOrders
                .SingleOrDefaultAsync(orderStatus => orderStatus.Name == "Completed");

            if (orderFromDb == null || orderFromDb.StatusOrder.Id != 1)
            {
                throw new ArgumentException(nameof(orderFromDb));
            }

            this.data.Update(orderFromDb);
            int result = await this.data.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> ReduceQuantity(string orderId)
        {
            Order orderFromDb = await this.data.Orders
             .SingleOrDefaultAsync(order => order.Id == orderId);

            if (orderFromDb == null)
            {
                throw new ArgumentNullException(nameof(orderFromDb));
            }

            if (orderFromDb.Quantity == 1)
            {
                return false;
            }

            orderFromDb.Quantity--;

            this.data.Update(orderFromDb);
            int result = await this.data.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> IncreaseQuantity(string orderId)
        {
            Order orderFromDb = await this.data.Orders
               .SingleOrDefaultAsync(order => order.Id == orderId);

            if (orderFromDb == null)
            {
                throw new ArgumentNullException(nameof(orderFromDb));
            }

            orderFromDb.Quantity++;

            this.data.Update(orderFromDb);
            int result = await this.data.SaveChangesAsync();

            return result > 0;
        }
    }
}