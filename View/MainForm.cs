using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.Controllers;
using TeaShop.View;

namespace TeaShop
{
    public partial class MainForm : Form
    {
        private MainController _mainController;
        private Size _panelSize;
        private string _shopName;

        public MainForm()
        {
            InitializeComponent();
            _panelSize = new Size();

            _mainController = new MainController();

            _panelSize = tabPage1.Size;
            _mainController.Update += Update;

            ShopTabControl.TabPages.Clear();
            ShopTabControl.SelectedIndexChanged += NewTab;

            Shop shop = new Shop();
            shop = _mainController.GetShops()[0];
            _shopName = shop.Name;
            nameShop.Text = shop.Name;
            phone.Text = shop.PhoneNumber;
            address.Text = shop.Adress;
            site.Text = shop.Website;
            workBegin.Text = shop.BeginWork;
            workEnd.Text = shop.EndWork;

            Update();
        }

        private void NewTab(object sender, EventArgs e)
        {
            Shop shopItem = new Shop();
            if (ShopTabControl.SelectedIndex < 0)
                shopItem = _mainController.GetShops()[0];
            else
                shopItem = _mainController.GetShops()[ShopTabControl.SelectedIndex];

            _shopName = shopItem.Name;
            nameShop.Text = shopItem.Name;
            phone.Text = shopItem.PhoneNumber;
            address.Text = shopItem.Adress;
            site.Text = shopItem.Website;
            workBegin.Text = shopItem.BeginWork;
            workEnd.Text = shopItem.EndWork;
        }
        private void Update()
        {
            ShopTabControl.TabPages.Clear();
            foreach (Shop shopItem in _mainController.GetShops())
            {
                TabPage tab = new TabPage();
                tab.Text = shopItem.Name;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = _panelSize;
               
                tab.Controls.Add(panel);
                ShopTabControl.TabPages.Add(tab);
            }

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (UserController.IsLoggedIn)
            {
                LoginBtn.Visible = false;
                logoutBtn.Visible = true;
                beginWorkBtn.Visible = true;
                endWorkBtn.Visible = true;

                EmployeesToolStripMenuItem.Visible = false;
                if(UserController.IsAdmin)
                {
                    EmployeesToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                LoginBtn.Visible = true;
                logoutBtn.Visible = false;
                beginWorkBtn.Visible = false;
                endWorkBtn.Visible = false;
                EmployeesToolStripMenuItem.Visible = false;
            }
        }

        private void AddShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.AddShop();
        }

        private void DeleteShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.DeleteShop();
        }

        private void SaveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.Save();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.ProductsInfo(_shopName);
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.EmployeeInfo(_shopName);
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.OrderInfo(_shopName);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainController.Save();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_mainController);
            loginForm.ShowDialog();
        }

        private void beginWorkBtn_Click(object sender, EventArgs e)
        {
            UserController.BeginWork(_shopName, DateTime.Now);
        }

        private void endWorkBtn_Click(object sender, EventArgs e)
        {
            UserController.EndWork(_shopName, DateTime.Now);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }
    }
}
