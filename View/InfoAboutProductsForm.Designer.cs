namespace TeaShop
{
    partial class InfoAboutProductsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Params = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProd,
            this.DateCreate,
            this.Index,
            this.Producer,
            this.Price,
            this.Count,
            this.Params,
            this.Type});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameProd
            // 
            this.NameProd.HeaderText = "Название";
            this.NameProd.MinimumWidth = 6;
            this.NameProd.Name = "NameProd";
            this.NameProd.Width = 125;
            // 
            // DateCreate
            // 
            this.DateCreate.HeaderText = "Дата изг.";
            this.DateCreate.MinimumWidth = 6;
            this.DateCreate.Name = "DateCreate";
            this.DateCreate.Width = 125;
            // 
            // Index
            // 
            this.Index.HeaderText = "Артикул";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 125;
            // 
            // Producer
            // 
            this.Producer.HeaderText = "Производитель";
            this.Producer.MinimumWidth = 6;
            this.Producer.Name = "Producer";
            this.Producer.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Вес. гр.";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 125;
            // 
            // Params
            // 
            this.Params.HeaderText = "Описание";
            this.Params.MinimumWidth = 6;
            this.Params.Name = "Params";
            this.Params.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Категория";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProductBtn.Location = new System.Drawing.Point(11, 380);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(142, 39);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Добавить";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProductBtn.Location = new System.Drawing.Point(901, 380);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(142, 39);
            this.DeleteProductBtn.TabIndex = 2;
            this.DeleteProductBtn.Text = "Удалить";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(454, 380);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(142, 39);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InfoAboutProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 430);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoAboutProductsForm";
            this.Text = "Продукты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Params;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}