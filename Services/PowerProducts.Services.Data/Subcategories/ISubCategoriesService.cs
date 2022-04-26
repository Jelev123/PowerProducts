namespace PowerProducts.Services.Data.Subcategories
{
    using System.Collections.Generic;

    public interface ISubCategoriesService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAllSubCategory<T>();

        T GetSubCategoryById<T>(int id);
    }
}
