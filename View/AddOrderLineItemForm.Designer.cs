namespace TeaShop
{
    partial class AddOrderLineItemForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descr = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.producer = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 246);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(183, 317);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(178, 32);
            this.ClearBtn.TabIndex = 50;
            this.ClearBtn.Text = "Очистить поля";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Категория:";
            // 
            // descr
            // 
            this.descr.Location = new System.Drawing.Point(200, 279);
            this.descr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(161, 20);
            this.descr.TabIndex = 47;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItemBtn.Location = new System.Drawing.Point(6, 317);
            this.AddItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(167, 32);
            this.AddItemBtn.TabIndex = 46;
            this.AddItemBtn.Text = "Добавить";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(200, 212);
            this.count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(161, 20);
            this.count.TabIndex = 45;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(200, 141);
            this.date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(161, 20);
            this.date.TabIndex = 44;
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(200, 104);
            this.producer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(161, 20);
            this.producer.TabIndex = 43;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(200, 177);
            this.price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(161, 20);
            this.price.TabIndex = 42;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(200, 69);
            this.index.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(161, 20);
            this.index.TabIndex = 41;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(200, 32);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(161, 20);
            this.name.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Вес, гр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Дата изготовления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Производитель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Артикул:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Название:";
            // 
            // AddOrderLineItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 362);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.count);
            this.Controls.Add(this.date);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.price);
            this.Controls.Add(this.index);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrderLineItemForm";
            this.Text = "Добавить предмет заказ";
            this.Load += new System.EventHandler(this.AddOrderLineItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descr;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}