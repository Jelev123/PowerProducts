namespace PowerProducts.Data.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PowerProducts.Data.Models.ViewModels.Product;
    using PowerProducts.Data.ViewModels.Food;
    using PowerProducts.Services.Data;

    public class IngredientsController : Controller
    {
        private readonly IIngredientsService ingredientsService;

        public IngredientsController(IIngredientsService ingredientsService)
        {
            this.ingredientsService = ingredientsService;
        }

        public IActionResult GetAllIngredients()
        {
            var ingredients = this.ingredientsService.GetAllIngredients<IngredientsViewModel>();
            return this.View(ingredients);
        }

        public IActionResult GetIngredientsById(int id)
        {
            var ingredients = this.ingredientsService.GetIngredientsById<ProductListViewModel>(id);
            return this.View(ingredients);
        }
    }
}
