namespace PowerProducts.Data.Models.ViewModels.ServiceModels
{
    using System;
    using System.Collections.Generic;
    using PowerProducts.Services.Data.ServiceModels;
    using PowerProducts.Services.Data.ServiceModels;
    using PowerProducts.Services.Mapping;

    public class ReceiptServiceModel : IMapFrom<Receipt>, IMapTo<Receipt>
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public List<OrderServiceModel> Orders { get; set; }

        public string RecipientId { get; set; }

        public UserServiceModel Recipient { get; set; }
    }
}
