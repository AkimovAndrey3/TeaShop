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

namespace TeaShop
{
    public partial class DeleteEmployeeForm : Form
    {
        private string _shopName { get; set; }

        public DeleteEmployeeForm(string shopName)
        {
            InitializeComponent();
            _shopName = shopName;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (IDTxtBox.TextLength > 0)
            {
                UserController.DeleteUser(_shopName, int.Parse(IDTxtBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
