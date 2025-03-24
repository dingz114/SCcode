using System;
namespace OrderManage
{
    public class Order
    {
        public string OrderID, GoodsName, client;
        public double money;
        public Order(string OrderID, string GoodsName, string client, double money)
        {
            this.OrderID = OrderID;
            this.GoodsName = GoodsName;
            this.client = client;
            this.money = money;
        }
        public override bool Equals(object obj)
        {
            if (obj is Order other)
            {
                return this.OrderID == other.OrderID;
            }
            return false;
        }
        public override string ToString()
        {
            return $"OrderID: {OrderID}, GoodsName: {GoodsName}, client: {client}, money: {money}";
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

        public void RemoveOrder(string OrderID)
        {
            var order = orders.FirstOrDefault(o => o.OrderID == OrderID);
            if (order != null)
            {
                orders.Remove(order);
            }
            else
            {
                throw new Exception("Order not found.");
            }
        }

        public void UpdateOrder(string OrderID, Order updateOrder)
        {
            var index = orders.FindIndex(o => o.OrderID == OrderID);
            if (index != -1)
            {
                orders[index] = updateOrder;
            }
            else
            {
                throw new Exception("Order not found.");
            }
        }

        public IEnumerable<Order> QueryOrders(string GoodsName = null, string client = null, double? money = null)
        {
            var query = from order in orders
                        where (GoodsName == null || order.GoodsName == GoodsName) &&
                              (client == null || order.client == client) &&
                              (money == null || order.money == money)
                        orderby order.money descending
                        select order;
            return query;
        }
        public void SortOrders(Func<Order, IComparable> key)
        {
            orders.Sort((x, y) => key(x).CompareTo(key(y)));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1= new Order("1", "Product A", "Customer 1", 100);
            Order order2= new Order("2", "Product B", "Customer 2", 200);
            Order order3= new Order("3", "Product C", "Customer 3", 300);
            OrderService service = new OrderService();

            // 添加订单
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);

            // 查询订单
            var orders = service.QueryOrders(GoodsName: "Product A");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }

            // 删除订单
            try
            {
                service.RemoveOrder("1");
                Console.WriteLine("Order removed successfully.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            // 修改订单
            Order order4= new Order("4", "Product D", "Customer 4", 400);
            try
            {
                service.UpdateOrder("2",order4);
                Console.WriteLine("Order updated successfully.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            // 排序订单
            service.SortOrders(order => order.OrderID);
            foreach (var order in service.orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
