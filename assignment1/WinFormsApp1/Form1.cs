namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (!double.TryParse(textBox1.Text, out num1) || !double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("��������Ч������!");
                return;
            }

            string op = comboBoxOperator.SelectedItem.ToString();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("��������Ϊ��!");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("��Ч�������!");
                    return;
            }

            labelResult.Text = $"���: {result}";
        }
    
    }
}
