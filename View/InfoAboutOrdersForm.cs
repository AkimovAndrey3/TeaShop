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
    public partial class InfoAboutOrdersForm : Form
    {
        private string _shopName;
        private ShopController _shopController;
        private List<Order> _orders;
        private Order _orderTemplate;

        public InfoAboutOrdersForm(string shopName, List<Order> ordersList)
        {
            InitializeComponent();
            _shopName = shopName;
            _orders = ordersList;

            _shopController = new ShopController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Order item in _orders)
            {
                int id = item.OrderNumber;
                string desc = item.Description;
                string prodList = "";
                foreach(OrderLineitem orderItem in item.GetOrdersFields())
                {
                    prodList += orderItem.Product.Item.Name + "; ";
                }
    
                int final_price = item.TotalPrice;

                dataGridView1.Rows.Add(id, desc, prodList, final_price);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(_shopName, _orderTemplate);
            addOrderForm.Show();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Order item in _orders)
            {
                int id = item.OrderNumber;
                string description = item.Description;
                string productList = "";
                foreach (OrderLineitem orderItem in item.GetOrdersFields())
                {
                    productList += orderItem.Product.Item.Name + "; ";
                }

                int finalPrice = item.TotalPrice;
                dataGridView1.Rows.Add(id, description, productList, finalPrice);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
    }
}
