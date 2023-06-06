using Common.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IProductServices
    {
        Task<List<ProductModel>> Get();
        Task<ProductModel> GetById(string id);
        Task<ProductModel> Create(ProductModel item);
        Task<int> Update(ProductModel iteem);
        Task<int> Delete(string id);
    }
}
