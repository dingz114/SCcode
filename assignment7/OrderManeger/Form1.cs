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
                    MessageBox.Show("��ȡ�������ʧ�ܣ������ԡ�");
                }
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            var query = txtQuery.Text.Trim();
            if (int.TryParse(query, out int orderId)) // ȷ�����������Ч������
            {
                var order = orderService.GetOrderById(orderId); // �������Ų�ѯ
                if (order != null)
                {
                    dataGridView1.DataSource = new List<Order> { order }; // ��ʾ��������
                }
                else
                {
                    MessageBox.Show("δ�ҵ�ָ��������");
                    LoadOrders(); // ���¼������ж���
                }
            }
            else
            {
                MessageBox.Show("��������Ч�Ķ����ţ�");
                LoadOrders(); // ���¼������ж���
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
