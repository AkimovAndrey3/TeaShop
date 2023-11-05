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
        public string name_shop { get; set; }
        public ShopContr control;
        public List<Product> products { get; set; }
        public InfoAboutProductsForm(string nameShop, List<Product> goods)
        {
            InitializeComponent();
            name_shop = nameShop;
            products = goods;
            //Обработчик события обновления
            control = new ShopContr();
            control.update += UpdateTable;

            int index = 0;
            //Добавление в таблицу данныхф
            foreach (Product item in products)
            {
                string name = item.product.name;
                string dateCreate = item.product.date_create;
                int id = item.product.id;
                string producer = item.product.producer;
                int price = item.product.price;
                int count = item.product.count;
                string description = item.product.description;
                string category = item.category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Product item in products)
            {
                string name = item.product.name;
                string dateCreate = item.product.date_create;
                int id = item.product.id;
                string producer = item.product.producer;
                int price = item.product.price;
                int count = item.product.count;
                string description = item.product.description;
                string category = item.category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProd = new AddProductForm(name_shop);
            addProd.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DeleteProductForm addProd = new DeleteProductForm(name_shop);
            addProd.Show();
        }
    }
}
