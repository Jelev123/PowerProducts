namespace PowerProducts.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Data.ViewModels;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Data.ViewModels.Home;
    using PowerProducts.Data.ViewModels.Product;
    using PowerProducts.Services.Data.Counts;
    using PowerProducts.Services.Data.Products;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countService;
        private readonly IProductsService productsService;
        private readonly IDeletableEntityRepository<Product> productRepository;

        public HomeController(
            IGetCountService countService,
            IProductsService productsService,
            IDeletableEntityRepository<Product> productRepository)
        {
            this.countService = countService;
            this.productsService = productsService;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var countsDto = this.countService.GetCount();

            var viewModel = this.productRepository.All().Select(s => new ProductInlistViewModel()
            {
                OriginalUrl = s.OriginalUrl,
            }).ToList();

            return this.View(new HomeViewModel()
            {
                Product = viewModel,
                CategoryCounts = countsDto.CategoryCounts,
                ProductCount = countsDto.ProductsCount,
                SubCategoryCounts = countsDto.SubCategoryCounts,
                IngredientCounts = countsDto.IngredientCounts,
                RandomProducts = this.productsService.GetRandom<IndexRandomViewModel>(6),
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
