namespace PowerProducts.Data.Models
{
    using System;
    using System.Collections.Generic;

    using PowerProducts.Data.Common.Models;
    using PowerProducts.Data.Models.ViewModels.Receipts.Details;
    using PowerProducts.Services.Mapping;

    public class Receipt : BaseModel<string>, IMapTo<ReceiptDetailsViewModel>
    {
        public DateTime IssuedOn { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        public string RecipientId { get; set; }

        public ApplicationUser Recipient { get; set; }
    }
}
