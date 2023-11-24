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
    public partial class AddOrderForm : Form
    {
        private string _shopName;
        private Order _order = new Order();

        public AddOrderForm(string shopName, Order newOrder)
        {
            InitializeComponent();
            _shopName = shopName;
            _order = newOrder;
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            if (IndexTxt.TextLength > 0 &&
              descTxt.TextLength > 0 &&
              priceTxt.TextLength > 0)
            {
                _order.OrderNumber = Int32.Parse(IndexTxt.Text);
                _order.Description = descTxt.Text;
                _order.TotalPrice = Int32.Parse(priceTxt.Text);
                DBController.AddOrderDB(_shopName, _order);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOLineItemBtn_Click(object sender, EventArgs e)
        {
            AddOrderLineItemForm orderLineitem = new AddOrderLineItemForm(_shopName, _order);
            orderLineitem.Show();
            Close();
        }
    }
}
