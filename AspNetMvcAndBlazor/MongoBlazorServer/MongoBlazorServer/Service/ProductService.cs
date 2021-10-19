using MongoBlazorServer.Data;
using MongoBlazorServer.IService;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.Service
{
    public class ProductService : IProductService
    {
        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Product> _productCollection = null;
        
        public ProductService()
        {
            //_mongoClient = new MongoClient("mongodb+srv://thoscher:MDBjul21@cluster0.np4yv.mongodb.net/test?retryWrites=true&w=majority");
            _mongoClient = new MongoClient("mongodb+srv://kenkatauser:BytMig123@cluster0.np4yv.mongodb.net/test?retryWrites=true&w=majority");
            _database = _mongoClient.GetDatabase("kenkata_webshop");
            _productCollection = _database.GetCollection<Product>("products");
        }
        
        public string Delete(string productId)
        {
            _productCollection.DeleteOne(p => p.Id == productId);
            return "Deleted";
        }

        public Product GetProduct(string productName)
        {
            return _productCollection.Find(p => p.Name == productName).FirstOrDefault();
        }

        public List<Product> GetProducts(ShowModel ShowModel)
        {
            FilterDefinition<Product> filter;
            

            var builder = Builders<Product>.Filter;
            //filter = builder.Eq("Category", "Men") & builder.Lt("Prize", 400);
            //filter = builder.Empty;
            //filter = builder.AnyEq(p => p.Colors, "White");
            //filter = builder.Gt("Prize", 300) & builder.Lt("Prize", 500);
            //filter = builder.Eq("Category", "Men") | builder.Eq("Category", "Hats");
            filter = builder.Eq("Category", "Men");
            filter |= builder.Eq("Category", "Hats");
            filter |= builder.Eq("Category", "Kids");
            filter &= builder.AnyEq(p => p.Colors, "Black");


            var sort = Builders<Product>.Sort.Ascending("Prize");

            

            return _productCollection.Find(filter).Sort(sort).ToList();

            //if (ShowModel.ShowInStockTrue)
            //{
            //    filter = builder.Eq("InStock", "true");
            //}
            //if (ShowModel.ShowInStockFalse)
            //{
            //    filter = builder.Eq("InStock", "false");
            //}
            //if (ShowModel.ShowOnSaleTrue)
            //{
            //    filter = builder.Eq("OnSale", "true");
            //}
            //if (ShowModel.ShowOnSaleFalse)
            //{
            //    filter = builder.Eq("OnSale", "false");
            //}
            //if (ShowModel.ShowCategoryMen)
            //{
            //    filter = builder.Eq("Category", "Men");
            //}
            //if (ShowModel.ShowCategoryWomen)
            //{
            //    filter = builder.Eq("Category", "Womens");
            //}
            //if (ShowModel.ShowCategoryKids)
            //{
            //    filter = builder.Eq("Category", "Kids");
            //}
            //if (ShowModel.ShowCategoryHats)
            //{
            //    filter = builder.Eq("Category", "Hats");
            //}
            //if (ShowModel.ShowCategoryShoes)
            //{
            //    filter = builder.Eq("Category", "Shoes");
            //}
            //if (ShowModel.ShowCategorySunglasses)
            //{
            //    filter = builder.Eq("Category", "Sunglasses");
            //}
            //if (ShowModel.ShowCategoryWatches)
            //{
            //    filter = builder.Eq("Category", "Watches");
            //}



            //return _productCollection.Find(FilterDefinition<Product>.Empty).ToList();
            //return _productCollection.Find(filter).ToList();
        }

        public void SaveOrUpdate(Product product)
        {
            var productObj = _productCollection.Find(p => p.Id == product.Id).FirstOrDefault();
            if (productObj == null)
            {
                _productCollection.InsertOne(product);
            }
            else
            {
                _productCollection.ReplaceOne(p => p.Id == product.Id, product);
            }
        }
    }
}
