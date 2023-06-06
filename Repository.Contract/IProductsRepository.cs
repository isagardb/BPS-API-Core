using Common.Products;

namespace Repository.Contract
{
    public interface IProductsRepository
    {
        Task<List<ProductModel>> Get();
        Task<ProductModel> GetById(string id);
        Task<ProductModel> Create(ProductModel item);
        Task<int> Update(ProductModel iteem);
        Task<int> Delete(string id);
    }
}