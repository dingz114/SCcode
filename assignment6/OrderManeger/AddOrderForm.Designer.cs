namespace OrderManeger
{
    partial class AddOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOrderId = new TextBox();
            txtCustomer = new TextBox();
            txtProductName = new TextBox();
            txtAmount = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "订单编号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "产品名称";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "客户名称";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 152);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "订单金额";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(190, 30);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 4;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(190, 109);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 27);
            txtCustomer.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(190, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(190, 149);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(67, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += new EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(212, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new EventHandler(this.btnSave_Click);
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtAmount);
            Controls.Add(txtProductName);
            Controls.Add(txtCustomer);
            Controls.Add(txtOrderId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "新建订单";
            Load += AddOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOrderId;
        private TextBox txtCustomer;
        private TextBox txtProductName;
        private TextBox txtAmount;
        private Button btnCancel;
        private Button btnSave;
    }
}