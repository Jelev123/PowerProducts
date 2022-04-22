namespace PowerProducts.Data.ViewModels.Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using PowerProducts.Data.Models;
    using PowerProducts.Data.ViewModels.Enums;

    public class CreateProductViewModel
    {
        public string Name { get; set; }

        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Url]
        [Display(Name = "Image")]

        public string ImageUrl { get; set; }

        [Display(Name = "Subcategory")]

        public int SubCategoryId { get; set; }

        public int Price { get; set; }

        public int IngredientId { get; set; }

        public string Flavors { get; set; }

        public Tastes Tastes { get; set; }

        [Display(Name = "Information")]
        public string Information { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Categories { get; set; }

        public IEnumerable<KeyValuePair<string, string>> SubCategories { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Brands { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Ingredients { get; set; }

    }
}
