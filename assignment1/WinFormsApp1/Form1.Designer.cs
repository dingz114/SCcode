namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBoxOperator = new ComboBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperator.Location = new Point(239, 52);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(36, 28);
            comboBoxOperator.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(449, 53);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(56, 29);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "计算";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(540, 57);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(54, 20);
            labelResult.TabIndex = 4;
            labelResult.Text = "结果：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(comboBoxOperator);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBoxOperator;
        private Button buttonCalculate;
        private Label labelResult;
    }
}
