using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Products
{
    public class ProductResponseBody
    {
        public int statusCode { get; set; }
        public string message { get; set; }
        public ProductModel product { get; set; }
        public List<ProductModel> products { get; set; }
    }
}