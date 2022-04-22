namespace PowerProducts.Data.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Models.ViewModels.Product;
    using PowerProducts.Services.Data;
    using PowerProducts.Data.ViewModels.Food;

    public class BrandsController : Controller
    {
        private readonly IBrandService brandsService;

        public BrandsController(IBrandService brandsService)
        {
            this.brandsService = brandsService;
        }

        public IActionResult BrandsByById(int id)
        {
            var brand = this.brandsService.GetBrandById<ProductListViewModel>(id);
            return this.View(brand);
        }

        public IActionResult GetAllBrands()
        {
            var brands = this.brandsService.GetAllBrands<BrandsViewModel>();
            return this.View(brands);
        }
    }
}
