namespace PowerProducts.Data.Models;

using System;
using Common.Models;

public class Images : BaseModel<string>
{
    public Images()
    {
        this.Id = Guid.NewGuid().ToString();
    }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; }

    public string RemoteImageUrl { get; set; }
}
