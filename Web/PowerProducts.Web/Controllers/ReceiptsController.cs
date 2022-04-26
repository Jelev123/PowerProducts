namespace PowerProducts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Models.ViewModels.Receipts.Details;
    using PowerProducts.Services.Data.Receipts;

    public class ReceiptsController : Controller
    {
        private readonly IReceiptService receiptService;

        public ReceiptsController(IReceiptService receiptService)
        {
            this.receiptService = receiptService;
        }

        [HttpGet(Name = "Details")]
        public IActionResult Details(string id)
        {
            var receiptServiceModel = this.receiptService.Details<ReceiptDetailsViewModel>(id);

            return this.View(receiptServiceModel);
        }
    }
}
