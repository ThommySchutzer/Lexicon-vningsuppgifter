using MongoBlazorServer.Data;
using MongoBlazorServer.IService;
using MongoDB.Bson;
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
        private IMongoCollection<Product> _cartlistCollection = null;

        public ProductService()
        {
            _mongoClient = new MongoClient("mongodb+srv://kenkatauser:BytMig123@cluster0.np4yv.mongodb.net/test?retryWrites=true&w=majority");
            _database = _mongoClient.GetDatabase("kenkata_webshop");
            _productCollection = _database.GetCollection<Product>("products");
            _cartlistCollection = _database.GetCollection<Product>("cartlist");
        }
        
        public string Delete(ObjectId productId)
        {
            _productCollection.DeleteOne(p => p.Id == productId);
            return "Deleted";
        }

        public Product GetProduct(ObjectId productId)
        {
            return _productCollection.Find(p => p.Id == productId).FirstOrDefault();
        }

        public List<Product> GetProducts(ShowModel ShowModel)
        {
            FilterDefinition<Product> filter;
            SortDefinition<Product> sort;
            var filterBuilder = Builders<Product>.Filter;
            var sortBuilder = Builders<Product>.Sort;
            List<Product> input = new List<Product>();
            List<Product> output = new List<Product>();

            filter = filterBuilder.Empty;
            sort = sortBuilder.Ascending("Id");

            if (ShowModel.SortRating[0])
            {
                if (ShowModel.SortPrice[0])
                {
                    sort = sortBuilder.Descending("Rating").Descending("Price");
                }
                else if (ShowModel.SortPrice[1])
                {
                    sort = sortBuilder.Descending("Rating").Ascending("Price");
                }
                else
                {
                    sort = sortBuilder.Descending("Rating");
                }
            }
            else if (ShowModel.SortRating[1])
            {
                if (ShowModel.SortPrice[0])
                {
                    sort = sortBuilder.Ascending("Rating").Descending("Price");
                }
                else if (ShowModel.SortPrice[1])
                {
                    sort = sortBuilder.Ascending("Rating").Ascending("Price");
                }
                else
                {
                    sort = sortBuilder.Ascending("Rating");
                }
            } else if (ShowModel.SortPrice[0])
            {
                sort = sortBuilder.Descending("Price");
            }
            else if (ShowModel.SortPrice[1])
            {
                sort = sortBuilder.Ascending("Price");
            }

            input = _productCollection.Find(filter).Sort(sort).ToList();

            foreach (Product p in input)
            {
                if(ShowModel.InStock[2] | (p.InStock & ShowModel.InStock[0]) | (!p.InStock & ShowModel.InStock[1]))
                {
                    if (ShowModel.OnSale[2] | (p.OnSale & ShowModel.OnSale[0]) | (!p.OnSale & ShowModel.OnSale[1]))
                    {
                        if (ShowModel.Category[7] 
                            | (p.Category == "Men" & ShowModel.Category[0])
                            | (p.Category == "Women" & ShowModel.Category[1])
                            | (p.Category == "Kids" & ShowModel.Category[2])
                            | (p.Category == "Hats" & ShowModel.Category[3])
                            | (p.Category == "Shoes" & ShowModel.Category[4])
                            | (p.Category == "Sunglasses" & ShowModel.Category[5])
                            | (p.Category == "Watches" & ShowModel.Category[6])
                            )
                            {
                            if (ShowModel.Brand[6]
                                | (p.Brand == "Bexim" & ShowModel.Brand[0])
                                | (p.Brand == "Lighton" & ShowModel.Brand[1])
                                | (p.Brand == "Dismis" & ShowModel.Brand[2])
                                | (p.Brand == "Rosimo" & ShowModel.Brand[3])
                                | (p.Brand == "Dallas" & ShowModel.Brand[4])
                                | (p.Brand == "Concord" & ShowModel.Brand[5])
                                )
                                {
                                if (ShowModel.Sizes[6]
                                    | (((p.Sizes[0] == "XS") | (p.Sizes[1] == "XS") | (p.Sizes[2] == "XS")) & ShowModel.Sizes[0])
                                    | (((p.Sizes[0] == "S") | (p.Sizes[1] == "S") | (p.Sizes[2] == "S")) & ShowModel.Sizes[1])
                                    | (((p.Sizes[0] == "M") | (p.Sizes[1] == "M") | (p.Sizes[2] == "M")) & ShowModel.Sizes[2])
                                    | (((p.Sizes[0] == "L") | (p.Sizes[1] == "L") | (p.Sizes[2] == "L")) & ShowModel.Sizes[3])
                                    | (((p.Sizes[0] == "XL") | (p.Sizes[1] == "XL") | (p.Sizes[2] == "XL")) & ShowModel.Sizes[4])
                                    | (((p.Sizes[0] == "XXL") | (p.Sizes[1] == "XXL") | (p.Sizes[2] == "XXL")) & ShowModel.Sizes[5])
                                    )
                                    {
                                    if (ShowModel.Colors[6]
                                        | (((p.Colors[0] == "Black") | (p.Colors[1] == "Black") | (p.Colors[2] == "Black")) & ShowModel.Colors[0])
                                        | (((p.Colors[0] == "White") | (p.Colors[1] == "White") | (p.Colors[2] == "White")) & ShowModel.Colors[1])
                                        | (((p.Colors[0] == "Red") | (p.Colors[1] == "Red") | (p.Colors[2] == "Red")) & ShowModel.Colors[2])
                                        | (((p.Colors[0] == "Blue") | (p.Colors[1] == "Blue") | (p.Colors[2] == "Blue")) & ShowModel.Colors[3])
                                        | (((p.Colors[0] == "Green") | (p.Colors[1] == "Green") | (p.Colors[2] == "Green")) & ShowModel.Colors[4])
                                        | (((p.Colors[0] == "Yellow") | (p.Colors[1] == "Yellow") | (p.Colors[2] == "Yellow")) & ShowModel.Colors[5])
                                        )
                                        {
                                        if (ShowModel.Labels[4]
                                        | (((p.Labels[0] == "New") | (p.Labels[1] == "New") | (p.Labels[2] == "New")) & ShowModel.Labels[0])
                                        | (((p.Labels[0] == "Hot") | (p.Labels[1] == "Hot") | (p.Labels[2] == "Hot")) & ShowModel.Labels[1])
                                        | (((p.Labels[0] == "-30%") | (p.Labels[1] == "-30%") | (p.Labels[2] == "-30%")) & ShowModel.Labels[2])
                                        | (((p.Labels[0] == "-20%") | (p.Labels[1] == "-20%") | (p.Labels[2] == "-20%")) & ShowModel.Labels[3])
                                        )
                                            {
                                            if (ShowModel.Tags[8]
                                                | (((p.Tags[0] == "Denim") | (p.Tags[1] == "Denim") | (p.Tags[2] == "Denim")) & ShowModel.Tags[0])
                                                | (((p.Tags[0] == "Fashion") | (p.Tags[1] == "Fashion") | (p.Tags[2] == "Fashion")) & ShowModel.Tags[1])
                                                | (((p.Tags[0] == "Winter") | (p.Tags[1] == "Winter") | (p.Tags[2] == "Winter")) & ShowModel.Tags[2])
                                                | (((p.Tags[0] == "Summer") | (p.Tags[1] == "Summer") | (p.Tags[2] == "Summer")) & ShowModel.Tags[3])
                                                | (((p.Tags[0] == "Fleximood") | (p.Tags[1] == "Fleximood") | (p.Tags[2] == "Fleximood")) & ShowModel.Tags[4])
                                                | (((p.Tags[0] == "Trendy") | (p.Tags[1] == "Trendy") | (p.Tags[2] == "Trendy")) & ShowModel.Tags[5])
                                                | (((p.Tags[0] == "Work") | (p.Tags[1] == "Work") | (p.Tags[2] == "Work")) & ShowModel.Tags[6])
                                                | (((p.Tags[0] == "Leasure") | (p.Tags[1] == "Leasure") | (p.Tags[2] == "Leasure")) & ShowModel.Tags[7])
                                            )
                                            {
                                                if (((p.Price >= ShowModel.Price[0]) & (p.Price <= ShowModel.Price[1]))
                                                    & ((p.Rating >= ShowModel.Rating[0]) & (p.Rating <= ShowModel.Rating[1]))
                                                    )
                                                    {
                                                        output.Add(p);
                                                    }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return output;
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

        public List<Product> GetCartItems()
        {
            FilterDefinition<Product> filter;
            var filterBuilder = Builders<Product>.Filter;
            List<Product> input = new List<Product>();
            
            filter = filterBuilder.Empty;

            input = _cartlistCollection.Find(filter).ToList();

            return input;
        }

            public void SaveOrUpdateCart(Product product)
        {
            var productObj = _cartlistCollection.Find(p => p.Id == product.Id).FirstOrDefault();
            if (productObj == null)
            {
                _cartlistCollection.InsertOne(product);
            }
            else
            {
                _cartlistCollection.ReplaceOne(p => p.Id == product.Id, product);
            }
        }

        public void DeleteCartItem(ObjectId productId)
        {
            _cartlistCollection.DeleteOne(p => p.Id == productId);
        }
    }
}
