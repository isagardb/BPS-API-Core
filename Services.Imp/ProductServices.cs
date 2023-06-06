using Common.Products;
using Repository.Contract;
using Services.Contract;

namespace Services.Imp
{
    public class ProductServices : IProductServices
    {
        private readonly IProductsRepository _productsRepository;
        public ProductServices(IProductsRepository productsRepository) {
            _productsRepository = productsRepository;
        }
        public Task<ProductModel> Create(ProductModel item) => _productsRepository.Create(item);

        public Task<int> Delete(string id) => _productsRepository.Delete(id);

        public Task<List<ProductModel>> Get() => _productsRepository.Get();

        public Task<ProductModel> GetById(string id) => _productsRepository.GetById(id);

        public Task<int> Update(ProductModel iteem) => _productsRepository.Update(iteem);
    }
}