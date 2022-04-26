namespace PowerProducts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Data.ViewModels.Product;
    using PowerProducts.Services.Data.Categories;

    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult CategoriesById(int id)
        {
            ProductListViewModel product = this.categoriesService.GetCategoryById<ProductListViewModel>(id);
            return this.View(product);
        }

        public IActionResult GetAllCategories()
        {
            var categories = this.categoriesService.GetAllCategory<CategoriesViewModel>();
            return this.View(categories);
        }
    }
}
