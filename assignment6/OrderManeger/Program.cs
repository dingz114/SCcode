using OrderManeger;
using System;
using System.Windows.Forms;
namespace OrderManeger
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Order other)
            {
                return this.OrderId == other.OrderId;
            }
            return false;
        }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, ProductName: {ProductName}, Customer: {Customer}, Amount: {Amount}";
        }
    }
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                orders.Add(order);
            }
            else
            {
                throw new Exception("Order already exists.");
            }
        }

        public void RemoveOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
            else
            {
                throw new Exception("Order not found.");
            }
        }

        public void UpdateOrder(int orderId, Order updatedOrder)
        {
            var index = orders.FindIndex(o => o.OrderId == orderId);
            if (index != -1)
            {
                orders[index] = updatedOrder;
            }
            else
            {
                throw new Exception("Order not found.");
            }
        }

        public IEnumerable<Order> QueryOrders(string productName = null, string customer = null, decimal? amount = null)
        {
            var query = from order in orders
                        where (productName == null || order.ProductName == productName) &&
                              (customer == null || order.Customer == customer) &&
                              (amount == null || order.Amount == amount)
                        orderby order.Amount descending
                        select order;

            return query;
        }

        public void SortOrders(Func<Order, IComparable> keySelector)
        {
            orders.Sort((x, y) => keySelector(x).CompareTo(keySelector(y)));
        }
        public Order GetOrderById(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new Exception("订单不存在！");
            return order;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 创建并显示主窗体
            Application.Run(new Form1());

        }
    }
}