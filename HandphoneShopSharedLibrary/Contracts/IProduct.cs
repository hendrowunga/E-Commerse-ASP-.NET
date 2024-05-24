using HandphoneShopSharedLibrary.Models;
using HandphoneShopSharedLibrary.Responses;


namespace HandphoneShopSharedLibrary.Contracts
{
    public interface IProduct
    {
        Task<ServiceResponse> AddProduct(Product model);
        Task<List<Product>> GetAllProducts(bool featuredProducts);
    }
}
