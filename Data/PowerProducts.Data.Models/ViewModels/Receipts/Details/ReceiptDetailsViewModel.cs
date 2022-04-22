namespace PowerProducts.Data.Models.ViewModels.Receipts.Details
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;
    using PowerProducts.Data.Models.ViewModels.ServiceModels;
    using PowerProducts.Services.Mapping;

    public class ReceiptDetailsViewModel : IMapFrom<ReceiptServiceModel>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Recipient { get; set; }

        public DateTime IssuedOn { get; set; }

        public List<ReceiptDetailsOrderViewModel> Orders { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<ReceiptServiceModel, ReceiptDetailsViewModel>()
                .ForMember(destination => destination.Recipient,
                            opts => opts.MapFrom(origin => origin.Recipient.UserName));
        }
    }
}
