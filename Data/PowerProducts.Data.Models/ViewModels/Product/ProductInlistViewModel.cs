namespace PowerProducts.Data.ViewModels.Food
{

    using AutoMapper;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class ProductInlistViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string OriginalUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, ProductInlistViewModel>()
                .ForMember(x => x.OriginalUrl, opt =>
                    opt.MapFrom(x =>
                        x.OriginalUrl));
        }
    }
}
