namespace PowerProducts.Services.Data.Receipts
{
    using System.Threading.Tasks;

    public interface IReceiptService
    {
        Task<string> CreateReceipt(string recipientId);

        T Details<T>(string id);

    }
}
