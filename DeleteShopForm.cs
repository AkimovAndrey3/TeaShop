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
    public partial class DeleteShopForm : Form
    {
        public DeleteShopForm()
        {
            InitializeComponent();
        }

        private void DeleteShop_Click(object sender, EventArgs e)
        {
            if (txtBoxDeleteNameShop.TextLength > 0)
            {
                ContrDB.DeleteShopDB(txtBoxDeleteNameShop.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
