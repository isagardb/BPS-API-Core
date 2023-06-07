using Common.Products;
using MongoDB.Driver;
using Repository.Contract;

namespace Repository.Imp
{
    public class ProductRepository : IProductsRepository
    {
        private readonly IMongoCollection<ProductModel> _productCollection;

        public ProductRepository(IMongoDatabase database)
        {
            _productCollection = database.GetCollection<ProductModel>("products");
        }

        public async Task<ProductModel> Create(ProductModel item)
        {
            await _productCollection.InsertOneAsync(item);
            return item;
        }

        public async Task<int> Delete(string id)
        {
            ProductModel model = await _productCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            if(model == null)
            {
                return 0;
            }
            await _productCollection.DeleteOneAsync(x => x.Id == id);
            return 1;
        }

        public async Task<List<ProductModel>> Get() => await _productCollection.Find(product => true).ToListAsync();

        public async Task<ProductModel> GetById(string id) => await _productCollection.Find(product => product.Id == id).FirstOrDefaultAsync();

        public async Task<int> Update(ProductModel item)
        {
            ProductModel product = await _productCollection.Find(x => x.Id == item.Id).FirstOrDefaultAsync();
            if(product == null)
            {
                return 0;
            }
            await _productCollection.ReplaceOneAsync(product => product.Id == item.Id, item);
            return 1;
        }
    }
}