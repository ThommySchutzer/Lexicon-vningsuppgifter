using MongoBlazorServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.IService
{
    public interface IProductService
    {
        void SaveOrUpdate(Product product);
        Product GetProduct(string productId);
        List<Product> GetProducts(ShowModel ShowModel);
        string Delete(string productId);
    }
}
