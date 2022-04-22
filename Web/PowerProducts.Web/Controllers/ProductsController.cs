namespace PowerProducts.Data.Controllers
{
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Common;
    using PowerProducts.Data;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Data.ViewModels.Product;
    using PowerProducts.Services.Data;
    using PowerProducts.Services.Data.ServiceModels;

    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext data;

        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;
        private readonly ISubCategoriesService subCategoriesService;
        private readonly IBrandService brandService;
        private readonly IIngredientsService ingredientsService;
        private readonly IEmailSender imEmailSender;
        private readonly IOrderService orderService;

        public ProductsController(IProductsService productsService, IEmailSender imEmailSender, ICategoriesService categoriesService, ISubCategoriesService subCategoriesService,
             IBrandService brandService, IIngredientsService ingredientsService, IOrderService orderService
            )
        {
            this.productsService = productsService;
            this.imEmailSender = imEmailSender;
            this.categoriesService = categoriesService;
            this.subCategoriesService = subCategoriesService;
            this.brandService = brandService;
            this.ingredientsService = ingredientsService;
            this.orderService = orderService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult CreateProduct()
        {
            var viewModel = new CreateProductViewModel();
            viewModel.Categories = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.SubCategories = this.subCategoriesService.GetAllAsKeyValuePairs();
            viewModel.Brands = this.brandService.GetAllAsKeyValuePairs();
            viewModel.Ingredients = this.ingredientsService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel model)
        {
            await this.productsService.CreateProduct(model);
            return this.RedirectToAction("All");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 6;

            var viewModel = new ProductListViewModel()
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                ProductsCount = this.productsService.GetCount(),
                Products = this.productsService.GetAll<ProductInlistViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var product = this.productsService.GetById<SingleProductViewModel>(id);
            return this.View(product);
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult Edit(int id)
        {
            var inputModel = this.productsService.GetById<EditProductViewModel>(id);
            return this.View(inputModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Edit(int id, EditProductViewModel input)
        {
            await this.productsService.UpdateAsync(id, input);

            return this.RedirectToAction(nameof(this.ById), new { id });
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> Delete(int id)
        {
            await this.productsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }

        [HttpPost]
        public async Task<IActionResult> SendToEmail(int id)
        {
            var product = this.productsService.GetById<ProductInlistViewModel>(id);
            var html = new StringBuilder();
            html.AppendLine($"<h1>{product.Name}</h1>");
            html.AppendLine($"<h3>{product.Price}</h3>");
            html.AppendLine($"<img src=\"{product.OriginalUrl}\" />");
            await this.imEmailSender.SendEmailAsync("powerfood@gmai.com", "bofiho8434@ketchet.com", html.ToString());
            return this.RedirectToAction(nameof(this.ById), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Order(OrderServiceModel orderServiceModel)
        {
            orderServiceModel.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.orderService.CreateOrder(orderServiceModel);

            return this.Redirect("All");
        }
    }
}
