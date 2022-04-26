namespace PowerProducts.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Models.ViewModels.Product;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Services.Data.Subcategories;

    public class SubCategoriesController : Controller
    {
        private readonly ISubCategoriesService subCategoriesService;

        public SubCategoriesController(ISubCategoriesService subCategoriesService)
        {
            this.subCategoriesService = subCategoriesService;
        }

        public IActionResult GetSubCategories()
        {
            var subCategories = this.subCategoriesService.GetAllSubCategory<SubcategoriesViewModel>();
            return this.View(subCategories);
        }

        public IActionResult SubCategoriesById(int id)
        {
            var product = this.subCategoriesService.GetSubCategoryById<ProductListViewModel>(id);
            return this.View(product);
        }
    }
}
