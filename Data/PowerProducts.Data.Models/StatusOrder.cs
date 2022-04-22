namespace PowerProducts.Data.Models
{
    using PowerProducts.Data.Common.Models;

    public class StatusOrder : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
