﻿namespace TeaShop
{
    partial class InfoAboutOrdersForm
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
            this.AddOrderBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderBtn.Location = new System.Drawing.Point(360, 429);
            this.AddOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(136, 40);
            this.AddOrderBtn.TabIndex = 4;
            this.AddOrderBtn.Text = "Добавить";
            this.AddOrderBtn.UseVisualStyleBackColor = false;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_order,
            this.desc_order,
            this.productList,
            this.totalPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 425);
            this.dataGridView1.TabIndex = 3;
            // 
            // index_order
            // 
            this.index_order.HeaderText = "Номер заказа";
            this.index_order.MinimumWidth = 6;
            this.index_order.Name = "index_order";
            this.index_order.Width = 125;
            // 
            // desc_order
            // 
            this.desc_order.HeaderText = "Описание";
            this.desc_order.MinimumWidth = 6;
            this.desc_order.Name = "desc_order";
            this.desc_order.Width = 200;
            // 
            // productList
            // 
            this.productList.HeaderText = "Список товаров";
            this.productList.MinimumWidth = 6;
            this.productList.Name = "productList";
            this.productList.Width = 350;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Итоговая цена";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Width = 125;
            // 
            // InfoAboutOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 475);
            this.Controls.Add(this.AddOrderBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoAboutOrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}