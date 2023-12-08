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
            this.workEnd = new System.Windows.Forms.Label();
            this.workBegin = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.site = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameShop = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магазиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ShopTabControl = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.beginWorkBtn = new System.Windows.Forms.Button();
            this.endWorkBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.menuStrip3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ShopTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // workEnd
            // 
            this.workEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workEnd.Location = new System.Drawing.Point(353, 221);
            this.workEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workEnd.Name = "workEnd";
            this.workEnd.Size = new System.Drawing.Size(115, 53);
            this.workEnd.TabIndex = 24;
            this.workEnd.Text = "Конец работы";
            this.workEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workBegin
            // 
            this.workBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workBegin.Location = new System.Drawing.Point(217, 224);
            this.workBegin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workBegin.Name = "workBegin";
            this.workBegin.Size = new System.Drawing.Size(115, 46);
            this.workBegin.TabIndex = 23;
            this.workBegin.Text = "Начало Работы";
            this.workBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(193, 191);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(53, 17);
            this.address.TabIndex = 22;
            this.address.Text = "Адрес";
            // 
            // site
            // 
            this.site.AutoSize = true;
            this.site.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site.Location = new System.Drawing.Point(191, 159);
            this.site.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(44, 17);
            this.site.TabIndex = 21;
            this.site.Text = "Сайт";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(193, 125);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(79, 18);
            this.phone.TabIndex = 20;
            this.phone.Text = "Телефон ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Время работы: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Адрес : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сайт : ";
            // 
            // nameShop
            // 
            this.nameShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameShop.Location = new System.Drawing.Point(0, 64);
            this.nameShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameShop.Name = "nameShop";
            this.nameShop.Size = new System.Drawing.Size(574, 40);
            this.nameShop.TabIndex = 15;
            this.nameShop.Text = "Название магазина";
            this.nameShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonelabel.Location = new System.Drawing.Point(102, 125);
            this.phonelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(80, 17);
            this.phonelabel.TabIndex = 14;
            this.phonelabel.Text = "Телефон : ";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.магазиныToolStripMenuItem,
            this.ShopToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(574, 29);
            this.menuStrip3.TabIndex = 28;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveInformationToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveInformationToolStripMenuItem
            // 
            this.SaveInformationToolStripMenuItem.Name = "SaveInformationToolStripMenuItem";
            this.SaveInformationToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.SaveInformationToolStripMenuItem.Text = "Сохранить информацию";
            this.SaveInformationToolStripMenuItem.Click += new System.EventHandler(this.SaveInformationToolStripMenuItem_Click);
            // 
            // магазиныToolStripMenuItem
            // 
            this.магазиныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddShopToolStripMenuItem,
            this.DeleteShopToolStripMenuItem});
            this.магазиныToolStripMenuItem.Name = "магазиныToolStripMenuItem";
            this.магазиныToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.магазиныToolStripMenuItem.Text = "Магазины";
            // 
            // AddShopToolStripMenuItem
            // 
            this.AddShopToolStripMenuItem.Name = "AddShopToolStripMenuItem";
            this.AddShopToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.AddShopToolStripMenuItem.Text = "Добавить магазин";
            this.AddShopToolStripMenuItem.Click += new System.EventHandler(this.AddShopToolStripMenuItem_Click);
            // 
            // DeleteShopToolStripMenuItem
            // 
            this.DeleteShopToolStripMenuItem.Name = "DeleteShopToolStripMenuItem";
            this.DeleteShopToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.DeleteShopToolStripMenuItem.Text = "Удалить магазин";
            this.DeleteShopToolStripMenuItem.Click += new System.EventHandler(this.DeleteShopToolStripMenuItem_Click);
            // 
            // ShopToolStripMenuItem
            // 
            this.ShopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsToolStripMenuItem,
            this.EmployeesToolStripMenuItem,
            this.OrdersToolStripMenuItem});
            this.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem";
            this.ShopToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.ShopToolStripMenuItem.Text = "Магазин";
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ProductsToolStripMenuItem.Text = "Товары";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // EmployeesToolStripMenuItem
            // 
            this.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem";
            this.EmployeesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.EmployeesToolStripMenuItem.Text = "Сотрудники";
            this.EmployeesToolStripMenuItem.Click += new System.EventHandler(this.EmployeesToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.OrdersToolStripMenuItem.Text = "Заказы";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(566, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(2, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(2, 2);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(562, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ShopTabControl
            // 
            this.ShopTabControl.Controls.Add(this.tabPage1);
            this.ShopTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopTabControl.Location = new System.Drawing.Point(5, 35);
            this.ShopTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.ShopTabControl.Name = "ShopTabControl";
            this.ShopTabControl.SelectedIndex = 0;
            this.ShopTabControl.Size = new System.Drawing.Size(574, 27);
            this.ShopTabControl.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(336, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "/";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(206, 290);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(143, 36);
            this.LoginBtn.TabIndex = 51;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // beginWorkBtn
            // 
            this.beginWorkBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.beginWorkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginWorkBtn.Location = new System.Drawing.Point(5, 290);
            this.beginWorkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.beginWorkBtn.Name = "beginWorkBtn";
            this.beginWorkBtn.Size = new System.Drawing.Size(177, 36);
            this.beginWorkBtn.TabIndex = 52;
            this.beginWorkBtn.Text = "Начать работу";
            this.beginWorkBtn.UseVisualStyleBackColor = false;
            this.beginWorkBtn.Click += new System.EventHandler(this.beginWorkBtn_Click);
            // 
            // endWorkBtn
            // 
            this.endWorkBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.endWorkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endWorkBtn.Location = new System.Drawing.Point(356, 290);
            this.endWorkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.endWorkBtn.Name = "endWorkBtn";
            this.endWorkBtn.Size = new System.Drawing.Size(207, 36);
            this.endWorkBtn.TabIndex = 53;
            this.endWorkBtn.Text = "Закончить работу";
            this.endWorkBtn.UseVisualStyleBackColor = false;
            this.endWorkBtn.Click += new System.EventHandler(this.endWorkBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.Location = new System.Drawing.Point(206, 290);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(143, 36);
            this.logoutBtn.TabIndex = 54;
            this.logoutBtn.Text = "Выйти";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 337);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.endWorkBtn);
            this.Controls.Add(this.beginWorkBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShopTabControl);
            this.Controls.Add(this.workEnd);
            this.Controls.Add(this.workBegin);
            this.Controls.Add(this.address);
            this.Controls.Add(this.site);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameShop);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ShopTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label workEnd;
        private System.Windows.Forms.Label workBegin;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label site;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameShop;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магазиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteShopToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabControl ShopTabControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button beginWorkBtn;
        private System.Windows.Forms.Button endWorkBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}