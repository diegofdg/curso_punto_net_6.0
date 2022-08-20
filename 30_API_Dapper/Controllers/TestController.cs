using _30_API_Dapper.Models;
using _30_API_Dapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30_API_Dapper.Controllers
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
        public List<Orders> GetAllOrders()
        {
            var rule = new ProductRule();
            return rule.GetAllOrders();
        }
    }
}
