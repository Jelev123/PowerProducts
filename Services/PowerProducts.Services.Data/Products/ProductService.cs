namespace PowerProducts.Services.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapping;
using PowerProducts.Data.Common.Repositories;
using PowerProducts.Data.Models;
using PowerProducts.Data.ViewModels.Product;

public class ProductService : IProductsService
{
    private readonly IDeletableEntityRepository<Product> productRepository;
    private readonly IDeletableEntityRepository<Category> categoryRepository;

    public ProductService(IDeletableEntityRepository<Product> productRepository, IDeletableEntityRepository<Category> categoryRepository)
    {
        this.productRepository = productRepository;
        this.categoryRepository = categoryRepository;
    }

    public async Task CreateProduct(CreateProductViewModel create)
    {
        var product = new Product()
        {
            Name = create.Name,
            Information = create.Information,
            Description = create.Description,
            OriginalUrl = create.ImageUrl,
            IngredientId = create.IngredientId,
            BrandId = create.BrandId,
            CategoryId = create.CategoryId,
            SubcategoryId = create.SubCategoryId,
            Taste = create.Flavors,
            Price = create.Price,
        };

        await this.productRepository.AddAsync(product);
        await this.productRepository.SaveChangesAsync();
    }

    public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 6)
    {
        var product = this.productRepository.AllAsNoTracking()
            .OrderBy(x => x.Name)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
            .To<T>().ToList();
        return product;
    }

    public T GetById<T>(int id)
    {
        var product = this.productRepository.AllAsNoTracking()
            .Where(x => x.Id == id)
            .To<T>().FirstOrDefault();
        return product;
    }

    public int GetCount()
    {
        return this.productRepository.All().Count();
    }

    public async Task UpdateAsync(int id, EditProductViewModel input)
    {
        var product = this.productRepository.All().FirstOrDefault(s => s.Id == id);
        product.Name = input.Name;
        product.Price = input.Price;
        product.OriginalUrl = input.OriginalUrl;
        product.Information = input.Information;
        product.Taste = input.Flavors;
        product.Description = input.Description;
        product.CategoryId = input.CategoryId;
        product.SubcategoryId = input.SubcategoryId;
        product.IngredientId = input.IngredientId;
        product.BrandId = input.BrandId;
        await this.productRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = this.productRepository.All().FirstOrDefault(s => s.Id == id);

        this.productRepository.Delete(product);
        await this.productRepository.SaveChangesAsync();
    }

    public IEnumerable<T> GetRandom<T>(int count)
    {
        return this.productRepository.All().OrderBy(s => Guid.NewGuid())
            .Take(count)
            .To<T>().ToList();
    }
}
