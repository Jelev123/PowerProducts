namespace PowerProducts.Services.Data.ServiceModels
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using PowerProducts.Data.Models;
    using PowerProducts.Services.Mapping;

    public class UserServiceModel : IdentityUser, IMapFrom<ApplicationUser>
    {
        public string FullName { get; set; }

        public List<OrderServiceModel> Orders { get; set; }
    }
}
