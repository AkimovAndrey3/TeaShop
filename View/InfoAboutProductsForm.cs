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
    public partial class InfoAboutProductsForm : Form
    {
        private string _nameShop;
        private ShopController _shopController;
        private List<Product> _products;

        public InfoAboutProductsForm(string nameShop, List<Product> goods)
        {
            InitializeComponent();
            _nameShop = nameShop;
            _products = goods;

            _shopController = new ShopController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Product item in _products)
            {
                string name = item.Item.Name;
                string dateCreate = item.Item.CreationDate;
                int id = item.Item.Id;
                string producer = item.Item.Producer;
                int price = item.Item.Price;
                int count = item.Item.Count;
                string description = item.Item.Description;
                string category = item.Category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Product item in _products)
            {
                string name = item.Item.Name;
                string dateCreate = item.Item.CreationDate;
                int id = item.Item.Id;
                string producer = item.Item.Producer;
                int price = item.Item.Price;
                int count = item.Item.Count;
                string description = item.Item.Description;
                string category = item.Category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(_nameShop);
            addProductForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DeleteProductForm deleteProductForm = new DeleteProductForm(_nameShop);
            deleteProductForm.Show();
        }
    }
}
