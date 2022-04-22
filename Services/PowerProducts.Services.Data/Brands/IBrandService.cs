﻿namespace PowerProducts.Services.Data
{
    using System.Collections.Generic;

    public interface IBrandService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();

        IEnumerable<T> GetAllBrands<T>();

        T GetBrandById<T>(int id);
    }
}
