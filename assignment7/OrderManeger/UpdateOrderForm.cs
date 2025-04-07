using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManeger
{
    public partial class UpdateOrderForm : Form
    {
        private readonly OrderService orderService;
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public UpdateOrderForm(int orderId)
        {
            InitializeComponent();
            OrderId = orderId;
            orderService = new OrderService(new OrderContext());
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            var order = orderService.GetOrderById(OrderId);
            txtOrderId.Text = order.OrderId.ToString();
            txtProductName.Text = order.ProductName;
            txtCustomer.Text = order.Customer;
            txtAmount.Text = order.Amount.ToString("F2");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order = new Order
                {
                    OrderId = OrderId,
                    ProductName = txtProductName.Text,
                    Customer = txtCustomer.Text,
                    Amount = decimal.Parse(txtAmount.Text)
                };
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"输入无效: {ex.Message}");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void UpdateOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
