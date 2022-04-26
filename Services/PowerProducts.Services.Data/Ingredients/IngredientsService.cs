namespace PowerProducts.Services.Data.Ingredients
{
    using System.Collections.Generic;
    using System.Linq;

    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class IngredientsService : IIngredientsService
    {
        private readonly IDeletableEntityRepository<Ingredient> ingredientRepository;

        public IngredientsService(IDeletableEntityRepository<Ingredient> ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.ingredientRepository.AllAsNoTracking()
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                })
                .OrderBy(s => s.Name)
                .ToList().Select(s => new KeyValuePair<string, string>(s.Id.ToString(), s.Name));
        }

        public IEnumerable<T> GetAllIngredients<T>()
        {
            return this.ingredientRepository.AllAsNoTracking()
          .To<T>().ToList();
        }

        public T GetIngredientsById<T>(int id)
        {
            return this.ingredientRepository.All()
         .Where(s => s.Id == id)
         .To<T>().FirstOrDefault();
        }
    }
}
