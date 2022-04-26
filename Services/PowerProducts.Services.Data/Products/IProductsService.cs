namespace PowerProducts.Services.Data.Products;

using System.Collections.Generic;
using System.Threading.Tasks;

using PowerProducts.Data.ViewModels.Product;

public interface IProductsService
{
    Task CreateProduct(CreateProductViewModel create);

    IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 100);

    T GetById<T>(int id);

    IEnumerable<T> GetRandom<T>(int count);

    int GetCount();

    Task UpdateAsync(int id, EditProductViewModel input);

    Task DeleteAsync(int id);
}
