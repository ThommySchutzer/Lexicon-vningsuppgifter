using Öv2A.Models;
using System;
using System.Data.SqlClient;

namespace Öv2A
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertCustomer();
            //InsertRoomType();
            //MakeAnOrder();
            //SelectCustomerEmail(1);
            SelectCustomers();
        }

        public static void InsertCustomer()
        {
            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();

                var model = new Customer();

                Console.Write("Firstname: ");
                model.FirstName = Console.ReadLine();

                Console.Write("Lastname: ");
                model.LastName = Console.ReadLine();

                Console.Write("Email: ");
                model.Email = Console.ReadLine();

                using var cmd = new SqlCommand("INSERT INTO Customers " +
                    "(FirstName, LastName, Email) OUTPUT Inserted.Id " +
                    "VALUES(@FirstName, @LastName, @Email)", conn);
                cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                cmd.Parameters.AddWithValue("@LastName", model.LastName);
                cmd.Parameters.AddWithValue("@Email", model.Email);

                cmd.ExecuteNonQuery();
                
                Console.WriteLine("Customer Created");
            }
        }

        public static void InsertRoomType()
        {
            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();

                var model = new Product();

                Console.Write("Roomtype: ");
                model.Type = Console.ReadLine();

                Console.Write("Price: ");
                model.Price = Convert.ToInt32(Console.ReadLine());

                using var cmd = new SqlCommand("INSERT INTO Products (Name, Price) OUTPUT Inserted.Id VALUES(@Name, @Price)", conn);
                cmd.Parameters.AddWithValue("@Name", model.Type);
                cmd.Parameters.AddWithValue("@Price", model.Price);
                
                cmd.ExecuteNonQuery();
                
                Console.WriteLine("Room Created");
            }
        }
        public static void MakeAnOrder()
        {
            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();

                var model = new Order();

                Console.Write("CustomerId: ");
                model.CustomerId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Roomtype: ");
                model.ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number Of Days: ");
                model.NumberOfDays = Convert.ToInt32(Console.ReadLine());

                Console.Write("Total Amount: ");
                model.Total = Convert.ToInt32(Console.ReadLine());

                using var cmd = new SqlCommand("INSERT INTO Orders (CustomerId, ProductId, NrOfDays, Total) OUTPUT Inserted.Id VALUES(@CustomerId, @ProductId, @NrOfDays, @Total)", conn);
                cmd.Parameters.AddWithValue("@CustomerId", model.CustomerId);
                cmd.Parameters.AddWithValue("@ProductId", model.ProductId);
                cmd.Parameters.AddWithValue("@NrOfDays", model.NumberOfDays);
                cmd.Parameters.AddWithValue("@Total", model.Total);

                cmd.ExecuteNonQuery();
                
                Console.WriteLine("Order Completed");
            }
        }

        public static void SelectCustomerEmail(int id)
        {
            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using var cmd = new SqlCommand("SELECT Email FROM Customers WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                var result = (string)cmd.ExecuteScalar();
                Console.WriteLine(result);
            }
        }

        public static void SelectCustomers()
        {
            using (var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\TILLT\SOURCE\SQL\SQLDB.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                using var cmd = new SqlCommand("SELECT * FROM Customers", conn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Console.WriteLine($"{result.GetValue(1)} {result.GetValue(2)}");
                }


            }
        }
    }
}