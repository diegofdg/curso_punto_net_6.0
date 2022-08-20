using _30_API_Dapper.Data;
using _30_API_Dapper.Models;

namespace _30_API_Dapper.Rules
{
    public class ProductRule
    {
        public List<Product> GetAllProducts()
        {
            var data = new NorthwindData();
            return data.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            var data = new NorthwindData();
            return data.GetProductById(id);
        }

        public List<Orders> GetAllOrders()
        {
            var data = new NorthwindData();
            return data.GetAllOrders();
        }
    }
}
