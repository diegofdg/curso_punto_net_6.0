namespace _31_API_Dapper.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public List<OrderDetails> Details { get; set; }
    }
}
