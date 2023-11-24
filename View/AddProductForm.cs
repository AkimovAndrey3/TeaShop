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
    public partial class AddProductForm : Form
    {
        private string _shopName { get; set; }
        private Category _categories;
        private string _typeProduct { get; set; }

        public AddProductForm(string nameShop)
        {
            InitializeComponent();
            _categories = new Category();
            _shopName = nameShop;
            foreach( string type in _categories.GetCategories())
            {
                comboBox1.Items.Add(type);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (name.TextLength > 0 &&
                index.TextLength > 0 &&
                producer.TextLength > 0 &&
                date.TextLength > 0 &&
                price.TextLength > 0 &&
                count.TextLength > 0 &&
                descr.TextLength > 0 &&
                comboBox1.SelectedItem != null)
            {
                Product prod = new Product();
                prod.Item.Name = name.Text;
                prod.Item.Id = Int32.Parse(index.Text);
                prod.Item.Producer = producer.Text;
                prod.Item.CreationDate = date.Text;
                prod.Item.Price = Int32.Parse(price.Text);
                prod.Item.Count = Int32.Parse(count.Text);
                prod.Item.Description = descr.Text;
                prod.Category = _typeProduct;

                DBController.AddProductDB(_shopName, prod);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            index.Text = "";
            producer.Text = "";
            date.Text = "";
            price.Text = "";
            count.Text = "";
            descr.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            _typeProduct = selectedState;
        }
    }
}
