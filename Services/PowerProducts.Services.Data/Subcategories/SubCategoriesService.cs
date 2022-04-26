namespace PowerProducts.Services.Data.Subcategories
{
    using System.Collections.Generic;
    using System.Linq;

    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class SubCategoriesService : ISubCategoriesService
    {
        private readonly IDeletableEntityRepository<Subcategory> subcategoryRepository;

        public SubCategoriesService(IDeletableEntityRepository<Subcategory> subcategoryRepository)
        {
            this.subcategoryRepository = subcategoryRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.subcategoryRepository.AllAsNoTracking()
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                })
                .OrderBy(s => s.Name)
                .ToList().Select(s => new KeyValuePair<string, string>(s.Id.ToString(), s.Name));
        }

        public IEnumerable<T> GetAllSubCategory<T>()
        {
            return this.subcategoryRepository.AllAsNoTracking()
           .To<T>().ToList();
        }

        public T GetSubCategoryById<T>(int id)
        {
            return this.subcategoryRepository.All()
          .Where(s => s.Id == id)
          .To<T>().FirstOrDefault();
        }
    }
}
