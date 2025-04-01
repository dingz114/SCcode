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
    public partial class AddOrderForm : Form
    {
        public Order Order { get; set; }
        public AddOrderForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
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
        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
