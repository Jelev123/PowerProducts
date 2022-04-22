namespace PowerProducts.Services.Data
{
    using PowerProducts.Data.Common.Repositories;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;
    using System.Collections.Generic;
    using System.Linq;

    public class BrandService : IBrandService
    {
        private readonly IDeletableEntityRepository<Brand> branRepository;

        public BrandService(IDeletableEntityRepository<Brand> branRepository)
        {
            this.branRepository = branRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.branRepository.AllAsNoTracking()
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                })
                .OrderBy(s => s.Name)
                .ToList().Select(s => new KeyValuePair<string, string>(s.Id.ToString(), s.Name));
        }

        public IEnumerable<T> GetAllBrands<T>()
        {
            return this.branRepository.All()
                .To<T>().ToList();
        }

        public T GetBrandById<T>(int id)
        {
            return this.branRepository.All()
                .Where(s => s.Id == id)
                .To<T>().FirstOrDefault();
        }
    }
}
