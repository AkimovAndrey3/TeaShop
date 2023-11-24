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
    public partial class AddOrderLineItemForm : Form
    {
        private Order _order = new Order();
        private Category _categories;
        private string _shopName;
        private string _typeProduct;

        public AddOrderLineItemForm(string shopName, Order order)
        {
            InitializeComponent();
            _shopName = shopName;
            _categories = new Category();
            foreach (string type in _categories.GetCategories())
            {
                comboBox1.Items.Add(type);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
           
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            OrderLineitem prod = new OrderLineitem();

            if (name.TextLength > 0 &&
               index.TextLength > 0 &&
               producer.TextLength > 0 &&
               date.TextLength > 0 &&
               price.TextLength > 0 &&
               count.TextLength > 0 &&
               descr.TextLength > 0 &&
               comboBox1.SelectedItem != null)
            {
                prod.Product.Item.Name = name.Text;
                prod.Product.Item.Id = Int32.Parse(index.Text);
                prod.Product.Item.Producer = producer.Text;
                prod.Product.Item.CreationDate = date.Text;
                prod.Product.Item.Price = Int32.Parse(price.Text);
                prod.Product.Item.Count = Int32.Parse(count.Text);
                prod.Product.Item.Description = descr.Text;
                prod.Product.Category = _typeProduct;

                _order.AddOrderLineItem(prod);
                AddOrderForm addOrderForm = new AddOrderForm(_shopName, _order);
                addOrderForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            _typeProduct = selectedState;
        }

        private void AddOrderLineItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
