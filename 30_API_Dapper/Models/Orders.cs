namespace _30_API_Dapper.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public List<OrderDetails> Details { get; set; }
    }
}
