namespace PowerProducts.Web.Controllers
{
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Models.ViewModels;
    using PowerProducts.Services.Data.Orders;
    using PowerProducts.Services.Data.Receipts;

    public class OrderrController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IReceiptService receiptService;

        public OrderrController(IOrderService orderService, IReceiptService receiptService)
        {
            this.orderService = orderService;
            this.receiptService = receiptService;
        }

        [HttpGet]
        public IActionResult Cart()
        {
            var viewModel = this.orderService.GetAll<OrderCartViewModel>()
                .Where(s => s.UserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();

            return this.View(viewModel);
        }

        [HttpPost]
        [Route("/Order/Cart/Complete")]

        public async Task<IActionResult> Complete()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            string receiptId = await this.receiptService.CreateReceipt(userId);

            return this.Redirect($"/Receipts/Details/{receiptId}");
        }

        [HttpPost]
        [Route("/Orderr/{id}/Quantity/Reduce")]
        public async Task<IActionResult> Reduce(string id)
        {
            bool result = await this.orderService.ReduceQuantity(id);

            if (result)
            {
                return this.Ok();
            }
            else
            {
                return this.Forbid();
            }
        }

        [HttpPost]
        [Route("/Orderr/{id}/Quantity/Increase")]
        public async Task<IActionResult> Increase(string id)
        {
            bool result = await this.orderService.IncreaseQuantity(id);

            if (result)
            {
                return this.Ok();
            }
            else
            {
                return this.Forbid();
            }
        }
    }
}
