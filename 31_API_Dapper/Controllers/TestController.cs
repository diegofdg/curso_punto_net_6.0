using _30_API_Dapper.Models;
using _31_API_Dapper.Models;
using _31_API_Dapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _31_API_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/api/products")]
        public List<Product> GetAllProduct()
        {
            var rule = new ProductRule();
            return rule.GetAllProducts();
        }

        [HttpGet("/api/products/{id}")]
        public Product GetProduct(int id)
        {
            var rule = new ProductRule();
            return rule.GetProductById(id);
        }

        [HttpGet("/api/orders")]
        public List<Order> GetAllOrders()
        {
            var rule = new OrderRule();
            return rule.GetAllOrders();
        }

        [HttpDelete("/api/orders")]
        public RespuestaDelete DeleteOrderById(int orderId)
        {
            var rule = new OrderRule();
            return rule.DeleteOrderById(orderId);
        }
    }
}
