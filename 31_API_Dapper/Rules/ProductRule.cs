using _31_API_Dapper.Data;
using _31_API_Dapper.Models;

namespace _31_API_Dapper.Rules
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

        public List<Order> GetAllOrders()
        {
            var data = new NorthwindData();
            return data.GetAllOrders();
        }
    }
}
