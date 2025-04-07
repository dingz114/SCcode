using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace OrderManeger
{
    public partial class Form1 : Form
    {
        private readonly OrderService orderService;
        private readonly OrderContext context = new OrderContext();

        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService(context);
            LoadOrders();
        }
        private void LoadOrders() =>
       dataGridView1.DataSource = orderService.QueryOrders();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var orderId = (int)dataGridView1.SelectedRows[0].Cells["OrderId"].Value;
                try
                {
                    orderService.RemoveOrder(orderId);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddOrderForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                orderService.AddOrder(addForm.Order);
                LoadOrders();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var orderIdCell = dataGridView1.SelectedRows[0].Cells["OrderId"];
                if (orderIdCell != null && int.TryParse(orderIdCell.Value?.ToString(), out int orderId))
                {
                    using var updateForm = new UpdateOrderForm(orderId);
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        orderService.UpdateOrder(orderId, updateForm.Order);
                        LoadOrders();
                    }
                }
                else
                {
                    MessageBox.Show("获取订单编号失败，请重试。");
                }
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            var query = txtQuery.Text.Trim();
            if (int.TryParse(query, out int orderId)) // 确保输入的是有效的整数
            {
                var order = orderService.GetOrderById(orderId); // 按订单号查询
                if (order != null)
                {
                    dataGridView1.DataSource = new List<Order> { order }; // 显示单个订单
                }
                else
                {
                    MessageBox.Show("未找到指定订单！");
                    LoadOrders(); // 重新加载所有订单
                }
            }
            else
            {
                MessageBox.Show("请输入有效的订单号！");
                LoadOrders(); // 重新加载所有订单
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
