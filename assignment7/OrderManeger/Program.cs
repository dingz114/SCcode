using OrderManeger;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
namespace OrderManeger
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 数据库自增
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }
    }
    public class OrderService
    {
        private readonly OrderContext context;

        public OrderService(OrderContext context)
        {
            this.context = context;
        }

        public void AddOrder(Order order)
        {
            //if (context.Orders.Any(o => o.OrderId == order.OrderId))
            //    throw new Exception("订单已存在");

            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void RemoveOrder(int orderId)
        {
            var order = context.Orders.Find(orderId);
            if (order == null) throw new Exception("订单不存在");

            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public void UpdateOrder(int orderId, Order updatedOrder)
        {
            var order = context.Orders.Find(orderId);
            if (order == null) throw new Exception("订单不存在");

            order.ProductName = updatedOrder.ProductName;
            order.Customer = updatedOrder.Customer;
            order.Amount = updatedOrder.Amount;
            context.SaveChanges();
        }

        public List<Order> QueryOrders() => context.Orders.ToList();

        public Order GetOrderById(int orderId) =>
            context.Orders.Find(orderId) ?? throw new Exception("订单不存在");
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