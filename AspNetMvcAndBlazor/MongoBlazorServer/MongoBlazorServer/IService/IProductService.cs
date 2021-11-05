using MongoBlazorServer.Data;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.IService
{
    public interface IProductService
    {
        void SaveOrUpdate(Product product);
        void SaveOrUpdateCart(Product product);
        Product GetProduct(ObjectId productId);
        List<Product> GetProducts(ShowModel ShowModel);
        List<Product> GetCartItems();
        string Delete(ObjectId productId);
        void DeleteCartItem(ObjectId productId);
    }
}
