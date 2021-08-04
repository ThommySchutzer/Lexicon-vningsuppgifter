using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using WpfAppWithDapper.Models;

namespace WpfAppWithDapper.Services
{
    public static class Services
    {
        public static void InsertCustomer(string firstName, string lastName, string email)
        {
            using (IDbConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                var model = new Customer();

                model.FirstName = firstName;
                model.LastName = lastName;
                model.Email = email;

                conn.Execute("INSERT INTO Customers (FirstName, LastName, Email)" +
                             "OUTPUT Inserted.Id VALUES(@FirstName, @LastName, @Email)",
                             model);
            }
        }

        public static void InsertRoomType(string type, int prize)
        {
            using (IDbConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                var model = new Product();

                model.Type = type;
                model.Price = prize;

                conn.Execute("INSERT INTO Products (Name, Price)" +
                             "OUTPUT Inserted.Id VALUES(@Type, @Price)",
                             model);
            }
        }

        public static void MakeAnOrder(int customerId, int productId, int numberOfDays, int total)
        {
            using (IDbConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                var model = new Order();

                model.CustomerId = customerId;
                model.ProductId = productId;
                model.NumberOfDays = numberOfDays;
                model.Total = total;

                conn.Execute("INSERT INTO Orders (CustomerId, ProductId, NrOfDays, Total)" +
                             "OUTPUT Inserted.Id VALUES(@CustomerId, @ProductId, @NumberOfDays, @Total)",
                             model);
            }
        }

        public static string SelectCustomerEmail(int id)
        {
            using (IDbConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                var result = conn.QueryFirstOrDefault<Customer>("SELECT * FROM Customers WHERE Id = @Id", new { Id = id });
                return result.Email;
            }
        }

        public static List<Customer> SelectCustomers()
        {
            using (IDbConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                var result = conn.Query<Customer>("SELECT * FROM Customers").ToList();
                return result;
            }
        }
    }
}
