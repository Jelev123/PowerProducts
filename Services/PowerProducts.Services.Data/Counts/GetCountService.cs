namespace PowerProducts.Services.Data.Counts
{
    using System.Linq;

    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Data.Models;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<Product> productRepository;
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Subcategory> subcategoryRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientRepository;

        public GetCountService(
            IDeletableEntityRepository<Product> productRepository,
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Subcategory> subcategoryRepository,
            IDeletableEntityRepository<Ingredient> ingredientRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.subcategoryRepository = subcategoryRepository;
            this.ingredientRepository = ingredientRepository;
        }

        public CountsDto GetCount()
        {
            var count = new CountsDto()
            {
                CategoryCounts = this.categoryRepository.All().Count(),
                ProductsCount = this.productRepository.All().Count(),
                SubCategoryCounts = this.subcategoryRepository.All().Count(),
                IngredientCounts = this.ingredientRepository.All().Count(),
            };

            return count;
        }
    }
}