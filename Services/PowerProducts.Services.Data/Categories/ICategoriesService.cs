namespace PowerProducts.Services.Data.Categories
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAllCategory<T>();

        T GetCategoryById<T>(int id);
    }
}
