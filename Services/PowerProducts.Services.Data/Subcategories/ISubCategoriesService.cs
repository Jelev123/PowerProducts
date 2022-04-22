namespace PowerProducts.Services.Data
{
    using System.Collections.Generic;

    public interface ISubCategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAllSubCategory<T>();

        T GetSubCategoryById<T>(int id);
    }
}
