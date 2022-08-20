using _30_API_Dapper.Models;
using Dapper;
using System.Data.SqlClient;

namespace _30_API_Dapper.Data
{
    public class NorthwindData
    {
        public List<Product> GetAllProducts()
        {
            using var cnn = new SqlConnection("Server=DESKTOP-QR7T2GC;Database=Northwind;Trusted_Connection=True;");
            cnn.Open();
            var query = "SELECT * FROM Products";
            var listProduct = cnn.Query<Product>(query).ToList();
            return listProduct;            
        }

        public Product GetProductById(int id)
        {
            using var cnn = new SqlConnection("Server=DESKTOP-QR7T2GC;Database=Northwind;Trusted_Connection=True;");
            cnn.Open();
            var q = "SELECT * FROM Products WHERE ProductId = @id";
            //var product = cnn.Query<Product>(q).FirstOrDefault();
            var product = cnn.QueryFirstOrDefault<Product>(q, new { id });
            return product;
        }

        public Product GetProductById(Product p)
        {
            using var cnn = new SqlConnection("Server=DESKTOP-QR7T2GC;Database=Northwind;Trusted_Connection=True;");
            cnn.Open();
            var q = "SELECT * FROM Products WHERE ProductId = @ProductId";
            //var product = cnn.Query<Product>(q).FirstOrDefault();
            var product = cnn.QueryFirstOrDefault<Product>(q, p);
            return product;
        }

        public List<Orders> GetAllOrders()
        {
            using var cnn = new SqlConnection("Server=DESKTOP-QR7T2GC;Database=Northwind;Trusted_Connection=True;");
            cnn.Open();
            var q = "SELECT * FROM Orders o INNER JOIN [Order Details] od ON o.OrderID = od.OrderID";
            var product = cnn.Query<Orders>(q).ToList();
            return product;
        }
    }
}
