namespace PowerProducts.Data.ViewModels.Product
{

    using AutoMapper;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class IndexRandomViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }

        public string SubCategory { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, IndexRandomViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                        x.OriginalUrl));
        }
    }
}
