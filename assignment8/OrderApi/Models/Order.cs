namespace OrderApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
    }
}