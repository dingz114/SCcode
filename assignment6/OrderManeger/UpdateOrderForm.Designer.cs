namespace OrderManeger
{
    partial class UpdateOrderForm
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
            btnSave = new Button();
            btnCancel = new Button();
            txtAmount = new TextBox();
            txtProductName = new TextBox();
            txtCustomer = new TextBox();
            txtOrderId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(221, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 19;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(86, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(190, 140);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(190, 59);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 16;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(190, 100);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 27);
            txtCustomer.TabIndex = 15;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(190, 21);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 143);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 13;
            label4.Text = "订单金额";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 103);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "客户名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "产品名称";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 10;
            label1.Text = "订单编号";
            // 
            // UpdateOrderForm
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
            Name = "UpdateOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "修改订单";
            Load += UpdateOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtAmount;
        private TextBox txtProductName;
        private TextBox txtCustomer;
        private TextBox txtOrderId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}