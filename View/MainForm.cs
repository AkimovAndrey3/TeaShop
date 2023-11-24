using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            shop = _mainController.GetShop()[0];
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
                shopItem = _mainController.GetShop()[0];
            else
                shopItem = _mainController.GetShop()[ShopTabControl.SelectedIndex];

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
            foreach (Shop shopItem in _mainController.GetShop())
            {
                TabPage tab = new TabPage();
                tab.Text = shopItem.Name;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = _panelSize;
               
                tab.Controls.Add(panel);
                ShopTabControl.TabPages.Add(tab);
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

        private void ShowGoods_Click(object sender, EventArgs e)
        {
            _mainController.ProductsInfo(_shopName);
        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {
            _mainController.EmployeeInfo(_shopName);
        }

        private void ShowOrders_Click(object sender, EventArgs e)
        {
            _mainController.OrderInfo(_shopName);
        }

        private void SaveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainController.Save();
        }
    }
}
