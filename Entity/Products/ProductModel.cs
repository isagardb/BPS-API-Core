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
        [BsonElement("category")]
        public string Category { get; set; } = string.Empty;
        [BsonElement("measureIn")]
        public string MeasureIn { get; set; } = string.Empty;
        [BsonElement("productImage")]
        public string ProductImage { get; set; } = string.Empty;
        [BsonElement("productName_en")]
        public string ProductName_en { get; set; } = string.Empty;
        [BsonElement("productName_kn")]
        public string ProductName_kn { get; set; } = string.Empty;
        [BsonElement("productPrice")]
        public Int32 ProductPrice { get; set; }
        [BsonElement("addedDate")]
        public DateTime AddedDate { get;  set; } = DateTime.Now;
        [BsonElement("__v")]
        public Int32 __v { get; set; }
    }
}
