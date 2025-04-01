namespace OrderManeger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnQuery;
        private TextBox txtQuery;

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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnQuery = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuery = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 553);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtQuery);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnQuery);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 125);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(437, 18);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(94, 29);
            btnQuery.TabIndex = 0;
            btnQuery.Text = "查询订单";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += new EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(160, 82);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "新建订单";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(568, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "删除订单";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(374, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "修改订单";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(266, 20);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(125, 27);
            txtQuery.TabIndex = 4;
            txtQuery.PlaceholderText = "请输入订单号";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "订单管理系统";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);



            //this.dataGridView1 = new DataGridView();
            //this.panel1 = new Panel();
            //this.txtQuery = new TextBox();
            //this.btnQuery = new Button();
            //this.btnAdd = new Button();
            //this.btnDelete = new Button();
            //this.btnUpdate = new Button();

            //// dataGridView1
            //this.dataGridView1.Dock = DockStyle.Fill;
            //this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.AllowUserToAddRows = false;
            //this.dataGridView1.AllowUserToDeleteRows = false;
            //this.dataGridView1.ReadOnly = true;
            //this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //// panel1
            //this.panel1.Dock = DockStyle.Bottom;
            //this.panel1.Height = 50;

            //// txtQuery
            //this.txtQuery.Location = new System.Drawing.Point(10, 10);
            //this.txtQuery.Width = 200;
            //this.txtQuery.PlaceholderText = "输入查询条件";

            //// btnQuery
            //this.btnQuery.Location = new System.Drawing.Point(220, 10);
            //this.btnQuery.Text = "查询";
            //this.btnQuery.Click += new EventHandler(this.btnQuery_Click);

            //// btnAdd
            //this.btnAdd.Location = new System.Drawing.Point(300, 10);
            //this.btnAdd.Text = "新建订单";
            //this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            //// btnDelete
            //this.btnDelete.Location = new System.Drawing.Point(400, 10);
            //this.btnDelete.Text = "删除订单";
            //this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            //// btnUpdate
            //this.btnUpdate.Location = new System.Drawing.Point(500, 10);
            //this.btnUpdate.Text = "修改订单";
            //this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            //// Add controls to panel1
            //this.panel1.Controls.Add(this.txtQuery);
            //this.panel1.Controls.Add(this.btnQuery);
            //this.panel1.Controls.Add(this.btnAdd);
            //this.panel1.Controls.Add(this.btnDelete);
            //this.panel1.Controls.Add(this.btnUpdate);

            //// Add controls to form
            //this.Controls.Add(this.dataGridView1);
            //this.Controls.Add(this.panel1);

            //// Form properties
            //this.ClientSize = new System.Drawing.Size(800, 600);
            //this.Text = "订单管理系统";
        }

        #endregion

        
    }
}
