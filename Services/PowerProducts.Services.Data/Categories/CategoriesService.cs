namespace PowerProducts.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(
            IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categoriesRepository.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                })
                .OrderBy(x => x.Name)
                .ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }

        public IEnumerable<T> GetAllCategory<T>()
        {
            return this.categoriesRepository.AllAsNoTracking()
          .To<T>().ToList();
        }

        public T GetCategoryById<T>(int id)
        {
            return this.categoriesRepository.All()
          .Where(s => s.Id == id)
          .To<T>().FirstOrDefault();
        }
    }
}
