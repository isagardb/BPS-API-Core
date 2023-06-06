using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Products
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public string MeasureIn { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public string ProductName_en { get; set; } = string.Empty;
        public string ProductName_kn { get; set; } = string.Empty;
        public string ProductPrice { get; set; } = string.Empty;
        public DateTime AddedDate { get;  set; } = DateTime.Now;
    }
}
