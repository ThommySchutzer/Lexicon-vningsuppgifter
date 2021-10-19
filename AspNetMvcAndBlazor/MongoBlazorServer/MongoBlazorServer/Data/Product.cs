using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.Data
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

        [BsonElement("inStock")]
        public bool InStock { get; set; } = false;

        [BsonElement("onSale")]
        public bool OnSale { get; set; } = false;

        [BsonElement("prize")]
        public double Prize { get; set; } = 0.0;

        [BsonElement("picture")]
        public string Picture { get; set; } = "";

        [BsonElement("category")]
        public string Category { get; set; } = "";

        [BsonElement("brand")]
        public string Brand { get; set; } = "";

        [BsonElement("name")]
        public string Name { get; set; } = "";

        [BsonElement("about")]
        public string About { get; set; } = "";

        [BsonElement("sizes")]
        public string[] Sizes { get; set; } = new string[3];

        [BsonElement("colors")]
        public string[] Colors { get; set; } = new string[3];

        [BsonElement("labels")]
        public string[] Labels { get; set; } = new string[3];
    }
}
