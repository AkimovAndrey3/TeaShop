namespace TeaShop
{
    partial class MainForm
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
            this.ShowEmployees = new System.Windows.Forms.Button();
            this.ShowGoods = new System.Windows.Forms.Button();
            this.workEnd = new System.Windows.Forms.Label();
            this.workBegin = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.site = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameShop = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магазиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ShopTabControl = new System.Windows.Forms.TabControl();
            this.ShowOrders = new System.Windows.Forms.Button();
            this.menuStrip3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ShopTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowEmployees
            // 
            this.ShowEmployees.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmployees.Location = new System.Drawing.Point(697, 321);
            this.ShowEmployees.Name = "ShowEmployees";
            this.ShowEmployees.Size = new System.Drawing.Size(224, 47);
            this.ShowEmployees.TabIndex = 26;
            this.ShowEmployees.Text = "Список сотрудников";
            this.ShowEmployees.UseVisualStyleBackColor = true;
            this.ShowEmployees.Click += new System.EventHandler(this.ShowEmployees_Click);
            // 
            // ShowGoods
            // 
            this.ShowGoods.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGoods.Location = new System.Drawing.Point(697, 241);
            this.ShowGoods.Name = "ShowGoods";
            this.ShowGoods.Size = new System.Drawing.Size(224, 47);
            this.ShowGoods.TabIndex = 25;
            this.ShowGoods.Text = "Показать товары";
            this.ShowGoods.UseVisualStyleBackColor = true;
            this.ShowGoods.Click += new System.EventHandler(this.ShowGoods_Click);
            // 
            // workEnd
            // 
            this.workEnd.AutoSize = true;
            this.workEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workEnd.Location = new System.Drawing.Point(167, 382);
            this.workEnd.Name = "workEnd";
            this.workEnd.Size = new System.Drawing.Size(139, 20);
            this.workEnd.TabIndex = 24;
            this.workEnd.Text = "Конец работы";
            // 
            // workBegin
            // 
            this.workBegin.AutoSize = true;
            this.workBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workBegin.Location = new System.Drawing.Point(167, 348);
            this.workBegin.Name = "workBegin";
            this.workBegin.Size = new System.Drawing.Size(153, 20);
            this.workBegin.TabIndex = 23;
            this.workBegin.Text = "Начало Работы";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(134, 308);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(67, 20);
            this.address.TabIndex = 22;
            this.address.Text = "Адрес";
            // 
            // site
            // 
            this.site.AutoSize = true;
            this.site.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site.Location = new System.Drawing.Point(131, 268);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(55, 20);
            this.site.TabIndex = 21;
            this.site.Text = "Сайт";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(134, 227);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(97, 20);
            this.phone.TabIndex = 20;
            this.phone.Text = "Телефон ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Конец работы: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Начало работы: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Адрес : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сайт : ";
            // 
            // nameShop
            // 
            this.nameShop.AutoSize = true;
            this.nameShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameShop.Location = new System.Drawing.Point(406, 169);
            this.nameShop.Name = "nameShop";
            this.nameShop.Size = new System.Drawing.Size(293, 32);
            this.nameShop.TabIndex = 15;
            this.nameShop.Text = "Название магазина";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonelabel.Location = new System.Drawing.Point(12, 227);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(100, 20);
            this.phonelabel.TabIndex = 14;
            this.phonelabel.Text = "Телефон : ";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.магазиныToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip3.TabIndex = 28;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveInformationToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveInformationToolStripMenuItem
            // 
            this.SaveInformationToolStripMenuItem.Name = "SaveInformationToolStripMenuItem";
            this.SaveInformationToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.SaveInformationToolStripMenuItem.Text = "Сохранить информацию";
            this.SaveInformationToolStripMenuItem.Click += new System.EventHandler(this.SaveInformationToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.CloseToolStripMenuItem.Text = "Выход";
            // 
            // магазиныToolStripMenuItem
            // 
            this.магазиныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddShopToolStripMenuItem,
            this.DeleteShopToolStripMenuItem});
            this.магазиныToolStripMenuItem.Name = "магазиныToolStripMenuItem";
            this.магазиныToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.магазиныToolStripMenuItem.Text = "Магазины";
            // 
            // AddShopToolStripMenuItem
            // 
            this.AddShopToolStripMenuItem.Name = "AddShopToolStripMenuItem";
            this.AddShopToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.AddShopToolStripMenuItem.Text = "Добавить магазин";
            this.AddShopToolStripMenuItem.Click += new System.EventHandler(this.AddShopToolStripMenuItem_Click);
            // 
            // DeleteShopToolStripMenuItem
            // 
            this.DeleteShopToolStripMenuItem.Name = "DeleteShopToolStripMenuItem";
            this.DeleteShopToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.DeleteShopToolStripMenuItem.Text = "Удалить магазин";
            this.DeleteShopToolStripMenuItem.Click += new System.EventHandler(this.DeleteShopToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(3, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ShopTabControl
            // 
            this.ShopTabControl.Controls.Add(this.tabPage1);
            this.ShopTabControl.Location = new System.Drawing.Point(3, 59);
            this.ShopTabControl.Name = "ShopTabControl";
            this.ShopTabControl.SelectedIndex = 0;
            this.ShopTabControl.Size = new System.Drawing.Size(1101, 24);
            this.ShopTabControl.TabIndex = 27;
            // 
            // ShowOrders
            // 
            this.ShowOrders.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOrders.Location = new System.Drawing.Point(697, 404);
            this.ShowOrders.Name = "ShowOrders";
            this.ShowOrders.Size = new System.Drawing.Size(224, 47);
            this.ShowOrders.TabIndex = 29;
            this.ShowOrders.Text = "Список заказов";
            this.ShowOrders.UseVisualStyleBackColor = true;
            this.ShowOrders.Click += new System.EventHandler(this.ShowOrders_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 618);
            this.Controls.Add(this.ShowOrders);
            this.Controls.Add(this.ShopTabControl);
            this.Controls.Add(this.ShowEmployees);
            this.Controls.Add(this.ShowGoods);
            this.Controls.Add(this.workEnd);
            this.Controls.Add(this.workBegin);
            this.Controls.Add(this.address);
            this.Controls.Add(this.site);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameShop);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ShopTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowEmployees;
        private System.Windows.Forms.Button ShowGoods;
        private System.Windows.Forms.Label workEnd;
        private System.Windows.Forms.Label workBegin;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label site;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameShop;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магазиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteShopToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabControl ShopTabControl;
        private System.Windows.Forms.Button ShowOrders;
    }
}