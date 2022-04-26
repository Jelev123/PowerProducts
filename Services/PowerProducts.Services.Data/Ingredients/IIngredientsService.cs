namespace PowerProducts.Services.Data.Ingredients
{
    using System.Collections.Generic;

    public interface IIngredientsService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAllIngredients<T>();

        T GetIngredientsById<T>(int id);
    }
}
