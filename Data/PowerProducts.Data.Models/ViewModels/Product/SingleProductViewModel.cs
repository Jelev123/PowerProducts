namespace PowerProducts.Data.ViewModels.Product
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class SingleProductViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BrandName { get; set; }

        public int BrandId { get; set; }

        public string Information { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string Taste { get; set; }

        public string OriginalUrl { get; set; }

        public string ImageUrl { get; set; }

        public double AverageVote { get; set; }

        public string IngredientName { get; set; }

        public int IngredientId { get; set; }

        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        public string SubCategoryName { get; set; }

        public int SubcategoryId { get; set; }

        public IEnumerable<CategoriesViewModel> Categories { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, SingleProductViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                            x.Images.FirstOrDefault().RemoteImageUrl :
                            "/images/products/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault()));
        }
    }
}
