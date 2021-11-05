using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
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
        public ObjectId Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId();

        [BsonElement("inStock")]
        public bool InStock { get; set; } = false;

        [BsonElement("onSale")]
        public bool OnSale { get; set; } = false;

        [BsonElement("price")]
        public double Price { get; set; } = 0.0;

        [BsonElement("category")]
        public string Category { get; set; } = "";

        [BsonElement("brand")]
        public string Brand { get; set; } = "";

        [BsonElement("name")]
        public string Name { get; set; } = "";
        [BsonElement("rating")]
        public int Rating { get; set; } = 0;

        [BsonElement("quantity")]
        public int Quantity { get; set; } = 0;

        [BsonElement("description")]
        public string Description { get; set; } = "";

        [BsonElement("sizes")]
        public string[] Sizes { get; set; } = new string[3];

        [BsonElement("colors")]
        public string[] Colors { get; set; } = new string[3];

        [BsonElement("labels")]
        public string[] Labels { get; set; } = new string[3];
        [BsonElement("tags")]
        public string[] Tags { get; set; } = new string[3];

        [BsonElement("image1")]
        public string Image1 { get; set; } = "";

        [BsonElement("image2")]
        public string Image2 { get; set; } = "";

        [BsonElement("image3")]
        public string Image3 { get; set; } = "";

        [BsonElement("image4")]
        public string Image4 { get; set; } = "";

        [BsonElement("image5")]
        public string Image5 { get; set; } = "";

        [BsonElement("image6")]
        public string Image6 { get; set; } = "";

        [BsonElement("image7")]
        public string Image7 { get; set; } = "";

        [BsonElement("image8")]
        public string Image8 { get; set; } = "";

        [BsonElement("image9")]
        public string Image9 { get; set; } = "";

        [BsonElement("image10")]
        public string Image10 { get; set; } = "";

        [BsonElement("image11")]
        public string Image11 { get; set; } = "";
    }
}
